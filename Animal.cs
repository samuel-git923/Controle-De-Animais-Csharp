using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{

    public enum TipoAnimal {Cachorro, Gato, Peixe}

    public class Animal
    {
        public Animal ()
	    {
            this.Nome = "";
            this.Tipo = TipoAnimal.Peixe;
	    }

        public Animal (String nome, TipoAnimal tipo)
	    {
            this.Nome = nome;
            this.Tipo = tipo;
	    }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private TipoAnimal tipo;

        public TipoAnimal Tipo
        {   //valores definidos pelo proprietário - Cachorro, Gato, Peixe
            get { return tipo; }
            set { tipo = value }
        }


    }
}
