using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        print("hello world");
     
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }


void move()
{
        transform.rotation = Quaternion.Euler(0, transform.eulerAngles.x, 0);
        Cursor.lockState = CursorLockMode.Locked;
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
        Vector3 position = this.transform.position;
        position.z++;
        this.transform.position = position;
    }
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
        Vector3 position = this.transform.position;
        position.z--;
        this.transform.position = position;
    }
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
        Vector3 position = this.transform.position;
        position.x++;
        this.transform.position = position;
    }
    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
        Vector3 position = this.transform.position;
        position.x--;
        this.transform.position = position;
    }

        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        transform.Rotate(-v, 0, 0);
        transform.Rotate(0,h, 0);
        if (this.transform.rotation.eulerAngles.z != 0)
        {
            this.transform.Rotate(0, 0, -this.transform.rotation.eulerAngles.z);
        }

    }
}