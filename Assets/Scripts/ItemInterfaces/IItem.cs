﻿﻿using UnityEngine;

 namespace ItemInterfaces
 {
     public interface IItem<T> where T: ItemData {
          T ItemData { get; }
     }
 }
