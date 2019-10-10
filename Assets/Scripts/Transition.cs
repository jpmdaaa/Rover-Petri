using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Transition
    {
        private int id;
        public bool enabled;
        public ArrayList connInList;
        public ArrayList connOutList;
        public List<Place> placeIn;
        public List<Place> placeOut;
        public List<Connection> connectionIn;
        public List<Connection> connectionOut;

    public Transition(int id)
        {
            connInList = new ArrayList();
            connOutList = new ArrayList();
            this.enabled = false;
            this.id = id;
            
        }
    public Boolean isEnabled()
    {
      
        for (int x = 0; x < placeIn.Count; x++)
        {
            //qual é o peso?
            if (placeIn[x].isEmpty() && placeIn[x].GetToken() < connectionIn[x].peso)
            {
                return enabled = false;
            }
            else if(placeIn[x].isEmpty()==false && placeIn[x].GetToken() >= connectionIn[x].peso)
            {
                return enabled= true;
            }

        }

        return enabled;
    }

        public void Trigger()
        {
            for(int x=0; x<placeIn.Count; x++)
           {
                for(int y=0; y<connectionIn[x].peso; y++)
                {
               
                    placeIn[y].removeToken(new Token());
                    
                }
             
           }

            for(int x=0; x<placeOut.Count; x++)
         {
            for(int y=0; y<connectionOut[x].peso; y++)
            {
                
                placeIn[y].addToken(new Token());
            }
         }

        }
        public void insertConnection(Connection conn)
        {
            if (conn.isEntryArc())
            {
                connInList.Add(conn);
            } else
            {
                connOutList.Add(conn);
            }
        
            
        }
        public int getId()
        {
            return id;
        }
     


    }

