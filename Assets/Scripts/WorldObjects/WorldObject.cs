using System;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

namespace WorldObjects {
    [RequireComponent(typeof(Collider2D))]
    public abstract class WorldObject<T>: MonoBehaviour where T : IBehavior {

        protected float RepeatTime = 2f;
        protected readonly List<T> CharactersReacting = new List<T>();
        
        private void Awake() {
            InvokeRepeating("Action", 0f, RepeatTime);
        }

        protected void OnTriggerEnter2D(Collider2D other) {
            T character = GetComponent<T>();
            if (character != null)
                CharactersReacting.Add(character);
        }

        protected void OnTriggerExit2D(Collider2D other) {
            T character = GetComponent<T>();
            if (character != null && CharactersReacting.Contains(character))
                CharactersReacting.Remove(character);
        }

        protected abstract void Action();
    }
}