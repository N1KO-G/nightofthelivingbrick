using UnityEngine;

public class mousedissapear : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }
}
