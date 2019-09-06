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

        PetriRover.insertPlace(new Place("Rover"));  //0 eh o id do Lugar
        //açoes base
        PetriRover.insertPlace(new Place("Atacar"));
        PetriRover.insertPlace(new Place("Abastecer"));
        PetriRover.insertPlace(new Place("Recarregar"));
        PetriRover.insertPlace(new Place("Resgatar"));


        //variaveis
        PetriRover.insertPlace(new Place("Vida"));
        PetriRover.insertPlace(new Place("Combustivel"));

        //condiçoes
        PetriRover.insertPlace(new Place("Deslocar"));
        PetriRover.insertPlace(new Place("Deslocar"));
        PetriRover.insertPlace(new Place("Deslocar"));





        for(int i=0;i<100;i++)
        {
            PetriRover.getPlace(6).addToken(new Token(i)); //0 eh o id do Token

        }

        PetriRover.insertTransition(new Transition(0)); //0 eh o id da Transicao

        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(0), true, false)); //de entrada, nao inibidor
    }

    // Update is called once per frame
    void Update()
    {
        if(PetriRover.getPlace(6).isEmpty())
        {
            Debug.Log("MORTO");
        }

    }
}
