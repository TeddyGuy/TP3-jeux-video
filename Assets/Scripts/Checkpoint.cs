using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class CheckpointChangedEvent : UnityEvent<Vector3>
{

}

public class Checkpoint : MonoBehaviour
{
    public RespawnController respawnController;
    public AudioSource audioSource;
    public CheckpointChangedEvent checkpointChangedEvent;
    private bool firstTime = true;

    // Start is called before the first frame update
    void Start()
    {
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
            if (firstTime)
            {
                audioSource.Play();
                firstTime = false;
            }
            checkpointChangedEvent?.Invoke(this.gameObject.transform.position);
        }
    }
}
