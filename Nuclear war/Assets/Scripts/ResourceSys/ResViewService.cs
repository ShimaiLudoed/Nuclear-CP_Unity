using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ResViewService
{
    private static ResViewService instance;
    public static ResViewService Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ResViewService();
            }
            return instance;
        }
    }
    private ResourceViewDataSO viewData;
    private ResourceViewDataSO ViewData
    {
        get
        {
            if(viewData == null)
            {
                viewData = Resources.Load("ResourceViewData") as ResourceViewDataSO;
            }
            return viewData;
        }
    }

    public void SetEnableIcon(Image resourceIcon, ResourceType resourceType)
    {
        if(ViewData.TryGetEnableIcon(resourceType, out Sprite icon))
        {
            resourceIcon.sprite = icon;
        }
    }
    public void SetDisableIcon(Image resourceIcon, ResourceType resourceType)
    {
        if (ViewData.TryGetDisable(resourceType, out Sprite icon))
        {
            resourceIcon.sprite = icon;
        }
    }
}
