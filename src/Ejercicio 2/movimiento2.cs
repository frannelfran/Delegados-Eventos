using UnityEngine;

public class movimiento2 : MonoBehaviour
{
    private Vector3 destino;
    private bool mover = false;

    public void MoverHacia(Vector3 objetivo)
    {
        destino = objetivo;
        mover = true;
    }
    

    void Update()
    {
        if (mover)
        {
            transform.position = Vector3.MoveTowards(transform.position, destino, Time.deltaTime * 2f);
        }
    }
}
