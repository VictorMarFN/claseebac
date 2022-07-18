using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hola Mundo");
        Debug.Log("Algo Paso");
        Debug.LogWarning("Algo Salio Medio Mal");
        Debug.LogError("Algo Salió Muy Mal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
