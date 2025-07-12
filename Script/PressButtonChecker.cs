using UnityEngine;
using UnityEngine.UI;

public class TaskButtonChecker : MonoBehaviour
{
    public string taskName;           // このボタンの名前（例: "coca"）
    
    

    public void OnButtonPressed()
    {
        

        if (IsCorrectTask(taskName))
        {
            //Debug.Log("正解: " + taskName);
            

            // スコア加算
            TaskManager.Instance.taskResult += 1f;
        }
        else
        {
            //Debug.Log("不正解: " + taskName);
           
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
