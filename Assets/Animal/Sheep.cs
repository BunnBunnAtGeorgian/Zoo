using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        GetAnimalComponents();
        StartCoroutine(MakeSoundOnRepeat()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}