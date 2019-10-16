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
        PetriRover.insertPlace(new Place(18)); //Escudo sendo utilizado
        PetriRover.insertPlace(new Place(19)); //Indicação de escudo na interface
        PetriRover.insertPlace(new Place(20)); //Acabou escudo
        PetriRover.insertPlace(new Place(21)); //Abastecer
        PetriRover.insertPlace(new Place(22)); //No quadrante do combustivel
        PetriRover.insertPlace(new Place(23)); //RESET COMBUSTIVEL
        PetriRover.insertPlace(new Place(24)); //RECARREGAR
        PetriRover.insertPlace(new Place(25)); //No quadrante da munição
        PetriRover.insertPlace(new Place(26)); //RESET MUNIÇÃO
        PetriRover.insertPlace(new Place(27)); //ATIROU
        PetriRover.insertPlace(new Place(28)); //resgatar
        PetriRover.insertPlace(new Place(29)); //No quadrante da munição
        PetriRover.insertPlace(new Place(30)); //Resgatou
        PetriRover.insertPlace(new Place(31)); //SOLDADOS RESGATADOS
        PetriRover.insertPlace(new Place(32)); //DERROTA/MORTO
        PetriRover.insertPlace(new Place(33)); //No quadrante do portal
        PetriRover.insertPlace(new Place(34)); //PROXIMA FAZE
        PetriRover.insertPlace(new Place(35)); //TOMOU TIRO SEM ESCUDO
        PetriRover.insertPlace(new Place(36)); //RESET VIDA
        PetriRover.insertPlace(new Place(37)); //DEFENDER


        for (int i = 0; i < 99; i++)
        {
            PetriRover.getPlace(5).addToken(new Token(i));

        }

        for (int i = 0; i < 50; i++)
        {
            PetriRover.getPlace(4).addToken(new Token(i));

        }

        for (int i = 0; i < 30; i++)
        {
            PetriRover.getPlace(6).addToken(new Token(i));

        }



        for (int i = 0; i < 21; i++)
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
        PetriRover.getTransition(3).insertConnection(new Connection(PetriRover.getPlace(5), true, false));
        PetriRover.getTransition(4).insertConnection(new Connection(PetriRover.getPlace(0), true, false));
        PetriRover.getTransition(4).insertConnection(new Connection(PetriRover.getPlace(1), true, false));
        PetriRover.getTransition(4).insertConnection(new Connection(PetriRover.getPlace(7), false, false));
        PetriRover.getTransition(5).insertConnection(new Connection(PetriRover.getPlace(7), true, false));
        PetriRover.getTransition(5).insertConnection(new Connection(PetriRover.getPlace(1), false, false));
        PetriRover.getTransition(6).insertConnection(new Connection(PetriRover.getPlace(1), true, false));
        PetriRover.getTransition(6).insertConnection(new Connection(PetriRover.getPlace(15), false, true));
        PetriRover.getTransition(7).insertConnection(new Connection(PetriRover.getPlace(37), true, false));
        PetriRover.getTransition(7).insertConnection(new Connection(PetriRover.getPlace(16), false, false));
        PetriRover.getTransition(7).insertConnection(new Connection(PetriRover.getPlace(5), true, false));
        PetriRover.getTransition(8).insertConnection(new Connection(PetriRover.getPlace(16), true, false));
        PetriRover.getTransition(8).insertConnection(new Connection(PetriRover.getPlace(17), true, false));
        PetriRover.getTransition(8).insertConnection(new Connection(PetriRover.getPlace(20), true, false));
        PetriRover.getTransition(9).insertConnection(new Connection(PetriRover.getPlace(16), true, false));
        PetriRover.getTransition(9).insertConnection(new Connection(PetriRover.getPlace(18), false, false));
        PetriRover.getTransition(10).insertConnection(new Connection(PetriRover.getPlace(18), true, false));
        PetriRover.getTransition(10).insertConnection(new Connection(PetriRover.getPlace(9), false, false));
        PetriRover.getTransition(10).insertConnection(new Connection(PetriRover.getPlace(19), false, false));
        PetriRover.getTransition(11).insertConnection(new Connection(PetriRover.getPlace(19), true, false));
        PetriRover.getTransition(11).insertConnection(new Connection(PetriRover.getPlace(20), false, false));
        PetriRover.getTransition(12).insertConnection(new Connection(PetriRover.getPlace(0), true, false));
        PetriRover.getTransition(12).insertConnection(new Connection(PetriRover.getPlace(21), true, false));
        PetriRover.getTransition(12).insertConnection(new Connection(PetriRover.getPlace(22), true, false));
        PetriRover.getTransition(12).insertConnection(new Connection(PetriRover.getPlace(5), true, false));
        PetriRover.getTransition(12).insertConnection(new Connection(PetriRover.getPlace(23), false, false));
        PetriRover.getTransition(13).insertConnection(new Connection(PetriRover.getPlace(23), true, false));
        PetriRover.getTransition(13).insertConnection(new Connection(PetriRover.getPlace(5), false, false));
        PetriRover.getTransition(14).insertConnection(new Connection(PetriRover.getPlace(0), true, false));
        PetriRover.getTransition(14).insertConnection(new Connection(PetriRover.getPlace(24), true, false));
        PetriRover.getTransition(14).insertConnection(new Connection(PetriRover.getPlace(25), true, false));
        PetriRover.getTransition(14).insertConnection(new Connection(PetriRover.getPlace(6), true, false));
        PetriRover.getTransition(14).insertConnection(new Connection(PetriRover.getPlace(26), false, false));
        PetriRover.getTransition(15).insertConnection(new Connection(PetriRover.getPlace(26), true, false));
        PetriRover.getTransition(15).insertConnection(new Connection(PetriRover.getPlace(6), false, false));
        PetriRover.getTransition(16).insertConnection(new Connection(PetriRover.getPlace(6), true, false));
        PetriRover.getTransition(16).insertConnection(new Connection(PetriRover.getPlace(27), false, false));
        PetriRover.getTransition(17).insertConnection(new Connection(PetriRover.getPlace(0), true, false));
        PetriRover.getTransition(17).insertConnection(new Connection(PetriRover.getPlace(5), true, false));
        PetriRover.getTransition(17).insertConnection(new Connection(PetriRover.getPlace(28), true, false));
        PetriRover.getTransition(17).insertConnection(new Connection(PetriRover.getPlace(29), true, false));
        PetriRover.getTransition(17).insertConnection(new Connection(PetriRover.getPlace(30), false, false));
        PetriRover.getTransition(18).insertConnection(new Connection(PetriRover.getPlace(30), true, false));
        PetriRover.getTransition(18).insertConnection(new Connection(PetriRover.getPlace(31), false, false));
        PetriRover.getTransition(19).insertConnection(new Connection(PetriRover.getPlace(31), true, true));
        PetriRover.getTransition(19).insertConnection(new Connection(PetriRover.getPlace(32), false, false));
        PetriRover.getTransition(20).insertConnection(new Connection(PetriRover.getPlace(31), true, false));
        PetriRover.getTransition(20).insertConnection(new Connection(PetriRover.getPlace(32), true, false));
        PetriRover.getTransition(20).insertConnection(new Connection(PetriRover.getPlace(33), true, false));
        PetriRover.getTransition(21).insertConnection(new Connection(PetriRover.getPlace(4), true, true));
        PetriRover.getTransition(22).insertConnection(new Connection(PetriRover.getPlace(4), true, false));
        PetriRover.getTransition(22).insertConnection(new Connection(PetriRover.getPlace(35), true, false));
        PetriRover.getTransition(22).insertConnection(new Connection(PetriRover.getPlace(36), false, false));


        
        
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
