using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ItemManager : MonoBehaviour

{
    public RectTransform nameTag;

    public void UpdateNameTag(ItemData item)
    {
        nameTag.GetComponentInChildren<TextMeshProUGUI>().text = item.objectName;

        nameTag.sizeDelta = item.nameTagSize;

        nameTag.localPosition = new Vector2(-1, 0.5f);  
    }
}
