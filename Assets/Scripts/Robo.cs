using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robo : MonoBehaviour
{

    public PetriNet PetriRobo;
    private Rigidbody2D RoverRigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        RoverRigidBody2D = GetComponent<Rigidbody2D>();
        PetriRobo = new PetriNet();

        buildRobo();
    }

    public void buildRobo()
    {
        //lugares
        PetriRobo.insertPlace(new Place(0)); //Rover
        PetriRobo.insertPlace(new Place(1)); //Vida
        PetriRobo.insertPlace(new Place(2)); //Robô
        PetriRobo.insertPlace(new Place(3)); //Quadrante pra atacar
        PetriRobo.insertPlace(new Place(4)); //Atacou
        PetriRobo.insertPlace(new Place(5)); //LIXEIRA ATAQUE
        PetriRobo.insertPlace(new Place(6)); //Tomou Dano
        PetriRobo.insertPlace(new Place(7)); //Andando
        PetriRobo.insertPlace(new Place(8)); //Morreu

        //transiçoes
        for (int i = 0; i < 6; i++)
        {
            PetriRobo.insertTransition(new Transition(i)); //i eh o id da Transicao
        }

        //conexões
        // transição(lugar, entrada, inibidor)
        //numero da transição -1 comparado a imagem da rede
        //                    transição                                       lugar     entrada?
        PetriRobo.getTransition(0).insertConnection(new Connection(PetriRobo.getPlace(0), true, false));
        PetriRobo.getTransition(0).insertConnection(new Connection(PetriRobo.getPlace(1), false, false));
        PetriRobo.getTransition(1).insertConnection(new Connection(PetriRobo.getPlace(2), true, false));
        PetriRobo.getTransition(1).insertConnection(new Connection(PetriRobo.getPlace(1), false, false));
        PetriRobo.getTransition(2).insertConnection(new Connection(PetriRobo.getPlace(2), true, false));
        PetriRobo.getTransition(2).insertConnection(new Connection(PetriRobo.getPlace(4), false, false));
        PetriRobo.getTransition(3).insertConnection(new Connection(PetriRobo.getPlace(3), true, false));
        PetriRobo.getTransition(3).insertConnection(new Connection(PetriRobo.getPlace(4), false, false));
        PetriRobo.getTransition(5).insertConnection(new Connection(PetriRobo.getPlace(4), true, false));
        PetriRobo.getTransition(5).insertConnection(new Connection(PetriRobo.getPlace(5), false, false));
        PetriRobo.getTransition(4).insertConnection(new Connection(PetriRobo.getPlace(1), true, false));
        PetriRobo.getTransition(4).insertConnection(new Connection(PetriRobo.getPlace(6), false, false));
        PetriRobo.getTransition(6).insertConnection(new Connection(PetriRobo.getPlace(6), true, false));
        PetriRobo.getTransition(6).insertConnection(new Connection(PetriRobo.getPlace(7), true, false));
        PetriRobo.getTransition(6).insertConnection(new Connection(PetriRobo.getPlace(8), false, false));


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