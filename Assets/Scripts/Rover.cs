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
        PetriRover.insertPlace(new Place(0));  //Rover


        PetriRover.insertPlace(new Place(1)); //atacar
        PetriRover.insertPlace(new Place(2)); //andar
        PetriRover.insertPlace(new Place(3)); //Deslocar
        PetriRover.insertPlace(new Place(4)); //vida
        PetriRover.insertPlace(new Place(5)); //Combustivel
        PetriRover.insertPlace(new Place(6)); //Munição
        PetriRover.insertPlace(new Place(7)); //No alcance para atacar
        PetriRover.insertPlace(new Place(8)); //Deslocando
        PetriRover.insertPlace(new Place(9)); //Tomou um tiro
        PetriRover.insertPlace(new Place(10)); //Bateu
        PetriRover.insertPlace(new Place(11)); //Nao Bateu
        PetriRover.insertPlace(new Place(12)); //Parede
        PetriRover.insertPlace(new Place(13)); //Não bateu
        PetriRover.insertPlace(new Place(14)); //LUGAR VAZIO 1
        PetriRover.insertPlace(new Place(15)); //LUGAR VAZIO 2
        PetriRover.insertPlace(new Place(16)); // UTILIZAR ESCUDO
        PetriRover.insertPlace(new Place(17)); //LUGAR VAZIO 3
        PetriRover.insertPlace(new Place(17)); //Escudo sendo utilizado


        for (int i = 0; i < 100; i++)
        {
            PetriRover.getPlace(5).addToken(new Token(i));

        }


        for (int i = 0; i < 22; i++)
        {
            PetriRover.insertTransition(new Transition(i)); //i eh o id da Transicao
        }


        //PetriRover.insertTransition(new Transition(0));

        //conexões
        // transição(lugar, entrada, inibidor)
        //numero da transição -1 comparado a imagem da rede

        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(0), true, false));
        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(3), true, false));
        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(5), true, false));
        PetriRover.getTransition(0).insertConnection(new Connection(PetriRover.getPlace(8), false, false));
        PetriRover.getTransition(1).insertConnection(new Connection(PetriRover.getPlace(8), true, false));
        PetriRover.getTransition(1).insertConnection(new Connection(PetriRover.getPlace(13), false, true));
        PetriRover.getTransition(2).insertConnection(new Connection(PetriRover.getPlace(8), true, false));
        PetriRover.getTransition(2).insertConnection(new Connection(PetriRover.getPlace(12), true, false));
        PetriRover.getTransition(2).insertConnection(new Connection(PetriRover.getPlace(10), false, false));
        PetriRover.getTransition(3).insertConnection(new Connection(PetriRover.getPlace(10), true, false));
        PetriRover.getTransition(3).insertConnection(new Connection(PetriRover.getPlace(14), false, false));
        PetriRover.getTransition(4).insertConnection(new Connection(PetriRover.getPlace(0), true, false));
        PetriRover.getTransition(4).insertConnection(new Connection(PetriRover.getPlace(1), true, false));
        PetriRover.getTransition(4).insertConnection(new Connection(PetriRover.getPlace(7), false, false));
        PetriRover.getTransition(5).insertConnection(new Connection(PetriRover.getPlace(7), true, false));
        PetriRover.getTransition(5).insertConnection(new Connection(PetriRover.getPlace(1), false, false));
        PetriRover.getTransition(6).insertConnection(new Connection(PetriRover.getPlace(1), true, false));
        PetriRover.getTransition(6).insertConnection(new Connection(PetriRover.getPlace(15), false, true));
        PetriRover.getTransition(7).insertConnection(new Connection(PetriRover.getPlace(7), true, false));
        PetriRover.getTransition(7).insertConnection(new Connection(PetriRover.getPlace(16), false, false));
        PetriRover.getTransition(8).insertConnection(new Connection(PetriRover.getPlace(16), true, false));
        PetriRover.getTransition(8).insertConnection(new Connection(PetriRover.getPlace(17), true, false));
        PetriRover.getTransition(9).insertConnection(new Connection(PetriRover.getPlace(16), true, false));
        PetriRover.getTransition(9).insertConnection(new Connection(PetriRover.getPlace(16), false, false));


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
