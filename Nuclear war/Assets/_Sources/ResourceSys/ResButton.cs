using Core;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ResourceSys
{
    public class ResButton : MonoBehaviour
    {
        [SerializeField]private ResourceType resourceType1;
        [SerializeField]private ResourceType resourceType2;
        [SerializeField] private Image image1;
        [SerializeField] private Image image2;
        [SerializeField] private Button button1;
        [SerializeField] private Button button2;
        public static event Action endGame;
        private float startTimer;
        private float endTimer;
        private float curTime1=1000f;
        private float curTime2=1000f;
        private bool ISdangerTime;

        private void Awake()
        {       
            ResDataService.Instance.SetEnableTime(ref startTimer, resourceType1);
            ResDataService.Instance.SetDisableTime(ref endTimer, resourceType1);
            ResDataService.Instance.SetEnableTime(ref startTimer, resourceType2);
            ResDataService.Instance.SetDisableTime(ref endTimer, resourceType2);
        }
        private void Start()
        {
            button1.onClick.AddListener(StartCycleForButton1);
            button2.onClick.AddListener(StartCycleForButton2);
        }

        public void StartCycleForButton1()
        {
            ResViewService.Instance.SetEnableIcon(image1, resourceType1);
            ISdangerTime = false;
            curTime1 = startTimer;
            Debug.Log("Кнопка 1: " + resourceType1);
        }

        public void StartCycleForButton2()
        {
            ResViewService.Instance.SetEnableIcon(image2, resourceType2);
            ISdangerTime = false;
            curTime2 = startTimer;
            Debug.Log("Кнопка 2: " + resourceType2);
        }

        public void EndCycle()
        {
            ResViewService.Instance.SetDisableIcon(image1, resourceType1);
            ISdangerTime = true;
            curTime1 = endTimer;
            Debug.Log("Запуск дедли таймера" + ISdangerTime + curTime1);
        }
        public void EndCycle2()
        {
            ResViewService.Instance.SetDisableIcon(image2, resourceType2);
            ISdangerTime = true;
            curTime2 = endTimer;
            Debug.Log("Запуск дедли таймера" + ISdangerTime + curTime2);
        }
        private void Update()
        {
            if (curTime1 <= 0)
            {
                EndCycle();
            }
            else
            {
                curTime1 -= Time.deltaTime;
            }
            if (ISdangerTime&& curTime1<=0)
            {
                endGame?.Invoke();
            }
            if (curTime2 <= 0)
            {
                EndCycle2();
            }
            else
            {
                curTime2 -= Time.deltaTime;
            }
            if (ISdangerTime && curTime2 <= 0)
            {
                endGame?.Invoke();
            }
        }
    }
}   