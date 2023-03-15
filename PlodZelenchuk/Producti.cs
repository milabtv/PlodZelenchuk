using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlodZelenchuk
{
    public class Producti
    {
        
        private int id;
        private string name;
        private int quantity;
        Vid vid = new Vid();
        private string proizhod;

        public Producti(int id, string name, int quantity, Vid vid, string proizhod)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.vid = vid;
            this.proizhod = proizhod;
        }

        public int Id { get => id;}
        public string Name { get => name;}
        public int Quantity { get => quantity; }
        public Vid Vid { get => vid;}
        public string Proizhod { get => proizhod; }


    }
}
