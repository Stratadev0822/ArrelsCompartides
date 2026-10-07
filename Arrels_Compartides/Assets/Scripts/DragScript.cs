using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class DragScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private bool isDrag = false;
    [SerializeField, TagSelector] private string trashTag;
    [SerializeField] private bool Inside = false;
    private  bool correcta = false;
   
    // Update is called once per frame
    void Update()
    {
        if(isDrag)
        {
            transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    private void OnMouseDown()
    {
        isDrag = true;
    }
    private void OnMouseUp()
    {
        isDrag = false;

        if(Inside)
        {
            Destroy(gameObject);
        }

        
    }
    private void  OnTriggerEnter2D(Collider2D other)
    {
         int capa = LayerMask.NameToLayer("Basura");
        if (other.gameObject.layer == capa){
            Inside = true;
    //INTENTAR SEPARAR LAS PAPELERAS PARA QUE NO PUEDA ESTAR DENTRO DE DOS A LA VEZ
         if (other.CompareTag(trashTag))
            {
                correcta = true;
            }
        else{    correcta = false;}
    }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        
        int capa = LayerMask.NameToLayer("Basura");
        if (other.gameObject.layer == capa){
            Inside = false;
         if (other.CompareTag(trashTag))
    {
    }
    }
        
    }
}
