using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ResourceSO", menuName = "SO/New Resource Data")]
public class ResourceDataSO : ScriptableObject
{
    [field: SerializeField] public List<ResourceData> ResourceData {  get; private set; }

    public float EnableTime(ResourceType resourceType, out float time)
    {
        foreach (var viewTime in ResourceData)
        {
            if (viewTime.ResourceType== resourceType)
            {
                time = viewTime.EnableTime;
                return time;
            }
        }
        time = 0f;
        return default;
    }

    public float DisableTime(ResourceType resourceType, out float time)
    {
        foreach (var viewTime in ResourceData)
        {
            if (viewTime.ResourceType == resourceType)
            {
                time = viewTime.DisableTime;
                return time;
            }
        }
        time = 0f;
        return default;
    }
}
