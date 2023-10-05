using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource bumpingSomething;
    public GameObject mainCam;
    public GameObject levelControl;
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<Swipe>().enabled = false;
        charModel.GetComponent<Animator>().Play("Falling Back Death");
        levelControl.GetComponent<DistanceRan>().enabled = false;
        bumpingSomething.Play();
        mainCam.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRunSequince>().enabled = true;
    }
}
