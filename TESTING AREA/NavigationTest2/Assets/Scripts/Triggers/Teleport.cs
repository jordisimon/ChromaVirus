﻿using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    public Transform teleportDestination;

	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player1" || other.tag == "Player2")
        {
            other.transform.position = teleportDestination.position;
        }
    }
}
