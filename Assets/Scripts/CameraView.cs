using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    private Camera Camera;

    float sensitivity = 2f;
    [Range(0f, 90f)][SerializeField] float yRotationLimit = 88f;
    [Range(0f, 90f)][SerializeField] float HorizontalLimit = 0;
    Vector2 rotation = Vector2.zero;
    const string xAxis = "Mouse X"; //Strings in direct code generate garbage, storing and re-using them creates no garbage
    const string yAxis = "Mouse Y";

    private void Awake()
    {
        Camera = Camera.main;

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        rotation.x += Input.GetAxis(xAxis) * sensitivity;
        rotation.y += Input.GetAxis(yAxis) * sensitivity;


        rotation.y = Mathf.Clamp(rotation.y, -yRotationLimit, yRotationLimit);
        var xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
        var yQuat = Quaternion.AngleAxis(rotation.y, Vector3.left);

        transform.localRotation = xQuat * yQuat; //Quaternions seem to rotate more consistently than EulerAngles. Sensitivity seemed to change slightly at certain degrees using Euler. transform.localEulerAngles = new Vector3(-rotation.y, rotation.x, 0);
    }
}
