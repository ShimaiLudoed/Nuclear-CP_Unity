using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ResourceViewData 
{
    [field: SerializeField] public ResourceType ResourceType {  get; private set; }
    [field: SerializeField] public Sprite EnableStateIcon { get; private set; }
    [field: SerializeField] public Sprite DisableStateIcon { get; private set; }

}
