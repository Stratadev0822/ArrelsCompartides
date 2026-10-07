using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Camera cam;
    Vector3 MousePos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MousePos = Input.mousePosition;
        if (cam.transform.position.x >= -6f)
        {
            if (MousePos.x < Screen.width / 8)
            {
                cam.transform.position += new Vector3(-0.1f, 0, 0);
            }
        }
        //else
        //    cam.transform.position = new Vector3(-6f, cam.transform.position.y, cam.transform.position.z);


        if (cam.transform.position.x <= 6f)
        {
            if (MousePos.x > Screen.width * 7 / 8)
            {
                cam.transform.position += new Vector3(0.1f, 0, 0);
            }
        }
        //else
        //    cam.transform.position = new Vector3(6f, cam.transform.position.y, cam.transform.position.z);
    }
}