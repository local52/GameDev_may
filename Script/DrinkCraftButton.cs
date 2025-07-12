using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DrinkCraftButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] public Image targetImage;  // 表示・非表示を切り替える画像

    public bool isPressed = false;
    void Start()
    {
        if (targetImage != null)
        {
            targetImage.enabled = false;  // 初期状態では非表示にしておく
        }
    }
    void Update()
    {
        if (isPressed && targetImage != null)
        {
            targetImage.enabled = true;  // 押している間表示
        }
        else if (!isPressed && targetImage != null)
        {
            targetImage.enabled = false; // 離したら非表示
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Debug.Log("ボタンを押し始めた");
        // 押した瞬間の処理
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Debug.Log("ボタンを離した");
        // 離した瞬間の処理
        isPressed = false;
    }
}
