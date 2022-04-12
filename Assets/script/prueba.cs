using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    public int precio_producto1;
    public int precio_producto2;
    public int precio_producto3;
    public string nombre_producto1;
    public string nombre_producto2;
    public string nombre_producto3;
    public int cantidad_producto1;
    public int cantidad_producto2;
    public int cantidad_producto3;

    // Start is called before the first frame update
    void Start()
    {
        string nombre_producto = nombre_producto1 + nombre_producto2 + nombre_producto3;
        int precio_producto = precio_producto1 + precio_producto2 + precio_producto3;
        int cantidad_producto = cantidad_producto1 + cantidad_producto2 + cantidad_producto3;
        int total_productos = cantidad_producto * precio_producto;
        int descontado = total_productos * 20 / 100;
        int descuento = total_productos * 80 / 100;
        if (precio_producto1 < 1)
        {
            Debug.Log(" error, no tiene un precio aceptable ");
        }
      else if (precio_producto2 < 1)
        {
            Debug.Log(" error, no tiene un precio aceptable ");
        }
        else if (precio_producto3 < 1)
        {
            Debug.Log(" error, no tiene un precio aceptable ");
        }

        else if (cantidad_producto1 > 3 && cantidad_producto2 > 3 && cantidad_producto3 > 3)
        {
            Debug.Log(" tiene un 20 porciento de descueto que equivale a " +  precio_producto * 20 / 100);
        }

        
        if (cantidad_producto1 < 1 && cantidad_producto2 < 1 && cantidad_producto3 < 1)
        {
            Debug.Log(" error, no ingresó una cantidad aceptable ");
        }

        Debug.Log(" En total todos los productos tiene un precio de " + total_productos + " la cantidad de plata ahorrada es" + descontado + "lo que da un total de" + descuento + "gracias por comprar ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
