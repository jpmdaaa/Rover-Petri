using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rover : MonoBehaviour
{

    public PetriNet PetriRover;
    private Rigidbody2D RoverRigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        RoverRigidBody2D = GetComponent<Rigidbody2D>();
        PetriRover = new PetriNet();

        buildRover();
    }

    public void buildRover()
    {
        for(int i=0; i<8;i++)
        {
            PetriRover.insertPlace(new Place("L"+ i));
        }

        PetriRover.insertTransition(new Transition(0)); 
        PetriRover.insertTransition(new Transition(1));

        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(0), true, false)); 
        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(1), true, false)); //de entrada, nao inibidor
        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(2), true, false)); //de entrada, nao inibidor
        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(5), false, false)); //de entrada, nao inibidor
        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(7), false, false)); //de entrada, nao inibidor
        PetriRover.getTransition(1).insertConnection(new Connection(PetriRover.getPlace(5), true, false)); //de entrada, nao inibidor
        PetriRover.getTransition(1).insertConnection(new Connection(PetriRover.getPlace(7), true, false)); //de entrada, nao inibidor
        PetriRover.getTransition(1).insertConnection(new Connection(PetriRover.getPlace(4), false, false)); //de entrada, nao inibidor
        PetriRover.getTransition(1).insertConnection(new Connection(PetriRover.getPlace(6), false, false)); //de entrada, nao inibidor

        PetriRover.execCycle();

        /*
        PetriRover.insertPlace(new Place("Rover"));  //0 eh o id do Lugar
        
        //açoes base
        PetriRover.insertPlace(new Place("Atacar"));
        PetriRover.insertPlace(new Place("Abastecer"));
        PetriRover.insertPlace(new Place("Recarregar"));
        PetriRover.insertPlace(new Place("Resgatar"));
        PetriRover.insertPlace(new Place("Deslocar"));
        PetriRover.insertPlace(new Place("Usar Escudo"));



        //variaveis
        PetriRover.insertPlace(new Place("Vida"));
        PetriRover.insertPlace(new Place("Combustivel"));
        PetriRover.insertPlace(new Place("Munição"));


        //condiçoes
       PetriRover.insertPlace(new Place("No alcance para atacar"));
       PetriRover.insertPlace(new Place("No quadrante combustivel"));
       PetriRover.insertPlace(new Place("Deslocando"));
       PetriRover.insertPlace(new Place("Escudo sendo utilizado"));
       PetriRover.insertPlace(new Place("Tomou um tiro"));
       PetriRover.insertPlace(new Place("Acabou o escudo"));


        //limpadores 



        /*
        PetriRover.insertPlace(new Place("Bateu"));
        PetriRover.insertPlace(new Place("Não Bateu"));

   

       



        for (int i=0;i<100;i++)
        {
            PetriRover.getPlace(6).addToken(new Token(i)); //0 eh o id do Token

        }

        for(int i =0; i<24;i++)
        {
            PetriRover.insertTransition(new Transition(i)); //i eh o id da Transicao
        }


        //PetriRover.insertTransition(new Transition(0));


        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(0), true, false)); //de entrada, nao inibidor

         */

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
