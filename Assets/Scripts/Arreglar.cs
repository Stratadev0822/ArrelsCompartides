using UnityEngine;

public class Arreglar : MonoBehaviour
{
    public GameObject casa;

    [SerializeField] private Sprite Broken;
    [SerializeField] private Sprite Fixed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        Debug.Log("Click");
        if (casa.GetComponent<SpriteRenderer>().sprite == Broken)
        casa.GetComponent<SpriteRenderer>().sprite = Fixed;
        else if(casa.GetComponent<SpriteRenderer>().sprite == Fixed)
        casa.GetComponent<SpriteRenderer>().sprite = Broken;   
    }
}
