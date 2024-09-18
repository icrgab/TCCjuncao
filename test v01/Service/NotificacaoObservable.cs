using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SeuProjeto.Hubs; // Substitua pelo namespace correto onde seu Hub está localizado
using test_v01.Repository.Models;
using test_v01.Services;

namespace Notify_iGlem.Services
{
    public class NotificacaoObservable : INotificacaoObservable
    {
        private readonly IHubContext<NotificacaoHub> _hubContext;

        public NotificacaoObservable(IHubContext<NotificacaoHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task NovoDocumento(Documento documento)
        {
            // Enviar notificação para todos os clientes conectados
            await _hubContext.Clients.All.SendAsync("ReceberNovoDocumento", documento);
        }

        public async Task DocumentoFavoritado(Documento documento)
        {
            // Enviar notificação para todos os clientes conectados
            await _hubContext.Clients.All.SendAsync("ReceberDocumentoFavoritado", documento);
        }
    }
}
