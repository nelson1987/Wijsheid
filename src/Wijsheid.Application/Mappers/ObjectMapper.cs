using AutoMapper;
using Wijsheid.Domain;
using WijSheid.Application.Models;

namespace Wijsheid.Application.Mappers
{
    public static class ObjectMapper
    {
        public static IMapper Mapper
        {
            get
            {
                return config.CreateMapper();
            }
        }
        private static MapperConfiguration config
        {
            get
            {
                return new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<AlunoListagemDto, Aluno>();
                    cfg.CreateMap<Aluno, AlunoCriacaoDto>();
                });
            }
        }
    }
}
