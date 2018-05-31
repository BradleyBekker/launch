﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P2rocket : MonoBehaviour {
    public bool part1 = false;
    public bool part2 = false;
    public bool part3 = false;
    public bool part4 = false;
    public bool part5 = false;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (part1 && part2 && part3 && collision.gameObject.tag == "player2")
        {
            print("p2 win");
            SceneManager.LoadScene(3);
        }
    }
}
