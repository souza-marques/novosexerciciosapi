using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {

        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, TipoUsuario tuAtualizado)
        {
            TipoUsuario tuBuscado = ctx.TipoUsuario.Find(id);

            tuBuscado.TituloTipoUsuario = tuAtualizado.TituloTipoUsuario;

            ctx.TipoUsuario.Update(tuBuscado);

            ctx.SaveChanges();

        }

        public TipoUsuario BuscarPorId(int id)
        {
            return ctx.TipoUsuario.FirstOrDefault(e => e.IdTipoUsuario == id);

        }

        public void Cadastrar(TipoUsuario novoTipoUsuario)
        {
            ctx.TipoUsuario.Add(novoTipoUsuario);

            ctx.SaveChanges();
        }


        public void Deletar(int id)
        {
            ctx.TipoUsuario.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuario.ToList();
        }
    }
}
