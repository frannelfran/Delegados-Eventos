using UnityEngine;
using System.Linq;

public class colisionCubo2 : MonoBehaviour
{
    private GameObject[] humanoides1;
    private GameObject[] humanoides2;
    private GameObject escudo1;
    private GameObject escudo2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        humanoides1 = GameObject.FindGameObjectsWithTag("Tipo1");
        humanoides2 = GameObject.FindGameObjectsWithTag("Tipo2");
        escudo1 = GameObject.FindGameObjectWithTag("escudoTipo1");
        escudo2 = GameObject.FindGameObjectWithTag("escudoTipo2");
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Compruebo si el cubo colisiona con cualquier humanoide de tipo 2
        if (humanoides2.Contains(collision.gameObject))
        {
            // Muevo los humanoides de tipo 2 hacia el escudo de tipo 1
            foreach (GameObject humanoide in humanoides2)
            {
                humanoide.GetComponent<movimiento2>().MoverHacia(escudo1.transform.position);
            }
        }

        // Comprobar si el cubo colisiona con cualquier humanoide de tipo 1
        else if (humanoides1.Contains(collision.gameObject))
        {
            foreach (GameObject humanoide in humanoides1)
            {
                humanoide.GetComponent<movimiento2>().MoverHacia(escudo2.transform.position);
            }
        }
    }

    private void moverCubo()
    {
        float movimientoVertical = Input.GetAxis("Vertical");
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(movimientoHorizontal, 0, movimientoVertical) * Time.deltaTime * 5f);
    }
    
    // Update is called once per frame
    void Update()
    {
        moverCubo();
    }
}
