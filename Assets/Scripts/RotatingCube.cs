using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log(message: "Hello World!");
    }
    
    void FixedUpdate()
    {
        transform.Rotate(xAngle:0, yAngle:90f*Time.fixedDeltaTime, zAngle:0);
        Debug.Log(message: "Next Step.");
    }
}