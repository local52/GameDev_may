using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public static TaskManager Instance;

    public string taskInstruction;
    public string taskInstruction2;
    public string taskInstruction3;
    public string taskInstruction4;
    public string taskInstruction5;
    public string taskInstruction6;

    public float taskResult;
    void Start()
    {
        string task1 = TaskManager.Instance.taskInstruction;
        string task2 = TaskManager.Instance.taskInstruction2;
        string task3 = TaskManager.Instance.taskInstruction3;
        string task4 = TaskManager.Instance.taskInstruction4;
        string task5 = TaskManager.Instance.taskInstruction5;
        string task6 = TaskManager.Instance.taskInstruction6;

        //Debug.Log("�擾���ꂽ�~�b�V����: " + task1 + ", " + task2 + ", " + task3);
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // �V�[���ԕێ�
        }
        else
        {
            Destroy(gameObject);// ���ɑ��݂���ꍇ�͐V�����C���X�^���X��j��
        }
    }
}
