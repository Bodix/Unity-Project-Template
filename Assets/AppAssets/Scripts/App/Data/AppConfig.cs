using UnityEngine;

namespace AppName.App.Data
{
    [CreateAssetMenu(fileName = "App Config", menuName = "App Config", order = 0)]
    public class AppConfig : ScriptableObject
    {
        public int TargetFrameRate = 120;
        public int SleepTimeout = UnityEngine.SleepTimeout.NeverSleep;

        public void ApplyDisplaySettings()
        {
            UnityEngine.Application.targetFrameRate = TargetFrameRate;
            Screen.sleepTimeout = SleepTimeout;
        }
    }
}