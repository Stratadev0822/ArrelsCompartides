using UnityEngine;
using UnityEngine.SceneManagement;
public class EscenaController2 : MonoBehaviour
{
  public void VolverAEscena1ConBooleano()
    {
        // Activamos el booleano
        GameData.miBooleano = true;

        // Cargamos la Escena 1
        SceneManager.LoadScene("Inicio");
    }
}
