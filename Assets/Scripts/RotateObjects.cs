using UnityEngine;

public class RotateObjects : MonoBehaviour
{
    [SerializeField] private Transform objectToRotate;

    [SerializeField] private float rotationSpeed = 100f;

    [SerializeField] private bool clockwise = true;

    [SerializeField] public UI_Holamundo holaMundoScript;

    private bool isRotating = false;

    void Update()
    {
        if (isRotating)
        {
            float direction = clockwise ? 1f : -1f;
            objectToRotate.Rotate(Vector3.up * rotationSpeed * direction * Time.deltaTime, Space.Self);
            Debug.Log("Rotando" + objectToRotate.name);
        }
    }

    public void ToggleRotation()
    {
        isRotating = !isRotating;
        if (holaMundoScript != null)
        {
            if (isRotating)
            {
                holaMundoScript.ChangeTextHM("Rotando Objeto");
            }
            else
            {
                holaMundoScript.ChangeTextHM("Rotación detenida");
            }
        }
    }







}
