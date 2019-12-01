using System;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace.Items;
using ItemInterfaces;
using UnityEngine;

namespace DefaultNamespace {
    public class WorldUIManager: MonoBehaviour {

        public static WorldUIManager i;

        private Dictionary<GameObject, GameObject> activeObjects = new Dictionary<GameObject,GameObject>();

        [SerializeField] private Inventory inventoryToRender;
        
        
        private void Awake() {
            if (i == null)
                i = this;
            else if (i != this)
                Destroy(gameObject);
        }

        public void SetActiveObject(GameObject key, GameObject newActiveObject) {
            if (!activeObjects.ContainsKey(key))
                activeObjects.Add(key, null);
            if (activeObjects[key] == newActiveObject)
                return;
            CleanActiveObject(key);
            activeObjects[key] = newActiveObject;
            IActive active = activeObjects[key].GetComponent<IActive>();
            DebugObject(key);
            active?.SetActive(true);
        }

        public GameObject GetActiveObject(GameObject key) {
            if (activeObjects.ContainsKey(key))
                return key;
            return null;
        }

        public void CleanActiveObject(GameObject key) {
            if (!activeObjects.ContainsKey(key) || activeObjects[key] == null)
                return;
            IActive active = activeObjects[key].GetComponent<IActive>();
            active?.SetActive(false);
            activeObjects[key] = null;
        }

        private void DebugObject(GameObject key) {
            IItem<CollectibleItemData> item2 = activeObjects[key].GetComponent<IItem<CollectibleItemData>>();
            if (item2 != null)
                key.GetComponent<Inventory>().AddItem(new InventoryKeyValuePair(item2.Data, 1));
        }
        
    }
}