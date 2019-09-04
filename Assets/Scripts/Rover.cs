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

        PetriRover.insertPlace(new Place(0));  //0 eh o id do Lugar
        PetriRover.insertPlace(new Place(1));

        PetriRover.getPlace(0).addToken(new Token(0)); //0 eh o id do Token

        PetriRover.insertTransition(new Transition(0)); //0 eh o id da Transicao

        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(0), true, false)); //de entrada, nao inibidor
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
