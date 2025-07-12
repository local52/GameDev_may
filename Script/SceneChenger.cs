
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    [SerializeField] string sceneName;
    public UnityEngine.UI.Button myButton;
    

    // Use this for initialization
    void Start()
    {
        // Fixed: Corrected the comparison to use InputField.InputType enum instead of string
        
        if (myButton.onClick != null)
        {
            myButton.onClick.AddListener(ChangeScene);//ボタンが押されたとき、ChangeSceneメソッドを呼び出す
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);//SerializedFieldで指定されたシーン名に基づいてシーンを変更する
    }
    
}
