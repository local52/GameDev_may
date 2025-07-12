using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DrinkCraftButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] public Image targetImage;  // �\���E��\����؂�ւ���摜

    public bool isPressed = false;
    void Start()
    {
        if (targetImage != null)
        {
            targetImage.enabled = false;  // ������Ԃł͔�\���ɂ��Ă���
        }
    }
    void Update()
    {
        if (isPressed && targetImage != null)
        {
            targetImage.enabled = true;  // �����Ă���ԕ\��
        }
        else if (!isPressed && targetImage != null)
        {
            targetImage.enabled = false; // ���������\��
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Debug.Log("�{�^���������n�߂�");
        // �������u�Ԃ̏���
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Debug.Log("�{�^���𗣂���");
        // �������u�Ԃ̏���
        isPressed = false;
    }
}
