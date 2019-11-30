﻿using UnityEngine;

 namespace ItemInterfaces
 {
     public interface IItem
     {
         string ItemName { get; }
         string ItemDescription { get; }
         Sprite ItemSprite { get; }
     }
 }
