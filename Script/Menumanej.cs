using UnityEngine;
using UnityEngine.UI;

public class Menumanej : MonoBehaviour
{
    public Image taskImage1;
    public Image taskImage2;
    public Image taskImage3;
    public Image taskImage4;
    public Image taskImage5;
    public Image taskImage6;

    private string[] tasks = { "coca", "spr", "qoo", "grp", "zcoca", "mln" };

    // �I�΂ꂽ�摜����ۑ��i�C���X�y�N�^�[�Ŋm�F�\�j
    public string selectedTaskName1;
    public string selectedTaskName2;
    public string selectedTaskName3;
    public string selectedTaskName4;
    public string selectedTaskName5;
    public string selectedTaskName6;

    void Start()
    {
        // �����_����6�̉摜����I���i�d��OK�j
        selectedTaskName1 = tasks[Random.Range(0, tasks.Length)];
        selectedTaskName2 = tasks[Random.Range(0, tasks.Length)];
        selectedTaskName3 = tasks[Random.Range(0, tasks.Length)];
        selectedTaskName4 = tasks[Random.Range(0, tasks.Length)];
        selectedTaskName5 = tasks[Random.Range(0, tasks.Length)];
        selectedTaskName6 = tasks[Random.Range(0, tasks.Length)];

        // ������ TaskManager �ɃZ�b�g
        TaskManager.Instance.taskInstruction = selectedTaskName1;
        TaskManager.Instance.taskInstruction2 = selectedTaskName2;
        TaskManager.Instance.taskInstruction3 = selectedTaskName3;
        TaskManager.Instance.taskInstruction4 = selectedTaskName4;
        TaskManager.Instance.taskInstruction5 = selectedTaskName5;
        TaskManager.Instance.taskInstruction6 = selectedTaskName6;

        // �摜�����ꂼ��� Image UI �ɕ\��
        ShowTaskImage(taskImage1, selectedTaskName1);
        ShowTaskImage(taskImage2, selectedTaskName2);
        ShowTaskImage(taskImage3, selectedTaskName3);
        ShowTaskImage(taskImage4, selectedTaskName4);
        ShowTaskImage(taskImage5, selectedTaskName5);
        ShowTaskImage(taskImage6, selectedTaskName6);
    }

    void ShowTaskImage(Image targetImage, string taskName)
    {
        Sprite taskSprite = Resources.Load<Sprite>("TaskImages/" + taskName); // �������t�H���_���ɒ���

        if (taskSprite != null && targetImage != null)
        {
            targetImage.sprite = taskSprite;// �摜��ݒ�
        }
        else
        {
            //Debug.LogWarning("�摜���ǂݍ��߂܂���: " + taskName + "�i�܂��� Image UI �� null�j");
        }
    }
}
