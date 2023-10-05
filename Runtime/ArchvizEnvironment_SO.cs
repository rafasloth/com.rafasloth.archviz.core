using UnityEngine;

namespace com.rafasloth.archviz.core
{

    [CreateAssetMenu(fileName = "environmentData", menuName = "ScriptableObjects/DLCArchvizEnvironmentScriptableObject", order = 1)]
    public class ArchvizEnvironment_SO : ScriptableObject
    {
        public string SceneCatalogAddress;
        public string EnvironmentName;
        public string SceneThumbnailCatalogAddress;
    }

}