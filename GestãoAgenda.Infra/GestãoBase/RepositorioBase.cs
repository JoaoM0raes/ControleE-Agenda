using GestãoDeAgendaDominio.GestãoBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoAgenda.Infra.GestãoBase
{
    public class RepositorioBase<T>where T : EntidadeBase 
    {
        public int numero;
        SerializadorJson<T> serializador;
        public List<T> lista;
        public RepositorioBase(SerializadorJson<T> serializador)
        {
          this.serializador = serializador;
          this.lista = serializador.carregarArquivo();
        }
        public List<T> CarregarTodos()
        {
            return lista;
        }
        public void Inserir(T entidade)
        {
            entidade.id = ++numero;
            lista.Add(entidade);
            serializador.pegarArquivo(lista);
        }
        public void Editar(T entidade,int numero)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if(lista[i].id == numero)
                {                    
                    lista[i] = entidade;
                    lista[i].id = numero; 
                    break;
                }
            }
            serializador.pegarArquivo(lista);
        }
        public void Excluir(T entidade)
        {
            lista.Remove(entidade);
            serializador.pegarArquivo(lista);
        }
    }
}
