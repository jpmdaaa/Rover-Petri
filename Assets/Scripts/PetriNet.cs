﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class PetriNet
    {
        private ArrayList placeList;
        private ArrayList transitionList;
        private List<Transition> transitionL;
        public PetriNet()
        {
            placeList = new ArrayList();
            transitionList = new ArrayList();
          
        }

        public void execCycle()
        {

        //percorrer as transiçoes e verificar se estão habilitadas
        //percorrer as transições habilitadas jogando os tokens de um place para o outro
         Debug.Log(transitionL);

            //percorrendo a 1 vez a lista de transiçoes
            for(int i=0;i< transitionList.Count; i++)
            {

                //verificando quais estão habilitadas
                if (transitionL[i].enabled)
                {
                    
                }

            }


        

        }
        public void insertTransition(Transition transition)
        {
            transitionList.Add(transition);
            transitionL.Add(transition);
        }
        public void insertPlace(Place place)
        {
            placeList.Add(place);
        }
        public Transition getTransition(int pos)
        {
            return (Transition) transitionList[pos];
        }
        public Place getPlace(int pos)
        {
            return (Place) placeList[pos];
        }

    }

