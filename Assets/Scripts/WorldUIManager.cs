using UnityEngine;

namespace DefaultNamespace {
    public class WorldUIManager: MonoBehaviour {

        public static WorldUIManager i;
        [SerializeField]
        private GameObject currentActiveObject;
        
        
        private void Awake() {
            if (i == null)
                i = this;
            else if (i != this)
                Destroy(gameObject);
        }

        public void SetActiveObject(GameObject newActiveObject) {
            if (currentActiveObject == newActiveObject)
                return;
            CleanActiveObject();
            currentActiveObject = newActiveObject;
            IActive active = currentActiveObject.GetComponent<IActive>();
            active?.SetActive(true);
        }

        public void CleanActiveObject() {
            if (currentActiveObject == null)
                return;
            IActive active = currentActiveObject.GetComponent<IActive>();
            active?.SetActive(false);
            currentActiveObject = null;
        }
        
    }
}