using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

namespace WorldObjects {
    public class FireplaceObject : WorldObject<ITemperatureBehavior> {
        
        protected new float RepeatTime = 2f;

        protected override void Action(ITemperatureBehavior character) {
            Debug.Log(character);
        }
    }
}