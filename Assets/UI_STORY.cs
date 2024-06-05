using System.Collections;
using UnityEngine;

public class UI_STORY : MonoBehaviour
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
            if (image != null && !image.activeSelf)
            {
                StartCoroutine(ShowAndHideUI());
            }
        }
    }

    private IEnumerator ShowAndHideUI()
    {
        image.SetActive(true); // Show the image

        // Wait for 5 seconds
        yield return new WaitForSeconds(5f);

        // Destroy the image GameObject
        Destroy(image);

        // Optionally, if you want to log or take some other action after destroying the image
        Debug.Log("Image destroyed");
    }
}
