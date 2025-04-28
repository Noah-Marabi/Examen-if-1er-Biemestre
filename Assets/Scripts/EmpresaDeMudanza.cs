using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpresaDeMudanza : MonoBehaviour
{
    //Decalaracion de Variables

    public int CantidadDeCarga;
    public int DistanciaARecorrer;
    string TipoDeVehiculo;
    int PrecioFinal;
    int CantHoras;
    int PrecioHora;
    int PrecioTotalHoras;
    string Vehiculo;
    // Start is called before the first frame update
    void Start()
    {


        if (CantidadDeCarga < 100)
        {
            Debug.Log("La cantidad de kilogramos a transporta es insuficiente");
            return;
        }
        else if (CantidadDeCarga > 100 && CantidadDeCarga < 2000)
        {
            Vehiculo = "Utilitario";
            PrecioHora = 3000;


            Debug.Log("El tipo de vehiculo que va a usar es un " + Vehiculo);

        }
        else if (CantidadDeCarga >= 2000 && CantidadDeCarga <= 5000)
        {
            Vehiculo = "Pickup";
            PrecioHora = 4500;
            Debug.Log("El tipo de vehiculo que va a usar es una PickUp");
        }
        else if (CantidadDeCarga >= 5000 && CantidadDeCarga <= 10000)
        {
            Vehiculo = "Camion";
            PrecioHora = 7000;
            Debug.Log("El tipo de vehiculo que va a usar es un camion");
        }

        if (DistanciaARecorrer < 1)
        {
            Debug.Log("La distancia a recorrer es insuficiente");
            return;
        }
        else if (DistanciaARecorrer > 25)

        {
           CantHoras = DistanciaARecorrer / 25;
            PrecioFinal = CantHoras * PrecioHora;
            Debug.Log(PrecioFinal);
           
        }

     



        // Update is called once per frame
        void Update()
        {

        }
    }
}





