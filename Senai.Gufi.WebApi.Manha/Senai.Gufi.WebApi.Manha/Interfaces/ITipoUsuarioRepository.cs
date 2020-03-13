using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface ITipoUsuarioRepository 
    {
        List<TipoUsuario> Listar();

        void Cadastrar(TipoUsuario novotipousuario);

        TipoUsuario BuscarPorId(int id);

        void Atualizar(int id, TipoUsuario tipoUsuarioAtualizado);


        void Deletar(int id);
    }
}
