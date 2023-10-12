using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody MyProjectile;
    public Transform MySpawn;
    public TextMeshProUGUI textMesh;
    private int disparos;
    


    private void Start()
    {

        disparos = 0;
        Debug.Log(disparos);
      


    }


    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetButtonDown("Fire1"))
        {
           
            disparos++;
            Instantiate(MyProjectile, MySpawn.position,MyProjectile.rotation);
            textMesh.text = disparos.ToString();
            Debug.Log(disparos);
           
        }
        
    }
    private void Shoot()
    {
        Rigidbody MyBullet;
        MyBullet = Instantiate(MyProjectile, MySpawn.position, MyProjectile.rotation);
        MyBullet.velocity = MySpawn.TransformDirection(Vector3.forward * 200);
        Destroy(MyBullet.gameObject,1);
        

    }
}
