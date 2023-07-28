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
            // 만약 싱글톤 변수에 아직 오브젝트가 할당되지 않았다면
            if (m_instance == null)
            {
                // 씬에서 GameManager 오브젝트를 찾아 할당
                m_instance = FindObjectOfType<ResourceManager>();
            }

            // 싱글톤 오브젝트를 반환
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

        Debug.LogFormat("게임 Save data를 여기다가 저장하는 것이 상식이다. -> {0}", Application.persistentDataPath);

        //AES-256 현존하는 암호화중 최상위, 슈퍼컴퓨터로도 뚫는데 500년걸림
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
