using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Dados
{
    public static class LeFicheiro
    {
        // O <T> permite que este método funcione com qualquer tipo de Lista
        public static List<T> LerBinario<T>(string nomeFicheiro)
        {
            if (!File.Exists(nomeFicheiro)) return new List<T>();

            using (FileStream fs = new FileStream(nomeFicheiro, FileMode.Open))
            {
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                return (List<T>)bf.Deserialize(fs);
                #pragma warning restore SYSLIB0011
            }
        }
    }
}

