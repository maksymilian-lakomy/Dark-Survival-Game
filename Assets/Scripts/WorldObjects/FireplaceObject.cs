using System.Collections.Generic;
using BehaviorInterfaces;
using UnityEngine;

namespace WorldObjects {
    public class FireplaceObject : WorldObject<ITemperatureBehavior> {

        private float repeatTime = 1f;
        protected override float RepeatTime {
            get => repeatTime;
        }

        protected override void Action(ITemperatureBehavior character) {
            character.TemperatureChange(.5f);
            
        }
    }
}