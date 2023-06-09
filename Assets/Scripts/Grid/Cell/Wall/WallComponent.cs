﻿using UnityEngine;

public class WallComponent : MonoBehaviour
{
    public bool Passable { get; set; }
    
    public void Destroy(float seconds = 0.0f)
    {
        Destroy(this.gameObject, seconds);
    }

    public static WallComponent Instantiate(GameObject parent, WallData data)
    {
        var go = GameObject.Instantiate(data.Prefab, Vector3.zero, Quaternion.identity);
        go.transform.parent = parent.transform;
        go.transform.localPosition = Vector3.zero;
        SetSprite(go, data.Sprite);
        SetPassable(go, data.Passable);
        return go.GetComponent<WallComponent>();
    }
    
    private static void SetSprite(GameObject go, Sprite sprite)
    {
        var spriteRenderer = go.GetComponent<SpriteRenderer>();
        if (spriteRenderer)
        {
            spriteRenderer.sprite = sprite;
        }
    }
    
    private static void SetPassable(GameObject go, bool passable)
    {
        var objectComponent = go.GetComponent<WallComponent>();
        if (objectComponent)
        {
            objectComponent.Passable = passable;
        }
    }
}