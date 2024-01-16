using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class LenteManager : MonoBehaviour
{
          public void SeleccionLentes(int numeroLente)
          {
             GameObject cara = FindObjectOfType<ARFace>().gameObject;
             
               //Encontrar lentes
             Transform lentesManagar = cara.transform.GetChild(1).transform;
               
               //Desactivar lentes 
              for(int i = 0; i < lentesManagar.childCount; i++)
              { 
                 //Activar el lente seleccionado
                lentesManagar.GetChild(i).gameObject.SetActive(i == numeroLente);
              }

          }
}
