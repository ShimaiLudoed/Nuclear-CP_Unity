using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                data = Resources.Load("ResourceData") as ResourceDataSO;
            }
            return data;
        }
    }
    public void SetEnableTime(float Time, ResourceType resourcetype)
    {
        if (Data.EnableTime(resourcetype, out float time)>0)
        {
            Time=time;
        }
    }
    public void SetDisableTime(float Time, ResourceType resourcetype)
    {
        if (Data.DisableTime(resourcetype, out float time) > 0)
        {
            Time = time;
        }
    }
}
