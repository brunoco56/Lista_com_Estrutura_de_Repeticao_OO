using System;
using System.Collections.Generic;
using System.Text;

namespace Arduino
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public int idade { get; set; }
        public string nome { get; set; }

        public string andar { get; set; }

        public string andar1(int idade)
        {
            if (idade > 5)
            {
                this.andar = "Anda demais da conta ";
            }
            else
            {
                this.andar = "Anda não é muito pequena ";
            }
            return andar;
        }

    }
}
