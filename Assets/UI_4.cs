using System.Collections;
using UnityEngine;

public class UI_4 : MonoBehaviour
{
    public Canvas canvas1;
    public GameObject image;
    public GameObject text;
    public GameObject target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == target) // Check if the colliding object is the player
        {
            Debug.Log("Entered");
            if (!image.activeSelf)
            {
                StartCoroutine(ShowAndHideUI());
            }
        }
    }

    private IEnumerator ShowAndHideUI()
    {
        image.SetActive(true); // Show the image

        // Wait for 3 seconds
        yield return new WaitForSeconds(3f);

        image.SetActive(false); // Hide the image
    }
}
