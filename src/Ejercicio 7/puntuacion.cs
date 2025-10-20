using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    public static Puntuacion instancia;
    public TextMeshProUGUI textoPuntuacion;
    public TextMeshProUGUI textoRecompensa;

    private int puntuacion = 0;
    private int siguienteUmbral = 100;

    void Awake()
    {
        instancia = this;
    }

    public void SumarPuntos(int puntos)
    {
        puntuacion += puntos;
        textoPuntuacion.text = "Puntuación: " + puntuacion;

        if (puntuacion >= siguienteUmbral)
        {
            MostrarRecompensa();
            siguienteUmbral += 100;
        }
    }

    void MostrarRecompensa()
    {
        textoRecompensa.text = "¡Recompensa desbloqueada!";
    }
}