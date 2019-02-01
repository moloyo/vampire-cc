using System.Collections.Generic;
using System.Threading.Tasks;
using CharacterCreator.Model;

namespace CharacterCreator.UI.Data
{
    public interface IPersonajeDataService
    {
        Task<Personaje> GetByIdAsync(int idPersonaje);
    }
}