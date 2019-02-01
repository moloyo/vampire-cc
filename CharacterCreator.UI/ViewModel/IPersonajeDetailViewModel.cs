using System.Threading.Tasks;

namespace CharacterCreator.UI.ViewModel
{
    public interface IPersonajeDetailViewModel
    {
        Task LoadAsync(int idPersonaje);
    }
}