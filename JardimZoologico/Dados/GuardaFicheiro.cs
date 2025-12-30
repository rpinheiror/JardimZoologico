using System;
using System.Collections.Generic;
using System.Text;
using GestaoZoologico;
using System.IO; // Para operacoes de input e output
using System.Runtime.Serialization.Formatters.Binary; // Para poder utilizar ficheiros binarios

namespace Dados
{
    public class GuardaBinario
    {

        public static bool GuardarDados<T>(string caminho, List<T> lista)

        {       
            if (lista == null || lista.Count == 0) 
            {
                return false; 
            }
                using (FileStream fs = new FileStream(caminho, FileMode.Create))
                {
                #pragma warning disable SYSLIB0011
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, lista);
                #pragma warning restore SYSLIB0011
                }
                return true;
        }
    }
}
