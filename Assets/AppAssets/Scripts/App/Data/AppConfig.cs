using UnityEngine;

namespace AppName.Data
{
    [CreateAssetMenu(fileName = "App Config", menuName = "App Config", order = 0)]
    public class AppConfig : ScriptableObject
    {
        public string NetworkingSessionId = "GoldenQuestAR";
    }
}