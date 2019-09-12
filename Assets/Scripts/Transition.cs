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

        public Transition(int id)
        {
            connInList = new ArrayList();
            connOutList = new ArrayList();
            this.enabled = false;
            this.id = id;
            
        }
         public Boolean isEnabled()
        {
            return enabled;
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

