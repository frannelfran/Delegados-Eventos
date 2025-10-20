using UnityEngine;

public class colisionCubo : MonoBehaviour
{
    private GameObject[] tipos1;
    private GameObject[] tipos2;
    private GameObject esferaTipo2;
    private GameObject cilindro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tipos1 = GameObject.FindGameObjectsWithTag("Tipo1");
        tipos2 = GameObject.FindGameObjectsWithTag("Tipo2");
        esferaTipo2 = tipos2[0];
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Comprobar si el cubo colisiona con el cilindro
        if (collision.gameObject.name == "Cylinder")
        {
            cilindro = collision.gameObject;
            // Las esferas de tipo 1 se mueven a mi esfera de tipo 2 seleccionada
            foreach (GameObject esfera in tipos1)
            {
                esfera.GetComponent<movimiento>().MoverHacia(esferaTipo2.transform.position);
            }
            // Las esferas de tipo 2 se desplazan hacia el cilindro
            foreach (GameObject esfera in tipos2)
            {
                esfera.GetComponent<movimiento>().MoverHacia(cilindro.transform.position);
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
