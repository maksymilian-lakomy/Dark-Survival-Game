using System;
using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

namespace WorldObjects {
    [RequireComponent(typeof(Collider2D))]
    public abstract class WorldObject<T>: MonoBehaviour where T : IBehavior {

        protected abstract float RepeatTime { get; }
        protected readonly List<T> CharactersReacting = new List<T>();
        
        private void Awake() {
            InvokeRepeating("ExecuteAction", 0f, RepeatTime);
        }

        protected void OnTriggerEnter2D(Collider2D other) {
            T character = other.GetComponent<T>();
            if (character != null)
                CharactersReacting.Add(character);
        }

        protected void OnTriggerExit2D(Collider2D other) {
            T character = other.GetComponent<T>();
            if (character != null && CharactersReacting.Contains((T)(object)character))
                CharactersReacting.Remove(character);
        }

        private void ExecuteAction() {
            foreach (T character in CharactersReacting) {
                Action(character);
            }
        }

        protected abstract void Action(T character);
    }
}