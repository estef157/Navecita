using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] private GameObject Disparo;
    [SerializeField] private GameObject spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        LimitarMovimiento();
        Disparar();
    }
    private void Movimiento()
    {
       float h =  Input.GetAxisRaw("Horizontal");
       float v = Input.GetAxisRaw("Vertical");

        transform.Translate( new Vector3 (h, v, 0) * velocidad * Time.deltaTime);
    } 

    private void LimitarMovimiento ()
    {

        float limiteArribaY = Mathf.Clamp(transform.position.y, 4.53f, -4.53f);
        float limiteAbajoY = Mathf.Clamp(transform.position.x, -5.2f, 11.14f);

        //falta poner los limites de x y el transform position final.

    }
    private void Disparar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Disparo, spawnpoint.transform.position, Quaternion.identity);
        }
    }
}
