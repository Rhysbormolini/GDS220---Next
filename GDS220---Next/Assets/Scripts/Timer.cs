using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer;
    public GameObject trigger;
    public AudioSource knock;
    
    IEnumerator StartTimer()
    {
        timer = 60f;

        while (timer > 0)
        {
            timer -= Time.deltaTime;
            yield return null;
        }

        if (timer <= 0)
        {
            knock.Play();
            trigger.GetComponent<Collider>().enabled = false;
            yield return new WaitForSeconds(10);
            knock.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(StartTimer());
        }
    }
}
