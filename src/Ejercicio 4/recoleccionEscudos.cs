using UnityEngine;

public class recoleccionEscudos : MonoBehaviour
{
    private static int puntuacion = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("escudoTipo1"))
        {
            puntuacion += 5;
            Debug.Log("Recolectado Escudo1. Puntos: " + puntuacion);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("escudoTipo2"))
        {
            puntuacion += 10;
            Debug.Log("Recolectado Escudo2. Puntos: " + puntuacion);
            Destroy(other.gameObject);
        }

    }

    private void moverJugador()
    {
        float movimientoVertical = Input.GetAxis("Vertical");
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(movimientoHorizontal, 0, movimientoVertical) * Time.deltaTime * 5f);
    }

    // Update is called once per frame
    void Update()
    {
        moverJugador();
    }
}
