using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class InspectRaycast : MonoBehaviour
{
    [SerializeField] private int rayLength = 2;
    [SerializeField] private LayerMask layerMaskInteract;
    private ObjectController raycastedObj;

    [SerializeField] private Image crosshair;
    private bool isCrosshairActive;
    private bool doOnce;
    public bool isOpen, fridgeOpen;
    private bool canPlay = true;
    public PlayableDirector pourMilk;

    public GameObject door, fridgeDoor, milk, doorMilk, protagonistAnimator, canvas;
    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, layerMaskInteract.value))
        {
            if (hit.collider.CompareTag("InteractObject"))
            {
                if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<ObjectController>();
                    raycastedObj.ShowObjectName(); 
                    CrosshairChange(true);
                }

                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    raycastedObj.ShowExtraInfo();  
                }
            }

            if (hit.collider.CompareTag("Door"))
            {
                if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<ObjectController>();
                    raycastedObj.ShowObjectName();
                    CrosshairChange(true);
                }

                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    door.GetComponent<Animator>().enabled = true;
                    isOpen = true;
                }
            }

            if (hit.collider.CompareTag("FridgeDoor"))
            {
                if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<ObjectController>();
                    raycastedObj.ShowObjectName();
                    CrosshairChange(true);
                }

                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    fridgeDoor.GetComponent<Animator>().enabled = true;
                    fridgeOpen = true;
                }
            }

            if (hit.collider.CompareTag("Milk"))
            {
                if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<ObjectController>();
                    raycastedObj.ShowObjectName();
                    CrosshairChange(true);
                }

                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    milk.SetActive(false);
                    Debug.Log("Picked Up Milk");
                }
            }

            if (hit.collider.CompareTag("Winston"))
            {
                if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<ObjectController>();
                    raycastedObj.ShowObjectName();
                    CrosshairChange(true);
                }

                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (canPlay)
                    {
                        pourMilk.Play();
                        canPlay = false;
                        Debug.Log("Pouring Milk");
                    }

                    doorMilk.SetActive(true);
                    protagonistAnimator.GetComponent<Animator>().enabled = false;
                    canvas.SetActive(false);

                }
            }
        }
        else
        {
            if (isCrosshairActive)
            {
                raycastedObj.HideObjectName();
                CrosshairChange(false);
                doOnce = false;
            }
        }
    }

    void CrosshairChange(bool  on)
    {
        if (on && !doOnce)
        {
            crosshair.color = Color.red;
        }
        else
        {
            crosshair.color = Color.white;
            isCrosshairActive = false;
        }
        
    }

}
