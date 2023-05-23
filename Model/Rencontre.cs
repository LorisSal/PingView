﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rencontre
    {
        private string _equipeDom;

        public string EquipeDom
        {
            get { return _equipeDom; }
            set { _equipeDom = value; }
        }

        private string _equipeExt;

        public string EquipeExt
        {
            get { return _equipeExt; }
            set { _equipeExt = value; }
        }


        private string _score;

        public string Score
        {
            get { return _score; }
            set { _score = value; }
        }


        private DetailsRencontre _details;

        public DetailsRencontre Details
        {
            get { return _details; }
            set { _details = value; }
        }

        public Rencontre()
        {
            EquipeDom = "Pas d'equipe";
            EquipeExt = "Pas d'equipe";
            Score = "Pas de score";
            Details = new DetailsRencontre();
        }

        public Rencontre(string equipeDom, string equipeExt, string s, DetailsRencontre d)
        {
            EquipeDom = equipeDom;
            EquipeExt = equipeExt;
            Score = s;
            Details = d;
        }

        public override string ToString()
        {
            return EquipeDom + "  " + Score + "  " + EquipeExt;
        }
    }
}