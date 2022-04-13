using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamenUnity : MonoBehaviour
{
    public string Animal;
    public int Tiempo;
    int Cantidad;
    double Costo;
    // Start is called before the first frame update
    void Start()
    {
        if ((Animal == "G" || Animal == "PP" || Animal == "PG") && (Tiempo >= 3))
        {
            Debug.Log("Animal: " + Animal);
            Debug.Log("Tiempo que va a quedarse: " + Tiempo + " días");


            if (Animal == "G")
            {
                Cantidad = 300;
                Costo = Cantidad * 0.8;
                Costo = Tiempo * Costo;
                Debug.Log("Para este período se necesitan " + Tiempo * Cantidad + " gramos de alimento y $" + Costo + ".");
            }

            if (Animal == "PP")
            {
                Cantidad = 400;
                Costo = Cantidad * 0.8;
                Costo = Tiempo * Costo;
                Debug.Log("Para este período se necesitan " + Tiempo * Cantidad + " gramos de alimento y $" + Costo + ".");
            }

            if (Animal == "PG")
            {
                Cantidad = 700;
                Costo = Cantidad * 0.8;
                Costo = Tiempo * Costo;
                Debug.Log("Para este período se necesitan " + Tiempo * Cantidad + " gramos de alimento y $" + Costo + ".");
            }
        }
        else
            if (Tiempo < 3)
            {
                Debug.Log("No se puede calcular ya que el tiempo es menor a tres días.");
            }

            if (Animal != "G" && Animal != "PP" && Animal != "PG")
            {
                Debug.Log("No hay ningún animal con ese nombre.");
            }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}