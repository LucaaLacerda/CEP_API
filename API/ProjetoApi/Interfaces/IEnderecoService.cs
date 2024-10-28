using IntegraProjetoApi.Dtos;

namespace IntegraProjetoApi.Interfaces
{
        public interface IEnderecoService 
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}