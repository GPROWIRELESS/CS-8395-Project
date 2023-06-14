using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Manager_Joystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private Image imageJoystickBg;
    private Image imageJoystick;
    private Vector2 positionInput;
    private int testvalue;
    // Start is called before the first frame update
    void Start()
    {
        imageJoystickBg = GetComponent<Image>();
        imageJoystick = transform.GetChild(0).GetComponent<Image>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(
            imageJoystickBg.rectTransform,
            eventData.position,
            eventData.pressEventCamera,
            out positionInput))
        {
            positionInput.x = positionInput.x/(imageJoystickBg.rectTransform.sizeDelta.x);
            positionInput.y = positionInput.y/(imageJoystickBg.rectTransform.sizeDelta.y);
            Debug.Log(positionInput.x.ToString()+"/"+positionInput.y.ToString());
            
            // normalize
            if(positionInput.magnitude > 1.0f)
            {
                positionInput = positionInput.normalized;
            }

            //joystick move
            imageJoystick.rectTransform.anchoredPosition = new Vector2(
                positionInput.x*(imageJoystickBg.rectTransform.sizeDelta.x/2),
                positionInput.y*(imageJoystickBg.rectTransform.sizeDelta.y/2));
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        positionInput = Vector2.zero;
        imageJoystick.rectTransform.anchoredPosition = Vector2.zero;
    }

    //output position
    public float inputHorizontal()
    {
        if (positionInput.x != 0)
            return positionInput.x;
        else
            return Input.GetAxis("Horizontal");
    }

    public float inputVertical()
    {
        if (positionInput.y != 0)
            return positionInput.y;
        else
            return Input.GetAxis("Vertical");
    }
}
