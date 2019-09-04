﻿using System.Collections;
using UnityEngine;

public class LanderObjective : MonoBehaviour
{
    private bool canRetractLandingPad;

    private bool contactMade;

    private Rover playerLander;

    void Start()
    {
        playerLander = GameObject.Find("Lander").GetComponent<Rover>();
        if (playerLander == null)
        {
            Debug.LogError("Cannot find Lander gameobject. Make sure your Lander is named Lander.");
        }

        if ( playerLander != null)
        {
            //acessando RdP do Lander...

            //playerLander.geraExp();
            //.rocket.getPlace(0).addToken(new Token(2));
        }
    }

    public void ActivateLandingPad()
    {
        Debug.Log("Activated landing pad");

        if (canRetractLandingPad == false && contactMade == false)
        {
            StartCoroutine(RectractLandingPad());
        }
    }

    private IEnumerator RectractLandingPad()
    {
        canRetractLandingPad = true;
        contactMade = true;
        yield return new WaitForSeconds(0.5f);
        canRetractLandingPad = false;
        //playerLander.allowThrust = false;

       // GameObject.Find("Lander").GetComponent<Lander>().EnableRestartButton();
    }

    // Update is called once per frame
    void Update()
    {
        if (canRetractLandingPad)
        {
            var landingPadPositionY = transform.position.y - Time.deltaTime / 3;
            transform.position = new Vector2(transform.position.x, landingPadPositionY);
        }
    }
}