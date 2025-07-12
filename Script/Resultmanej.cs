using UnityEngine;
using UnityEngine.UI;

public class Resultmanej : MonoBehaviour
{
    [SerializeField]public Text resultText;

    private void Start()
    {
        if (TaskManager.Instance == null)
        {
            //Debug.LogError("TaskManager�����݂��܂���I");
            return;
        }

        float result = TaskManager.Instance.taskResult;
        //Debug.Log("�X�R�A: " + result);

        resultText.text = result >= 6f ? "Perfect!" : "Try Again!";//reslt��6�ȏ�Ȃ�Perfect!�A����ȊO��Try Again!�ƕ\������
    }

}
