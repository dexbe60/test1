using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class LetterAsset
{
    public char Letter;
    public Sprite texture;
}
[CreateAssetMenu(fileName = "asset", menuName = "letterAssets", order = 1)]
public class AssetSO : ScriptableObject
{
    public List<LetterAsset> Assets;
}
