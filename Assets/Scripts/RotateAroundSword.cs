using UnityEngine;

public class RotateAroundSword : MonoBehaviour
{
    //Assign a GameObject in the Inspector to rotate around
    public GameObject target;
    public float speed = 20;
    public Vector3 axis = Vector3.up;

    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(target.transform.position, axis, speed * Time.deltaTime);
    }
}
