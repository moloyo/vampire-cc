using System.Threading.Tasks;

namespace CharacterCreator.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(INavigationViewModel navigationViewModel, IPersonajeDetailViewModel personajeDetailViewModel)
        {
            this.NavigationViewModel = navigationViewModel;
            this.PersonajeDetailViewModel = personajeDetailViewModel;
        }

        public INavigationViewModel NavigationViewModel { get; }
        public IPersonajeDetailViewModel PersonajeDetailViewModel { get; }

        public async Task LoadAsync()
        {
            await this.NavigationViewModel.LoadAsync();
        }
    }
}
