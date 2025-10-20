using UnityEngine;

public class recolector2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("escudoTipo1"))
        {
            Puntuacion.instancia.SumarPuntos(20);
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("escudoTipo2"))
        {
            Puntuacion.instancia.SumarPuntos(50);
            other.gameObject.SetActive(false);
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
