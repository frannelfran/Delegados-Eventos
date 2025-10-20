using UnityEngine;

public class activador : MonoBehaviour
{
    private GameObject[] humanoides1;
    private GameObject[] humanoides2;
    private GameObject escudoObjetivo;
    private GameObject objetivoGrupo2; // Objetivo al que apuntaran los humanoides del grupo 2

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        humanoides1 = GameObject.FindGameObjectsWithTag("Tipo1");
        humanoides2 = GameObject.FindGameObjectsWithTag("Tipo2");
        escudoObjetivo = GameObject.FindGameObjectWithTag("escudoTipo1");
        objetivoGrupo2 = GameObject.FindGameObjectWithTag("escudoTipo2");
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
        GameObject referencia = GameObject.FindGameObjectWithTag("referencia");
        if (Vector3.Distance(transform.position, referencia.transform.position) < 3f)
        {
            foreach (GameObject h in humanoides1)
            {
                h.transform.position = escudoObjetivo.transform.position;
            }

            foreach (GameObject h in humanoides2)
            {
                Vector3 direccion = (objetivoGrupo2.transform.position - h.transform.position).normalized;
                h.transform.forward = direccion;
            }
        }
        moverCubo();
    }
}
