
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
            myButton.onClick.AddListener(ChangeScene);//�{�^���������ꂽ�Ƃ��AChangeScene���\�b�h���Ăяo��
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);//SerializedField�Ŏw�肳�ꂽ�V�[�����Ɋ�Â��ăV�[����ύX����
    }
    
}
