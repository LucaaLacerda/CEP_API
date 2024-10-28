using IntegraProjetoApi.Dtos;

namespace IntegraProjetoApi.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEnderecoPorCEP(string cep);
        
    }

}
