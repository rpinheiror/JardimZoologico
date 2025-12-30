using System;
using System.Collections.Generic;
using System.Text;
using GestaoZoologico;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;


namespace Dados
{
    public class EscritorBinario
    {
        public static bool GuardarDados<T>(string caminho, List<T> Lista)
        {
            #pragma warning disable SYSLIB0011 
            using (FileStream fs = new FileStream(caminho, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, Lista);
                    return true;
                }
            #pragma warning restore SYSLIB0011

        }
    }
}