using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    Rigidbody cat;
    // Start is called before the first frame update
    void Start()
    {
        cat = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void jump()
    {
        cat.AddForce(new Vector3(0, 1, 1) * power);
        Debug.Log("Cat is Jumping");
    }
}
