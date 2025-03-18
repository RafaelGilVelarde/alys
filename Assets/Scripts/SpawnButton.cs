using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnButton : MenuButton
{

    [SerializeField] ClickSpawn ClickSpawnButton;


    
    // Start is called before the first frame update
    void Start()
    {
        Imagen.sprite = item.Imagen;
        Titulo.text = item.Titulo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetPrefab()
    {
        ClickSpawnButton.Prefab  = item.Prefab;
    }

}
