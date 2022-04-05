/*15. Existen dos reglas que identifican dos conjuntos de valores: 
- El número es de un solo dígito.  
- El número es impar.  
A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA,  estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda,  para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a  ninguno, respectivamente. Definí un lote de prueba de varios números y probá el algoritmo,  escribiendo los resultados. 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ15 : MonoBehaviour
{
    public int Numero;
    bool estaEnA;
    bool estaEnB;
    bool estaEnAmbos;
    bool noEstaEnNinguno;
    // Start is called before the first frame update
    void Start()
    {
        if (Numero <= 9)
        {
            estaEnA = true;
        }
        else
        {
            estaEnA = false;
        }
        if (Numero % 2 != 0)
        {
            estaEnB = true;
        }
        else
        {
            estaEnB = false;
        }
        if (estaEnA == true && estaEnB == true)
        {
            
            estaEnAmbos = true;
        }
        else
        {
            estaEnAmbos = false;
        }
        if (estaEnA == false && estaEnB == false)
        {
            noEstaEnNinguno = true;
        }
        else
        {
            noEstaEnNinguno = false;
        }
        Debug.Log("Pertenece al conjunto A: " + estaEnA);
        Debug.Log("Pertenece al conjunto B: " + estaEnB);
        Debug.Log("Pertenece a ambos conjuntos: " + estaEnAmbos);
        Debug.Log("No pertenece a ningun conjunto: " + noEstaEnNinguno);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
