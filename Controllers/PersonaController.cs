using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC_Gonzales.Models;

namespace Lab2_MVC_Gonzales.Controllers
{
    public class PersonaController : Controller
    {
        List<ClsPersona> objLista = new List<ClsPersona>();
        // GET: Persona
        public ActionResult Index()
        {
            //Instanciar para el objeto 1
            ClsPersona objPersona1 = new ClsPersona();
            //Instanciar atributos
            objPersona1.apellido = "Gonzales";
            objPersona1.nombre = "Angel";
            objPersona1.email = "anggonzalesca@upt.pe";
            objPersona1.sexo =  true;
            objPersona1.edad = 22;
            objPersona1.talla = 1.75;
            objLista.Add(objPersona1);

            //Instanciar para el objeto 2
            ClsPersona objPersona2 = new ClsPersona();
            //Instanciar atributos
            objPersona2.apellido = "Mamani Ayala";
            objPersona2.nombre = "Brandon";
            objPersona2.email = "branayala@upt.pe";
            objPersona2.sexo = true;
            objPersona2.edad = 23;
            objPersona2.talla = 1.65;
            objLista.Add(objPersona2);

            //Instanciar para el objeto 3
            ClsPersona objPersona3 = new ClsPersona();
            //Instanciar atributos
            objPersona3.apellido = "Sosa Bedoya";
            objPersona3.nombre = "Sharon";
            objPersona3.email = "shabedoya@upt.pe";
            objPersona3.sexo = false;
            objPersona3.edad = 20;
            objPersona3.talla = 1.68;
            objLista.Add(objPersona3);


            //Instanciar para el objeto 4
            ClsPersona objPersona4 = new ClsPersona();
            //Instanciar atributos
            objPersona4.apellido = "Estrella Palacios";
            objPersona4.nombre = "Estrella";
            objPersona4.email = "estrepa@upt.pe";
            objPersona4.sexo = false;
            objPersona4.edad = 205;
            objPersona4.talla = 1.72;
            objLista.Add(objPersona4);

            return View(objLista);
        }


    }
}