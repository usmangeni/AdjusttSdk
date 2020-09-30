using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAInitializer : MonoBehaviour
{
    private void Awake()
    {
       GameAnalyticsSDK.GameAnalytics.Initialize();
    }
}
