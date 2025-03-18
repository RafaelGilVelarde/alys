using UnityEngine;
using UnityEngine.EventSystems;

public class PressButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool Pressed;
    [SerializeField] float RotateAmount;
    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = false;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = true;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Pressed)
        {
            XRManager.XRInstance.Rotate(RotateAmount);
        }
    }
}
