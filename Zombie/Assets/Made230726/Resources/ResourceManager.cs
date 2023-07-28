using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    private static ResourceManager m_instance;
    public static ResourceManager instance
    {
        get
        {
            // ���� �̱��� ������ ���� ������Ʈ�� �Ҵ���� �ʾҴٸ�
            if (m_instance == null)
            {
                // ������ GameManager ������Ʈ�� ã�� �Ҵ�
                m_instance = FindObjectOfType<ResourceManager>();
            }

            // �̱��� ������Ʈ�� ��ȯ
            return m_instance;
        }
    }

    private static string zombieDataPath = default;
    public ZombieData zombieData_Default = default;

    private void Awake()
    {

        zombieDataPath = "Scriptables";
        zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "Zombie Default");

        zombieData_Default = Resources.Load<ZombieData>(zombieDataPath);

        //Debug.LogFormat("Zombie Data Path : {0}", zombieDataPath);
        //Debug.LogFormat("Zombie Data: {0}, {1}, {2}", zombieData_Default.health, zombieData_Default.damage, zombieData_Default.speed);

        Debug.LogFormat("���� Save data�� ����ٰ� �����ϴ� ���� ����̴�. -> {0}", Application.persistentDataPath);

        //AES-256 �����ϴ� ��ȣȭ�� �ֻ���, ������ǻ�ͷε� �մµ� 500��ɸ�
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
