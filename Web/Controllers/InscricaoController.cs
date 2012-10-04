using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Data;
using Core.Model;
//using System.Net.Mail;
//using System.Net;
//using System.IO;


namespace Web.Controllers
{
    public class InscricaoController : Controller
    {
        private readonly Context _Context = new Context();

        //
        // GET: /Inscricao/
         public ActionResult Listar()
        {
            if (Request.IsAuthenticated)
            {
                #region Filtro
                //IDictionary<string, string> searchConditions = new Dictionary<string, string>();

                //if (this.Request.Form.AllKeys.Length > 0)
                //{
                //    searchConditions.Add("nome", Request["nome"]);
                //    searchConditions.Add("instituicao", Request["instituicao"]);
                //    searchConditions.Add("email", Request["email"]);
                //    searchConditions.Add("telefone", Request["telefone"]);
                //    searchConditions.Add("curso", Request["curso"]);
                //}
                //else
                //{
                //    object values = null;

                //    if (this.TempData.TryGetValue("SearchConditions", out values))
                //    {
                //        searchConditions = values as Dictionary<string, string>;
                //    }
                //    this.TempData["SearchConditions"] = searchConditions;
                //}
                #endregion

                return View(_Context.Inscricoes);
            }
            else
            {
                return RedirectToAction("LogOn", "Account");
            }
        }

        //
        // GET: /Inscricao/
        public ActionResult Index()
        {
            return View(new Inscricao());
        } 

        //
        // POST: /Inscricao/
        [HttpPost]
        public ActionResult Index(Inscricao collection)
        {
            if (collection != null)
            {
                _Context.Inscricoes.Add(collection);
                _Context.SaveChanges();

                if (Request.IsAuthenticated)
                    return RedirectToAction("Listar");
                else
                    return RedirectToAction("TelaConfirmacao", new { inscricaoComSucesso = true });
            }

            return View(collection);
        }

        #region "Projeto Email - Suspensso"
        //static void EnviaEmail(string Mensagem, string Destinatario, string Assunto, MailPriority Prioridade)
        //{
        //    //OBJETOS:::: cliente_smtp - remetente - destinatario - mensagem

        //    SmtpClient cliente_smtp = new SmtpClient("smtp.gmail.com");
        //    cliente_smtp.Credentials = new NetworkCredential("sabdca@gmail.com", "mainth2009");
        //    cliente_smtp.Port = 25;

        //    MailMessage _mailMessage = new MailMessage();
        //    _mailMessage.From = new MailAddress("sabdca@gmail.com", "Resumo Apresentação");
        //    _mailMessage.CC.Add("sabdca@gmail.com");
        //    _mailMessage.Subject = "Resumo " + collection.nome + " ID = " + collection.Id;
        //    _mailMessage.IsBodyHtml = true;
        //    _mailMessage.Body = "Segue resumo em anexo.";

        //    #region INICIO ANEXO
        //    //Como eu faço???
        //    FileStream fileToAttach = File.Open(@"~\arquivos\", FileMode.Open); //Ler arquivo do file system

        //    // string FileName = server.MapPath("~/App_data/contactForm.text");
        //    // FileStream fileToAttach = System.IO.File.ReadAllText(FileName);

        //    AttachmentCollection objAttachCol = mensagem.Attachments; //Pegar coleção de anexos
        //    Attachment objAttach = new Attachment(fileToAttach, "/"); //Criar objeto do arquivo anexo passando o FileStream instânciado
        //    objAttachCol.Add(objAttach);  //Anexar o arquivo


        //    //em seguida eu preciso apagar o arquivo da pasta no servidor

        //    #endregion




        //    try
        //    {
        //        cliente_smtp.Send(mensagem);

        //    }

        //    catch (Exception ex)
        //    {

        //        throw ex;

        //    }
        //}
        #endregion

        //
        // GET: /Inscricao/Details/5
        public ActionResult Details(int id)
         {
             if (Request.IsAuthenticated)
                 return View();
             else
                 return RedirectToAction("LogOn", "Account");
        }

        public ActionResult TelaConfirmacao(bool inscricaoComSucesso)
        {
            if (inscricaoComSucesso == true)
                return View();
            else
                return RedirectToAction("Create");
        }
        
        //
        // GET: /Inscricao/Editar/5
        public ActionResult Editar(int id)
        {
            if (Request.IsAuthenticated)
            {
                Inscricao usuarioParaEditar = _Context.Inscricoes.Find(id);
                return View(usuarioParaEditar);
            }
            else
                return RedirectToAction("LogOn", "Account");
        }

        //
        // POST: /Inscricao/Editar/5
        [HttpPost]
        public ActionResult Editar(Inscricao collection)
        {
            Inscricao inscrito = _Context.Inscricoes.Find(collection.Id);

            if (inscrito.tipoInsccricao != collection.tipoInsccricao)
                inscrito.tipoInsccricao = collection.tipoInsccricao;
            if (inscrito.nome != collection.nome)
                inscrito.nome = collection.nome;
            if (inscrito.instituicao != collection.instituicao)
                inscrito.instituicao = collection.instituicao;
            if (inscrito.email != collection.email)
                inscrito.email = collection.email;
            if (inscrito.telefone != collection.telefone)
                inscrito.telefone = collection.telefone;
            if (inscrito.curso != collection.curso)
                inscrito.curso = collection.curso;

            _Context.SaveChanges();

            return RedirectToAction("Listar");
        }

        //
        // GET: /Inscricao/Deletar/5
        public ActionResult Deletar(int id)
        {
            if (Request.IsAuthenticated)
            {
                Inscricao usuarioParaDeletar = _Context.Inscricoes.Find(id);
                return View(usuarioParaDeletar);
            }
            else
                return RedirectToAction("LogOn", "Account");
        }

        //
        // POST: /Inscricao/Deletar/5
        [HttpPost]
        public ActionResult Deletar(Inscricao collection)
        {
            var teste = _Context.Inscricoes.Where(i => i.Id == collection.Id).First();
            _Context.Inscricoes.Remove(teste);
            _Context.SaveChanges();

            return RedirectToAction("Listar");
        }
    }
}
