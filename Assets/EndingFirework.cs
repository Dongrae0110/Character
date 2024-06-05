using System.Collections;
using UnityEngine;

public class EndingFirework : MonoBehaviour
{
    public GameObject target;
    public GameObject a;
    public GameObject npc;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target) // Check if the colliding object is the player
        {
            a.SetActive(true);
            npc.SetActive(true);
            
        }
    }

}
