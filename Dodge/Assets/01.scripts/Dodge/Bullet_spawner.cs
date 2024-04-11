using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_spawner : MonoBehaviour
{
    public GameObject bullet_prefab; //������ ź���� ���� ������
    public float spawn_rate_min = 0.5f; //�ּ� ���� �ֱ�
    public float spawn_rate_max = 3f; //�ִ� ���� �ֱ�

    Transform target; //�߻��� ���
    float spawn_rate; //���� �ֱ�
    float time_after_spawn;  //�ֱ� ���� �������� ���� �ð�

    // Start is called before the first frame update
    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        time_after_spawn = 0;
        //ź�� ���� ������ spawn_rate_min�� spawn_rate_max ���̿��� ���� ����
        spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);
        //player_controller ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
        target = FindObjectOfType<Player_controller>().transform;
        //FindObjectOfType<Player_controller>().transform;
        //FindObjectOfType �޼���� ������ Ÿ���� ������Ʈ�� �������̰� �� ������Ʈ���� ������ �� ����Ѵ�.
    }

    // Update is called once per frame
    void Update()
    {
        //time_after_spawn ����
        time_after_spawn += Time.deltaTime; // time_after_spawn += time_after_spawn + Time.deltaTime; �� ����



        //�ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (time_after_spawn >= spawn_rate)
        {
            //������ �ð��� ����
            time_after_spawn = 0;

            //bullet_prefab�� ��������
            //transform.position ��ġ�� transform.rotation ȸ������ ����
            GameObject bullet
                = Instantiate(bullet_prefab, transform.position, transform.rotation);
            //������ bullet ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��
            bullet.transform.LookAt(target);

            //������ ���� ������ spawn_rate_min, spawn_rate_max ���̿��� ���� ����
            spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);
        }
        
    }
}