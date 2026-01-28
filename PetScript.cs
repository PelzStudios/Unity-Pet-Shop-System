using UnityEngine;

public class PetScript : MonoBehaviour
{
    public bool isHungry = true;

    public void Eat()
    {
        isHungry = false;
        GetComponent<Renderer>().material.color = Color.green;
        Debug.Log("Nom Nom Nom!");
    }
}


