﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//3. Crear una variable pública que permita ingresar texto. 
//Permitir que al ejecutar el programa se muestre en la consola un mensaje de saludo que incluya el texto de la variable.
//Por ejemplo, si en la variable se ingresa el texto “Ana”, el mensaje en consola debe decir “Hola
//Ana”.
public class EJ3 : MonoBehaviour
{
    
    public string text1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hola " + text1);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
