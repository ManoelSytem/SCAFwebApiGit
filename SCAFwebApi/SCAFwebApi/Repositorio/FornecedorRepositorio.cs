using SCAFwebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCAFwebApi.Repositorio
{
    public class FornecedorRepositorio
    {
        private List<Fornecedor> fornecedor = new List<Fornecedor>();
        private int _nextId = 1;


        public FornecedorRepositorio()
        {
            Add(new Fornecedor
            {
                RazaoSocial = "Companhia de Eletricidade do Estado da Bahia Coelba",
                NomeFantasia = "Coelba",
                InscricaoEstadual = "",
                Cnpj = "15.139.629/0403-07",
                Endereco = "Rod Br 135 Km-18, S/N, Usina Alto Femeas, Br, Sao Desiderio, BA, CEP 47820-000, Brasil",
                Email = "torp@coelba.com.br",
                Telefone= "(77) 8119-935",
            });

        }

        public Fornecedor Add(Fornecedor empresa)
        {

            if (empresa == null)
            {
                throw new ArgumentNullException("empresa");
            }

            empresa.Id = _nextId++;
            fornecedor.Add(empresa);
            return empresa;

        }

        public Fornecedor Get(int id)
        {
            return fornecedor.Find(p => p.Id == id);
        }

        public IEnumerable<Fornecedor> GetAll()
        {
            return fornecedor;
        }

        public void Remove(int id)
        {
            fornecedor.RemoveAll(p => p.Id == id);
        }

        public bool Update(Fornecedor empresa)
        {
            if (empresa == null)
            {
                throw new ArgumentNullException("empresa");
            }
            int index = fornecedor.FindIndex(p => p.Id == empresa.Id);
            if (index == -1)
            {
                return false;

            }

            fornecedor.RemoveAt(index);

            fornecedor.Add(empresa);
            return true;
        }
    }

}
