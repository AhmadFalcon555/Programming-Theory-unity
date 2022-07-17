using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Dog : Animal
{
    Rigidbody dog;
    private void Start()
    {
        dog = GetComponent<Rigidbody>();
    }
    //POLYMORPHISM
    public override void jump()
    {
        dog.AddForce(Vector3.forward * power * 5);
        Debug.Log("dog is moving forward");
    }
}
