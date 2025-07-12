using UnityEngine;
using UnityEngine.UI;

public class Resultmanej : MonoBehaviour
{
    [SerializeField]public Text resultText;

    private void Start()
    {
        if (TaskManager.Instance == null)
        {
            //Debug.LogError("TaskManagerが存在しません！");
            return;
        }

        float result = TaskManager.Instance.taskResult;
        //Debug.Log("スコア: " + result);

        resultText.text = result >= 6f ? "Perfect!" : "Try Again!";//resltが6以上ならPerfect!、それ以外はTry Again!と表示する
    }

}
