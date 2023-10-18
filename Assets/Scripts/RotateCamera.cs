using UnityEngine;

public class RotateCamera : MonoBehaviour {
    [SerializeField] private float rotationSpeed;

    private void Update() {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}