using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]List<Animator> selectIcons;

    private void Awake()
    {
        TurnOffLights();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        TurnOnLights();
        GetComponent<AudioSource>().Play();
        //throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TurnOffLights();
    }

    void TurnOnLights()
    {

        for(int i = 0; i < selectIcons.Count; i++)
        {
            selectIcons[i].gameObject.SetActive(true);
        }

    }

    void TurnOffLights()
    {

        for (int i = 0; i < selectIcons.Count; i++)
        {
            selectIcons[i].gameObject.SetActive(false);
        }

    }

}