using UnityEngine;

public class NpcScrpit : MonoBehaviour
{
    public GameObject dialogo;
    public Dialogue dialogo2;
    public string[] lines;
    public string escena;
    public Sprite Retrato;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
 private void OnMouseDown()
    {
            dialogo.SetActive(true);
            dialogo2.lines = lines;
            dialogo2.escena = escena;
            dialogo2.retrato = Retrato;
    }
}
