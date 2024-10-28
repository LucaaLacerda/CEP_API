using IntegraProjetoApi.Dtos;
using IntegraProjetoApi.Models;

namespace IntegraProjetoApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
    }
}