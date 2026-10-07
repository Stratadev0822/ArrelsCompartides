using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textC;
    public string[] lines;
    public float textSpeed;
    public GameObject exclamacion;
    private int index;
    private bool escribiendo = false;
    private Coroutine escritura;
    public string escena;
    public EscenaController gm; 
    public Sprite retrato;

    void Start()
    {
        //BUSCA AL HIJO LLAMADO BUSTO
        Transform hijoTransform = transform.Find("Busto");
        textC.text = string.Empty;
        StartDialogue();

        //Le cambia su imagen
        if (hijoTransform != null)
        {
            Image imagenHijo = hijoTransform.GetComponent<Image>();

            if (imagenHijo != null)
            {
                imagenHijo.sprite = retrato;
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (escribiendo)
            {
                StopCoroutine(escritura);
                textC.text = lines[index];
                escribiendo = false;
            }
            else
            {
                NextLine();
            }
        }
    }

public void StartDialogue()
{
    Debug.Log("START DIALOGUE");
    exclamacion.SetActive(false);
    StopAllCoroutines();

    index = 0;
    textC.text = "HOLA";

    escritura = StartCoroutine(TypeLine());
}

    IEnumerator TypeLine()
    {
        escribiendo = true;
        textC.text = string.Empty;

        foreach (char c in lines[index])
        {
           Debug.Log("CARACTER: " + c);

    textC.text += c;

    Debug.Log("TEXTO ACTUAL: [" + textC.text + "]");

    yield return new WaitForSeconds(textSpeed);
        }

        escribiendo = false;
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            escritura = StartCoroutine(TypeLine());
        }
        else
        {
            textC.text = string.Empty;
            
            gameObject.SetActive(false);

            gm.escena = escena;
            gm.IrAEscena2();

        }
    }
}
