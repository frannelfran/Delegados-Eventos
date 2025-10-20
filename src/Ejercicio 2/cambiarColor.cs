using UnityEngine;

public class cambiarColor : MonoBehaviour
{
    private GameObject objeto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objeto = this.gameObject.transform.GetChild(1).gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("escudoTipo1"))
        {
            objeto.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (other.gameObject.CompareTag("escudoTipo2"))
        {
            objeto.GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
