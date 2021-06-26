using CRUDClientes.Models.Contexto;
using CRUDClientes.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDClientes.Controllers
{
    public class ClientesController : Controller
    {

        private readonly Contexto _contexto;
        public ClientesController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
           var lista = _contexto.Clientes.ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var cliente = new Clientes();
            CarregaTipoDocumento();
            CarregaTipoEndereco();
            CarregaTipoEndereco2();
            CarregaTipoEndereco3();
            CarregaTipoTelefone();
            CarregaTipoTelefone2();
            CarregaTipoTelefone3();

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Create(Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                _contexto.Clientes.Add(cliente);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            CarregaTipoDocumento();
            CarregaTipoEndereco();
            CarregaTipoEndereco2();
            CarregaTipoEndereco3();
            CarregaTipoTelefone();
            CarregaTipoTelefone2();
            CarregaTipoTelefone3();

            return View(cliente);
        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var cliente = _contexto.Clientes.Find(Id);

            CarregaTipoDocumento();
            CarregaTipoEndereco();
            CarregaTipoEndereco2();
            CarregaTipoEndereco3();
            CarregaTipoTelefone();
            CarregaTipoTelefone2();
            CarregaTipoTelefone3();
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                _contexto.Clientes.Update(cliente);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                CarregaTipoDocumento();
                CarregaTipoEndereco();
                CarregaTipoEndereco2();
                CarregaTipoEndereco3();
                CarregaTipoTelefone();
                CarregaTipoTelefone2();
                CarregaTipoTelefone3();
                return View(cliente);
            }
        }




        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var cliente = _contexto.Clientes.Find(Id);
            CarregaTipoDocumento();
            CarregaTipoEndereco();
            CarregaTipoEndereco2();
            CarregaTipoEndereco3();
            CarregaTipoTelefone();
            CarregaTipoTelefone2();
            CarregaTipoTelefone3();
            return View(cliente);
        }


        [HttpPost]
        public IActionResult Delete(Clientes _cliente)
        {
            var cliente = _contexto.Clientes.Find(_cliente.Id);
            if (cliente != null)
            {
                _contexto.Clientes.Remove(cliente);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            CarregaTipoDocumento();
            CarregaTipoEndereco();
            CarregaTipoEndereco2();
            CarregaTipoEndereco3();
            CarregaTipoTelefone();
            CarregaTipoTelefone2();
            CarregaTipoTelefone3();
            return View(cliente);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var cliente = _contexto.Clientes.Find(Id);
            CarregaTipoDocumento();
            CarregaTipoEndereco();
            CarregaTipoEndereco2();
            CarregaTipoEndereco3();
            CarregaTipoTelefone();
            CarregaTipoTelefone2();
            CarregaTipoTelefone3();
            return View(cliente);
        }


        public void CarregaTipoDocumento()
        {
            var ItensTipoDocumento = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text="CPF"},
                new SelectListItem{Value = "2", Text="CNPJ"}
            };

            ViewBag.TiposDocumento = ItensTipoDocumento;

        }

        public void CarregaTipoEndereco()
        {
            var ItensTipoEndereco = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text="Cobrança"},
                new SelectListItem{Value = "2", Text="Comercial"},
                new SelectListItem{Value = "3", Text="Correspondência"},
                new SelectListItem{Value = "4", Text="Entrega"},
                new SelectListItem{Value = "5", Text="Residencial"}
            };

            ViewBag.TiposEndereco = ItensTipoEndereco;

        }

        public void CarregaTipoEndereco2()
        {
            var ItensTipoEndereco2 = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text="Cobrança"},
                new SelectListItem{Value = "2", Text="Comercial"},
                new SelectListItem{Value = "3", Text="Correspondência"},
                new SelectListItem{Value = "4", Text="Entrega"},
                new SelectListItem{Value = "5", Text="Residencial"}
            };

            ViewBag.TiposEndereco2 = ItensTipoEndereco2;

        }

        public void CarregaTipoEndereco3()
        {
            var ItensTipoEndereco3 = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text="Cobrança"},
                new SelectListItem{Value = "2", Text="Comercial"},
                new SelectListItem{Value = "3", Text="Correspondência"},
                new SelectListItem{Value = "4", Text="Entrega"},
                new SelectListItem{Value = "5", Text="Residencial"}
            };

            ViewBag.TiposEndereco3 = ItensTipoEndereco3;

        }

        public void CarregaTipoTelefone()
        {
            var ItensTipoTelefone = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text="Celular"},
                new SelectListItem{Value = "2", Text="Residencial"},
                new SelectListItem{Value = "3", Text="Comercial"}
            };

            ViewBag.TiposTelefone = ItensTipoTelefone;

        }

        public void CarregaTipoTelefone2()
        {
            var ItensTipoTelefone2 = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text="Celular"},
                new SelectListItem{Value = "2", Text="Residencial"},
                new SelectListItem{Value = "3", Text="Comercial"}
            };

            ViewBag.TiposTelefone2 = ItensTipoTelefone2;

        }

        public void CarregaTipoTelefone3()
        {
            var ItensTipoTelefone3 = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text="Celular"},
                new SelectListItem{Value = "2", Text="Residencial"},
                new SelectListItem{Value = "3", Text="Comercial"}
            };

            ViewBag.TiposTelefone3 = ItensTipoTelefone3;

        }

    }
}
