using System;
using ItemInterfaces;
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
            DebugObject();
            active?.SetActive(true);
        }

        public void CleanActiveObject() {
            if (currentActiveObject == null)
                return;
            IActive active = currentActiveObject.GetComponent<IActive>();
            active?.SetActive(false);
            currentActiveObject = null;
        }

        private void DebugObject() {
            IItem<ItemData> item = currentActiveObject.GetComponent<IItem<ItemData>>();
            if (item != null)
                Debug.Log("normal Item: " + item.Data.name);
            IItem<CollectibleItemData> item2 = currentActiveObject.GetComponent<IItem<CollectibleItemData>>();
            if (item2 != null)
                Debug.Log("Collectible Item: " + item2.Data.name);
        }
        
    }
}