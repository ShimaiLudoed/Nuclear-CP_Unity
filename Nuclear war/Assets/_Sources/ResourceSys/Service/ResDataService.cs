using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResourceSys
{
    public class ResDataService
    {
        private static ResDataService instance;
        public static ResDataService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ResDataService();
                }
                return instance;
            }
        }

        private ResourceDataSO data;
        private ResourceDataSO Data
        {
            get
            {
                if (data == null)
                {
                    data = Resources.Load("ResourceSO") as ResourceDataSO;
                }
                return data;
            }
        }
        public void SetEnableTime(ref float timer, ResourceType resourcetype)
        { 
            if (Data.EnableTime(resourcetype, out float time))
            {
                timer = time;
            }
        }
        public void SetDisableTime(ref float timer, ResourceType resourcetype)
        {   
            if (Data.DisableTime(resourcetype, out float time))
            {
                timer = time;
            }
        }
    }
}