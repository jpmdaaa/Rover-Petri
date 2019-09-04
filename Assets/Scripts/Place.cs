using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Place
    {
        private string _iD;
        private Boolean empty;
        private ArrayList tokensList;
    
        public Place(string id)
        {
            this._iD = id;
            this.empty = true;
            tokensList = new ArrayList();
        }
        public void addToken(Token token)
        {
            tokensList.Add(token);
            empty = false;
        }
        public Boolean isEmpty()
        {
            return empty;
        }
        public string getId()
        {
            return _iD;
        }
    }

