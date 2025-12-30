using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;
using Dados;
using BO; // Usar Business Object para aceder aos dados dos Animais

namespace GestaoZoologico
{
    public class GestaoAnimais
    {
   

        #region Methods
        public static bool AdicionarAnimal(Animal a, List<Animal> ListaAnimais)
        {
            if (a == null) // Verifica se o animal nao é nulo
                return false;

            if (ListaAnimais.Any(animal => animal.IddoAnimal == a.IddoAnimal))  // Verifica se o animal já existe na lista
                return false;

            else
                ListaAnimais.Add(a); // Adiciona o animal à lista
            return true;
        }
        public static bool RemoverAnimal(int idanimal, List<Animal> ListaAnimais)
        {
            Animal a = ListaAnimais.Find(animal => animal.IddoAnimal == idanimal);

            if (a != null)
            {
                ListaAnimais.Remove(a);
                return true;
            }
            return false;
        }
        #endregion

    }
}