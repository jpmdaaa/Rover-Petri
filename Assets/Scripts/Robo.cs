﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robo : MonoBehaviour
{

    public PetriNet PetriRover;
    private Rigidbody2D RoverRigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        RoverRigidBody2D = GetComponent<Rigidbody2D>();
        PetriRover = new PetriNet();

        buildRobo();
    }

    public void buildRobo()
    {
        PetriRover.insertPlace(new Place("Rover"));  //0 eh o id do Lugar
        
        //açoes base
        PetriRover.insertPlace(new Place("Atacar"));
        PetriRover.insertPlace(new Place("Andar"));
       

        //variaveis
        PetriRover.insertPlace(new Place("Vida"));
        PetriRover.insertPlace(new Place("Combustivel"));
        PetriRover.insertPlace(new Place("Munição"));


        //condiçoes
       PetriRover.insertPlace(new Place("No alcance para atacar"));
       PetriRover.insertPlace(new Place("Deslocando"));
       PetriRover.insertPlace(new Place("Tomou um tiro"));
   

        //limpadores 
        PetriRover.insertPlace(new Place("Bateu"));
        PetriRover.insertPlace(new Place("Nao Bateu"));

   

        for (int i=0;i<100;i++)
        {
            PetriRover.getPlace(3).addToken(new Token(i)); //0 eh o id do Token

        }

        for(int i =0; i<24;i++)
        {
            PetriRover.insertTransition(new Transition(i)); //i eh o id da Transicao
        }


        //PetriRover.insertTransition(new Transition(0));


        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(0), true, false)); //de entrada, nao inibidor

         

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(PetriRover.getPlace(6).isEmpty())
        {
            Debug.Log("MORTO");
        }
        */
    }
}