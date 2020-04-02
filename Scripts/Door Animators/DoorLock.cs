using System.Collections;
using UnityEngine;

public class DoorLock : MonoBehaviour { 

    Animator animator;
    bool doorOpen;
    private AudioSource mAudioSrc1;
    

    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
        mAudioSrc1 = GetComponent<AudioSource>();
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            doorOpen = true;
            DoorControl("Open");
            mAudioSrc1.Play();
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(doorOpen)
        {
            doorOpen = false;
            DoorControl("Close");
            mAudioSrc1.Play();
        }
    }

    void DoorControl(string direction)
    {
        animator.SetTrigger(direction);

    }

}
