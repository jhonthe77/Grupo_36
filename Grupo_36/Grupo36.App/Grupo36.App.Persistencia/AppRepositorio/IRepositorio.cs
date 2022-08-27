using System.Collections.Generic;
using Grupo36.App.Dominio;

namespace Grupo36.App.Persistencia
{
    public interface IRepositorio{

        IEnumerable<Persona> GetAllPersona();
        Persona AddPersona(Persona perso);
        Persona UpdatePersona(Persona perso);
        void DeletePersona(int idpersona);
        Persona GetPersona(int idpersona);

    }
}