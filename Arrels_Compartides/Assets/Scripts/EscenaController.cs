using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaController : MonoBehaviour
{
public SpriteRenderer miSpriteRenderer; 
    
    // Color al que cambiará cuando el booleano sea true
    public Color colorActivado = Color.green; 
    public GameObject exclamacion;
    public string escena;

    void Start()
    {
        // Si no asignaste el SpriteRenderer desde el Inspector, intenta obtenerlo del mismo GameObject
        if (miSpriteRenderer == null)
        {
            miSpriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Comprobamos el booleano guardado en la clase estática
        if (GameData.miBooleano)
        {
            Debug.Log("Volviste a la Escena 1 con el booleano ACTIVADO.");
            
            // Cambiamos el color del Sprite Renderer
            if (miSpriteRenderer != null)
            {
                miSpriteRenderer.color = colorActivado;
                exclamacion.SetActive(false);
            }
        }
    }

    public void IrAEscena2()
    {
        SceneManager.LoadScene(escena);
    }
    
}
