using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class UI : MonoBehaviour
{
    public Canvas canvas;

    private GameObject panel;
    public GameObject character;
    public GameObject followCam;
    public GameObject button;

    void Start()
    {
        panel = GameObject.Find("Panel");
    }

    private void Update()
    {
        
    }

    public void OnClick()
    {
        bool isActive = panel.activeSelf;

        // Text의 활성화 상태를 토글
        panel.gameObject.SetActive(!isActive);
        character.gameObject.SetActive(isActive);
        followCam.gameObject.SetActive(isActive);
        button.gameObject.SetActive(!isActive);
    }
}
