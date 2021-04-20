using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentShift : MonoBehaviour
{
    Renderer renderer;

    public GameObject otherModel, currentModel;
    public InspectRaycast inspectRay;
    bool previousFrame, currentFrame;


    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (renderer.isVisible && inspectRay.isOpen == true || renderer.isVisible && inspectRay.fridgeOpen == true)
        {
            Debug.Log("Object is visible");
            currentFrame = true;
        }
        else
        {
            Debug.Log("Object is no longer visible");
            currentFrame = false;
            OnBecameInvisible();

        }

        previousFrame = currentFrame;
    }

    void OnBecameInvisible()
    {
        if (currentFrame == false && previousFrame == true)
        {
            currentModel.SetActive(false);
            otherModel.SetActive(true);
        }
        //enabled = false;
    }
}
