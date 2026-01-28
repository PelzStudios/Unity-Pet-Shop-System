using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public void Feed()
    {
       GameObject[] pets =  GameObject.FindGameObjectsWithTag("Dog");

       foreach(GameObject pet in pets)
       {
        PetScript petScript = pet.GetComponent<PetScript>();
        petScript.Eat();
       }
    }
    
}