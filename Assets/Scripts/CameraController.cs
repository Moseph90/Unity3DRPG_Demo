using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Rendering;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float mouseSensitivity = 100.0f;
    [SerializeField]
    private Vector3 offset;

    private float xRotation = 0.0f;
    private float yRotation = 0.0f;

    void Start() {}

    void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Adjust the y rotation based on the mouse X input
        yRotation += mouseX;

        // Adjust the x rotation based on the mouse Y input, and clamp it to prevent flipping
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);

        // Calculate the new camera rotation
        Quaternion cameraRotation = Quaternion.Euler(xRotation, yRotation, 0.0f);

        // Apply the rotation to the camera
        transform.rotation = cameraRotation;

        // Maintain the offset distance from the player
        Vector3 desiredPosition = player.transform.position - transform.forward * offset.z + transform.up * offset.y;
        transform.position = desiredPosition;
    }
}
