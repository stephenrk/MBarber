using AutoMapper;
using UNASP.MBarber.Repository.ConnectionContext;
using UNASP.MBarber.UI.Web.Models;

namespace UNASP.MBarber.UI.Web.App_Start
{
    public class AutoMapperConfig
    {

        public static void Initialize()
        {
            // Inicialização do Mapper de Login
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Empresa, EmpresaModel>().ForMember(x => x.TiposServicos, o => o.Ignore());
            });
        }
    }
}