using Core;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ResourceSys
{
    public class ResButton : MonoBehaviour
    {
        private ResourceType resourceType;
        [SerializeField] private Image Image;
        [SerializeField] private Button button;
        public static event Action endGame;
        private float startTimer;
        private float endTimer;
        private float curTime=1000f;
        private bool ISdangerTime;

        private void Awake()
        {       
            ResDataService.Instance.SetEnableTime(ref startTimer, resourceType);
            ResDataService.Instance.SetDisableTime(ref endTimer, resourceType);
        }
        private void Start()
        {
            StartCycle();
            button.onClick.AddListener(StartCycle);
        }
        public void StartCycle()
        {
            ResViewService.Instance.SetEnableIcon(Image, resourceType);
            ISdangerTime = false;
            curTime = startTimer;
            Debug.Log("Запуск таймера" + ISdangerTime + curTime + resourceType );
        }
        public void EndCycle()
        {
            ResViewService.Instance.SetDisableIcon(Image, resourceType);
            ISdangerTime = true;
            curTime = endTimer;
            Debug.Log("Запуск дедли таймера" + ISdangerTime + curTime + resourceType);
        }
        private void Update()
        {
            if (curTime <= 0)
            {
                EndCycle();
            }
            else
            {
                curTime -= Time.deltaTime;
            }
            if (ISdangerTime&& curTime<=0)
            {
                endGame?.Invoke();
            }
        }
    }
}