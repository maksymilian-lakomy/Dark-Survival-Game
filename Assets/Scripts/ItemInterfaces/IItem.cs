﻿using UnityEngine;

 namespace ItemInterfaces
 {
     public interface IItem
     {
         string ItemName { get; }
         string ItemDescription { get; }
         GameObject ItemPrefab { get; }

     }
 }
