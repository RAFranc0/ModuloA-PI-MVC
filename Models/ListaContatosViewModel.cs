using System;
using System.Collections.Generic;
using Atv_3___MVC_.net.Models;

namespace Atv_3___MVC_.net.Models
{
    public class ListaContatoViewModel
    {
        private static List<ContatoViewModel> contatos;

        static ListaContatoViewModel()
        {
            contatos = new List<ContatoViewModel>();
        }

        public static void Add(ContatoViewModel contato)
        {
            contatos.Add(contato);
        }

        public static List<ContatoViewModel> List(){
            return contatos;
        }
    }
} 