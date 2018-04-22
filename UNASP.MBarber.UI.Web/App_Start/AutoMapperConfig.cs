using AutoMapper;
using UNASP.MBarber.DataAccess;
using UNASP.MBarber.DataTransferObject;

namespace UNASP.MBarber.UI.Web.App_Start
{
    public class AutoMapperConfig
    {

        public static void Initialize()
        {
            // Inicialização do Mapper de Login
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Login, LoginDTO>().ForMember(x => x.Clientes, opt => opt.Ignore());
            });
        }
    }
}