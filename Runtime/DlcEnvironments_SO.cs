using UnityEngine;

namespace com.rafasloth.archviz.core
{

    [CreateAssetMenu(fileName = "environments", menuName = "ScriptableObjects/DLCEnvironmentsScriptableObject", order = 1)]
    public class DlcEnvironments_SO : ScriptableObject
    {
        public string[] Scenes;
    }

}
