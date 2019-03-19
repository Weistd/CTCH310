using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject bullet;
    public Transform BulletSpawn;
    public AudioClip pewpew;
    // Start is called before the first frame update
    private AudioSource source;
    private float volLowRange = 0.5f;
    private float volHighRange = 1f;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

    }

    void Fire()
    {
        //create the bullet from the prefeb
        var newBullet = (GameObject)Instantiate(
            bullet,
            BulletSpawn.position,
            BulletSpawn.rotation);
        //add velocity to
        newBullet.GetComponent<Rigidbody>().velocity = newBullet.transform.forward * 10;
        pew();
        Destroy(newBullet,2.0f);
        
    }

    void pew()
    {
        float vol = Random.Range(volLowRange, volHighRange);
        source.PlayOneShot(pewpew, vol);


    }

}
