using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_dz
{
    partial class Pie
    {
        string fittings; //nachinka
        int mass;        //ves
        Preparation preparation;
        string nameCook; //povar
        DateTime dateCreate;//data pregotovlenie
        static int count;
        static DateTime freshest;

        static  Pie()
        {
            count = 0;
            freshest = DateTime.Now;
        }

        public Pie()
        {
            count++;

            dateCreate = DateTime.Now;

            freshest= DateTime.Now;

        }

        public Pie(DateTime dt)
        {
            dateCreate = dt;
        }

        public Pie(string name)
        {
            nameCook = name;
        }

        public int GetCount()
        {
            return count;
        }

        public DateTime GetDateTime()
        {
            return freshest;
        }

        public void SetFittings(string str)
        {
            fittings = str;
        }

        public string GetFittings()
        {
            return fittings;
        }

        public void SetMass(int mass)
        {
            this.mass = mass;
        }

        public int GetMass()
        {
            return mass;
        }

        public void SetPreparation(int preparation)
        {
            this.preparation = (Preparation)preparation;
        }

        public Preparation GetPreparation()
        {
            return preparation;
        }

        public void SetCook(string str)
        {
            nameCook = str;
        }

        public string GetCook()
        {
            return nameCook;
        }

        public void SetDate(DateTime dt)
        {
            dateCreate = dt;
        }
       
    }    

}
