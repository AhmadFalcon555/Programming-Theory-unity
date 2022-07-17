using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    //ENCAPSULATIOn
    Rigidbody animal;
    [SerializeField]protected float power = 200f;
    // Start is called before the first frame update
    void Start()
    {
        animal = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        //ABSTRACTION
        jump();
    }

    public virtual void jump()
    {
        animal.AddForce(new Vector3(0, 1, 1) * power);
        Debug.Log("animal has been clicked, it jump!");
    }

}
