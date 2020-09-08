using System;

namespace Consoledesafio02aula07
{
    public class FOrnecedoresBLL
    {
        static public Fornecedor CriarFornecedor(string NomeFantasia, string CNPJ, string Endereço, string Cidade, string CEP, DateTime Criacao, DateTime UltimaAlteracao, DateTime Exclusao)
        {
            if(String.IsNullOrEmpty(NomeFantasia) || string.IsNullOrWhiteSpace(NomeFantasia))
            {
                throw new Exception("Você deve informar o nome fantasia para fazer a inserção do registro.");
            }
            if (String.IsNullOrEmpty(CNPJ) || string.IsNullOrWhiteSpace(CNPJ))
            {
                throw new Exception("Você deve informar o CNPJ para fazer a inserção do registro.");
            }
            if (String.IsNullOrEmpty(Endereço) || string.IsNullOrWhiteSpace(Endereço))
            {
                throw new Exception("Você deve informar o Endereço para fazer a inserção do registro.");
            }
            if (String.IsNullOrEmpty(Cidade) || string.IsNullOrWhiteSpace(Cidade))
            {
                throw new Exception("Você deve informar a Cidade para fazer a inserção do registro.");
            }
            if (String.IsNullOrEmpty(CEP) || string.IsNullOrWhiteSpace(CEP))
            {
                throw new Exception("Você deve informar o CEP para fazer a inserção do registro.");
            }
            FOrnecedoresDAL FornecedoresDS = new FOrnecedoresDAL();
                
                Fornecedor novoFornecedor = new Fornecedor();
                novoFornecedor.NomeFantasia = NomeFantasia;
                novoFornecedor.CNPJ = CNPJ;
                novoFornecedor.Endereço = Endereço;
                novoFornecedor.Cidade = Cidade;
                novoFornecedor.CEP = CEP;
                novoFornecedor.Criacao = Criacao;
                novoFornecedor.UltimaAlteracao = UltimaAlteracao;
                novoFornecedor.Exclusão = Exclusao;

            try
            {
                return FornecedoresDS.AdicionarFornecedor(novoFornecedor);
            }
            catch(Exception e)
            {
                throw new Exception("Ocorreu um erro ao inserir o fornecedor no banco de dados", e);
            }
        }

        internal static void AdicionarFornecedor(string v1, string v2, string v3, string v4, string v5)
        {
            throw new NotImplementedException();
        }
    }
}
