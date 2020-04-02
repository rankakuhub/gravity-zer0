using System.Collections;
using UnityEngine;

public class Doors2 : MonoBehaviour {

    Animator animator;
    bool DoorsOpen;
    private AudioSource mAudioSrc1;

    void Start()
    {
        DoorsOpen = false;
        animator = GetComponent<Animator>();
        mAudioSrc1 = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            DoorsOpen = true;
            DoorControl("Open");
            mAudioSrc1.Play();
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (DoorsOpen)
        {
            DoorsOpen = false;
            DoorControl("Close");
            mAudioSrc1.Play();
        }
    }

    void DoorControl(string direction)
    {
        animator.SetTrigger(direction);

    }

}
