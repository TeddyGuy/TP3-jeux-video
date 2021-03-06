using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RespawnController : MonoBehaviour
{
    public Vector3 lastCheckpoint = new Vector3(0,5,0);
    public CharacterController controller;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        lastCheckpoint = new Vector3(0, 5, 0);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag.Equals("Player"))
        {
            Debug.Log("test respawn");
            audioSource.Play();
            controller.enabled = false;
            other.gameObject.transform.position = new Vector3(lastCheckpoint.x, lastCheckpoint.y + 5, lastCheckpoint.z);
            controller.enabled = true;
        }
    }

    public void changeCheckpoint(Vector3 position)
    {
        lastCheckpoint = position;
    }

    public void Reset()
    {
        lastCheckpoint = new Vector3(0, 5, 0);
    }
}
