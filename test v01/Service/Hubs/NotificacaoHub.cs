using Microsoft.AspNetCore.SignalR;
using test_v01.Repository.Models;

namespace SeuProjeto.Hubs
{
    public class NotificacaoHub : Hub
    {
        // Métodos que os clientes podem chamar para enviar notificações
        public async Task EnviarNovoDocumento(Documento documento)
        {
            await Clients.All.SendAsync("ReceberNovoDocumento", documento);
        }

        public async Task EnviarDocumentoFavoritado(Documento documento)
        {
            await Clients.All.SendAsync("ReceberDocumentoFavoritado", documento);
        }
    }
}
