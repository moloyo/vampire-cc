using Autofac;
using CharacterCreator.DataAccess;
using CharacterCreator.UI.Data;
using CharacterCreator.UI.ViewModel;
using Prism.Events;

namespace CharacterCreator.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            builder.RegisterType<CharacterCreatorDbContext>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            builder.RegisterType<PersonajeDetailViewModel>().As<IPersonajeDetailViewModel>();

            builder.RegisterType<PersonajeDataService>().As<IPersonajeDataService>(); 
            builder.RegisterType<LookupDataService>().AsImplementedInterfaces(); 

            return builder.Build();
        }
    }
}
