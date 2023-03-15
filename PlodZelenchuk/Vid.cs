using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlodZelenchuk
{
    public class Vid
    {
        private int id;
        private string name;

        public Vid(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Vid()
        {
            this.id = 0;
            this.name = "";
        }
        public int Id { get => id; }
        public string Name { get => name; }


    }
}
