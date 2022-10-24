using AutoMapper;
using eAgenda.Dominio.ModuloContato;
using eAgenda.Webapi.ViewModels.ModuloContato;

namespace eAgenda.Webapi.Config.AutoMapperConfig
{
    public class ContatoProfile : Profile
    {
        public ContatoProfile()
        {
            CreateMap<FormsContatoViewModel, Contato>()
                .ForMember(destino => destino.UsuarioId, opt => opt.MapFrom<UsuarioResolver>())

                .ForMember(destino => destino.Id, opt => opt.Ignore());

            CreateMap<Contato, ListarContatoViewModel>();

            CreateMap<Contato, VisualizarContatoViewModel>()
                .ForMember(destino => destino.Compromissos, opt => opt.MapFrom(origem => origem.Compromissos));

            CreateMap<Contato, FormsContatoViewModel>();

            
        }        
    }
}