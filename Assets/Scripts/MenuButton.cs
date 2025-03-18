using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    [SerializeField] protected Items item;
    [SerializeField] protected TextMeshProUGUI Titulo, Descripcion;
    [SerializeField] protected Image Imagen;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite= item.Imagen;
        GetComponentInChildren<TextMeshProUGUI>().text = item.Titulo;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        Imagen.sprite = item.Imagen;
        Titulo.text = item.Titulo;
        Descripcion.text = item.Descripcion;
    }
}
