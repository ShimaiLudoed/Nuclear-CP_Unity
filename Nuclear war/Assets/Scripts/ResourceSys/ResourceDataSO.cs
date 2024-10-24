using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;


[CreateAssetMenu(fileName = "ResourceSO", menuName = "SO/New Resource Data")]
public class ResourceDataSO : ScriptableObject
{
    [field: SerializeField] public List<ResourceData> ResourceData {  get; private set; }

    public bool EnableTime(ResourceType resourceType, out float time)
    {
        time = default;
        foreach (var viewTime in ResourceData)
        {
            if (viewTime.ResourceType== resourceType)
            {
                time = viewTime.EnableTime;
                return true;
            }
        }
        return false;
    }

    public bool DisableTime(ResourceType resourceType, out float time)
    {
        time = default;
        foreach (var viewTime in ResourceData)
        {
            if (viewTime.ResourceType == resourceType)
            {
                time = viewTime.DisableTime;
                return true;
            }
        }
        return false;
    }
}
