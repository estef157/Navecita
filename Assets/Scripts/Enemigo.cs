using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour

{

    [SerializeField] private float velocidad;
    [SerializeField] private float vidas;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0).normalized * velocidad * Time.deltaTime);
        
    }

    public void RecibirDanho(float danhoRecibido)
    {
        vidas -= danhoRecibido;
        if (vidas <= 0)
        {
            Destroy(this.gameObject);
        }
    }


}
