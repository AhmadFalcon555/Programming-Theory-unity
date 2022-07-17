using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public List<GameObject> animals;
    private float posx = 5f;
    private float posy = 4f;
    // Start is called before the first frame update


    public void SummonAnimal()
    {
        int index = Random.Range(0, animals.Count);
        Vector3 spawnPos = new Vector3(Random.Range(-posx, posx), posy);

        Instantiate(animals[index], spawnPos, Quaternion.identity);
    }

    public void Back2Menu()
    {
        SceneManager.LoadScene(0);
    }
}
