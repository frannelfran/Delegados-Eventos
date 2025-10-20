using UnityEngine;
using TMPro;

public class GestorPuntuacion : MonoBehaviour
{
    public static GestorPuntuacion instancia;
    public TextMeshProUGUI textoPuntuacion;
    private int puntuacion = 0;

    void Start()
    {
        instancia = this;
    }

    public void SumarPuntos(int puntos)
    {
        puntuacion += puntos;
        textoPuntuacion.text = "Puntuación: " + puntuacion;
    }
}