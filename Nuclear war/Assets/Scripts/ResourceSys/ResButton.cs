using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResButton : MonoBehaviour
{
    [SerializeField] private ResourceType resourceType;
    [SerializeField] private Image resIcon;
    [SerializeField] private float startTimer;
    [SerializeField] private float endTimer;
    [SerializeField] private Sprite active;
    [SerializeField] private Sprite disctive;


    private void Awake()
    {
        ResViewService.Instance.SetDisableIcon(resIcon, resourceType);
        ResDataService.Instance.SetDisableTime(endTimer, resourceType);

    }
    private void Start()
    {

    }
}
