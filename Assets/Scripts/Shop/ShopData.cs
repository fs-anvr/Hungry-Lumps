﻿using UnityEngine;

[CreateAssetMenu]
public class ShopData : ScriptableObject
{
    public ShopItem[] items;
    public int activeIndex;
}