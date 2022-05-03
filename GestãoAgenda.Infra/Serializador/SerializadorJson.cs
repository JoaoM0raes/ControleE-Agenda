using GestãoDeAgendaDominio.GestãoBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestãoAgenda.Infra
{
    public class SerializadorJson<T> where T : EntidadeBase
    {
        private string caminho;
        public SerializadorJson(string caminho)
        {
            if(caminho == "Tarefa")
            {
                this.caminho = @"C:\tarefa.json";
            }
            else if(caminho == "Contato")
            {
                this.caminho = @"C:\contatos.json";
            }
            else if( caminho == "Compromisso")
            {
                this.caminho = @"C:\compromisso.json";
            }
        }

        public List<T> carregarArquivo()
        {
            if (File.Exists(caminho) == false)
            {
                return new List<T>();
            }
            string json = File.ReadAllText(caminho);
            return  JsonConvert.DeserializeObject<List<T>>(json);
        }
        public void pegarArquivo(List<T> ListaBase)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string tarefasJson = JsonConvert.SerializeObject(ListaBase, settings);

            File.WriteAllText(caminho, tarefasJson);
         
        }
    }
}
