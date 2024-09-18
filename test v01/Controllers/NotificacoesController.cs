using Microsoft.AspNetCore.Mvc;
using Notify_iGlem.Services;
using test_v01.Repository.Models;
using test_v01.Services;


namespace test_v01.Controllers
{
    public class NotificacoesController : Controller
    {
        private readonly INotificacaoObservable _notificacaoObservable;

        public NotificacoesController(INotificacaoObservable notificacaoObservable)
        {
            _notificacaoObservable = notificacaoObservable;

        }

        // GET: Notificacoes
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NotificarNovoDocumento(Documento documento)
        {
            if (documento == null)
            {
                return BadRequest("Documento inválido.");
            }

            // Notificar os usuários sobre o novo documento
            await _notificacaoObservable.NovoDocumento(documento);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> NotificarDocumentoFavoritado(Documento documento)
        {
            if (documento == null)
            {
                return BadRequest("Documento inválido.");
            }

            // Notificar os usuários sobre o documento favoritado
            await _notificacaoObservable.DocumentoFavoritado(documento);
            return Ok();
        }
    }
}
