/*9. Realizá un programa que resuelva el siguiente problema:  
Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del  total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.  
Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ09 : MonoBehaviour
{
    public string Nombre1, Nombre2, Nombre3;
    public float CapitalAportado_1, CapitalAportado_2, CapitalAportado_3;
    float montototal;


    // Start is called before the first frame update
    void Start()
    {
        montototal = CapitalAportado_1 + CapitalAportado_2 + CapitalAportado_3;
        Debug.Log("Nombre: " + Nombre1+ ". Capital Aportado: $" + CapitalAportado_1 + ". Porcentaje del capital: %" + CapitalAportado_1 *100 / montototal + ". Monto total aportado: $" + montototal);
        Debug.Log("Nombre: " + Nombre2 + ". Capital Aportado: $" + CapitalAportado_2 + ". Porcentaje del capital: %" + CapitalAportado_2 * 100 / montototal + ". Monto total aportado: $" + montototal);
        Debug.Log("Nombre: " + Nombre3 + ". Capital Aportado: $" + CapitalAportado_3 + ". Porcentaje del capital: %" + CapitalAportado_3 * 100 / montototal+ ". Monto total aportado: $" + montototal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
