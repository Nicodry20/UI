using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//crear un array de al menos 5 frutas
//al presionar el boton debe escribirse en el texto Txt_NombreFruta
//un nombre al azar de los contenidos en el array
public class UIManager : MonoBehaviour
{
    public string nombreFruta;
    public Text txtNombreFruta;
    private string[] frutas = { "Manzana", "Banana", "Cereza", "Pera", "Anana" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateNombreFruta()
    {
        txtNombreFruta.text = nombreFruta;

        int indiceAleatorio = Random.Range(0, frutas.Length);
        txtNombreFruta.text = frutas[indiceAleatorio];
    }
}
