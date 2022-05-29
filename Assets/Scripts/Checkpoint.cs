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
    public CheckpointChangedEvent checkpointChangedEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag.Equals("Player"))
        {
            Debug.Log("test");
            checkpointChangedEvent?.Invoke(this.gameObject.transform.position);
        }
    }
}
