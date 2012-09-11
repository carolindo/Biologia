using System.Web.Mvc;
using Biologia.Domain.Repository;
using Biologia.Domain;

namespace Biologia.Web.Controllers
{
    public class InscricaoController : Controller
    {
        private IinscricaoRepository _repository;
        
        public InscricaoController(IinscricaoRepository repository)
        {
            _repository = repository;
        }

        public ViewResult Index()
        {
            return View(_repository.PegarTodasIncricoes());
        }

        public ViewResult Details(int id)
        {
            Inscricao inscricao = _repository.DetalheInscricao(id);
            return View(inscricao);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Inscricao inscricao)
        {
            if (ModelState.IsValid)
            {
                _repository.CriarInscricao(inscricao);
                return RedirectToAction("TelaConfirmacao", new { inscricaoComSucesso = true });
            }
            return View(inscricao);
        }

        public ActionResult TelaConfirmacao(bool inscricaoComSucesso)
        {
            if (inscricaoComSucesso == true)
                return View();
            else
                return RedirectToAction("Create");
        }

        public ActionResult Edit(int id)
        {
            Inscricao inscricao = _repository.DetalheInscricao(id);
            return View(inscricao);
        }

        [HttpPost]
        public ActionResult Edit(Inscricao inscricao)
        {
            if (ModelState.IsValid)
            {
                _repository.EditarInscricao(inscricao);
                return RedirectToAction("Index");
            }
            return View(inscricao);
        }

        public ActionResult Delete(int id)
        {
            Inscricao inscricao = _repository.DetalheInscricao(id);
            return View(inscricao);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _repository.DeletarInscricao(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}