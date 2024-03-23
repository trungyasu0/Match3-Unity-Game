using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemConfig", menuName = "ScriptableObjects/ItemConfig")]
public class ItemConfig: ScriptableObject
{
    public ArtStyleSprites[] artStyleSprites;

    //get the sprite of the fish style item
    public ItemSprite GetFishItemSprite(NormalItem.eNormalType itemType)
    {
        for(var i = 0; i < artStyleSprites.Length; i++)
        {
            if (artStyleSprites[i].style != ArtStyle.Fish) continue;
            for(var j = 0; j < artStyleSprites[i].itemSprites.Length; j++)
            {
                if(artStyleSprites[i].itemSprites[j].itemType == itemType)
                {
                    return artStyleSprites[i].itemSprites[j];
                }
            }
        }
        return null;
    }
}

public enum ArtStyle
{
    Vegetable,
    Fish
}

[Serializable]
public class ArtStyleSprites
{
    public ArtStyle style;
    public ItemSprite[] itemSprites;
}

[Serializable]
public class ItemSprite
{
    public NormalItem.eNormalType itemType;
    public Sprite sprite;
}