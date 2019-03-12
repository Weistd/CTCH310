using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    public int intel = 5;
    public bool hit_on_head = true;
    float test()
    {
        return 5.0f;
    }
    void Greet()
    {
        switch (intel)
        {
            case 5:
                print("Hello, good sir!Do you like physics");
                //if (hit_on_head == true)
                //{ print("Get shot on the head");
                //}
                //intel = 4;
                //Greet();

                break;
            case 4:
                print("Ello guv!");
                break;
            case 3:
                print("what you want?");
                break;
            case 2:
                print("ug...me hunger");
                break;
            case 1:
                print("Grrrrrrrrr....*fart*");
                break;
            case 0:
                print("drools");
                break;
            default:
                print("hello!");
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Greet();
        float test_num = test();
        print(test_num);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (intel > 0)
            {
                intel--;
            }
            Greet();
            print("get hit on the head");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (intel < 5)
            { 
            intel++;
        }
            Greet();
            print("read a book");
        }

    }
}