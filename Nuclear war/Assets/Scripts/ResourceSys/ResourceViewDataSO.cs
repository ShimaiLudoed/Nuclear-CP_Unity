    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ResViewDataSO", menuName = "SO/New Resources View Data")]
public class ResourceViewDataSO : ScriptableObject
{
    [field:SerializeField] public List<ResourceViewData> ResourceViewData {  get; private set; }
    public bool TryGetEnableIcon(ResourceType resourceType, out Sprite icon)
    {
        icon = null;
        foreach (var viewData in ResourceViewData)
        {
            if(viewData.ResourceType==resourceType)
            {
                icon = viewData.EnableStateIcon;
                return true; 
            }
        }
        return false;
    }

    public bool TryGetDisable(ResourceType resourceType, out Sprite icon)
    {
        icon = null;
        foreach (var viewData in ResourceViewData)
        {
            if (viewData.ResourceType == resourceType)
            {
                icon = viewData.DisableStateIcon;
                return true;
            }
        }
        return false;
    }
}
