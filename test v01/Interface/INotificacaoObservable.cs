using test_v01.Repository.Models;

namespace test_v01.Services
{
    public interface INotificacaoObservable
    {
        Task NovoDocumento(Documento documento);
        Task DocumentoFavoritado(Documento documento);
    }
}