using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectSelect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public float width, height;
    float startWidth, startHeight;
    public GameObject objToPlace;

    private void Start()
    {
        startWidth = this.gameObject.GetComponent<Image>().rectTransform.rect.width;
        startHeight = this.gameObject.GetComponent<Image>().rectTransform.rect.height;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.gameObject.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(width, height);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.gameObject.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(startWidth, startHeight);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject.FindGameObjectWithTag("PartyBoxManager").GetComponent<PartyBoxManager>().DisappearBox();
        GameObject.FindGameObjectWithTag("PartyBoxManager").GetComponent<PartyBoxManager>().DestroySpawned();
    }
}
