using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
[CreateAssetMenu(menuName = "Items/Test")]
public class Items : ScriptableObject
{
    public string Titulo;
    public string Descripcion; 
    public Sprite Imagen;
    public GameObject Prefab;
}
