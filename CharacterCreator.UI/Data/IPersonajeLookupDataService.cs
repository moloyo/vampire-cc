using CharacterCreator.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CharacterCreator.UI.Data
{
    public interface IPersonajeLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetPersonajesLookupAsync();
    }
}