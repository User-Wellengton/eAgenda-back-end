using AutoMapper;
using eAgenda.Dominio.ModuloDespesa;
using eAgenda.Webapi.ViewModels.ModuloDespesa;

namespace eAgenda.Webapi.Config.AutoMapperConfig
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile()
        {
            CreateMap<CategoriaSelecionadaViewModel, Categoria>();

            CreateMap<FormsCategoriaViewModel, Categoria>()
                .ForMember(destino => destino.UsuarioId, opt => opt.MapFrom<UsuarioResolver>())

                 .ForMember(destino => destino.Id, opt => opt.Ignore()); 

            CreateMap<Categoria, ListarCategoriaViewModel>();

            CreateMap<Categoria, VisualizarCategoriaViewModel>();

            CreateMap<Categoria, FormsCategoriaViewModel>();

            CreateMap<Categoria, CategoriaSelecionadaViewModel>();

          
        }
    }
}
