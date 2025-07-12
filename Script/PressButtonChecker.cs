using UnityEngine;
using UnityEngine.UI;

public class TaskButtonChecker : MonoBehaviour
{
    public string taskName;           // ���̃{�^���̖��O�i��: "coca"�j
    
    

    public void OnButtonPressed()
    {
        

        if (IsCorrectTask(taskName))
        {
            //Debug.Log("����: " + taskName);
            

            // �X�R�A���Z
            TaskManager.Instance.taskResult += 1f;
        }
        else
        {
            //Debug.Log("�s����: " + taskName);
           
        }
    }

    private bool IsCorrectTask(string name)
    {
        return name == TaskManager.Instance.taskInstruction ||
               name == TaskManager.Instance.taskInstruction2 ||
               name == TaskManager.Instance.taskInstruction3 ||
               name == TaskManager.Instance.taskInstruction4 ||
               name == TaskManager.Instance.taskInstruction5 ||
               name == TaskManager.Instance.taskInstruction6;


    }
}
