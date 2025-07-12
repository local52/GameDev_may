using UnityEngine.SceneManagement;

using UnityEngine;

public class TestManager : MonoBehaviour
{
    // Declare the missing fields for UI elements  
    [SerializeField]public GameObject coca;
    [SerializeField]public GameObject spr;
    [SerializeField]public GameObject qoo;
    [SerializeField]public GameObject grp;
    [SerializeField]public GameObject zcoca;
    [SerializeField]public GameObject mln;

    void Start()
    {
        string instruction = TaskManager.Instance.taskInstruction;

        if (instruction == "Coca")
            coca.gameObject.SetActive(true);
        else if (instruction == "Sprite")
            spr.gameObject.SetActive(true);
        else if (instruction == "Qoo")
            qoo.gameObject.SetActive(true);
        else if (instruction == "Grape")
            grp.gameObject.SetActive(true);
        else if (instruction == "ZeroCoca")
            zcoca.gameObject.SetActive(true);
        else if (instruction == "Melon")
            mln.gameObject.SetActive(true);
    }
}
