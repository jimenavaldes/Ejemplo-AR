using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class LenteManager : MonoBehaviour
{
    int lenteSeleccionado = 0;

    public Material[] materiales;
    public void SeleccionLentes(int numeroLente)
    {
        GameObject cara = FindObjectOfType<ARFace>().gameObject;
        lenteSeleccionado = numeroLente;

        //Encontrar lentes
        Transform lentesManagar = cara.transform.GetChild(1).transform;

        //Desactivar lentes 
        for (int i = 0; i < lentesManagar.childCount; i++)
        {
            //Activar el lente seleccionado
            lentesManagar.GetChild(i).gameObject.SetActive(i == numeroLente);
        }

    }

    public void CambioColorArmazon(int ColorSeleccionado)
    {
        GameObject lenteACambiar = FindObjectOfType<ARFace>().transform.GetChild(1).GetChild(lenteSeleccionado).gameObject;
        //MeshRenderer rendi = lenteACambiar.GetComponent<MeshRenderer>();
        var rendi = lenteACambiar.GetComponent<MeshRenderer>();
        //Material[] materialesLente = rendi.materials;
        var materialesLente = rendi.materials;
        //if(lenteSeleccionado == 2){
        //  materialesLente[1] = materiales[colorSeleccionado];
        //} else {
        // materialesLente[0] = materiales[colorSeleccionado];
        //}
        materialesLente[lenteSeleccionado == 2 ? 1 : 0] = materiales[ColorSeleccionado];
        rendi.materials = materialesLente;
    }
}
