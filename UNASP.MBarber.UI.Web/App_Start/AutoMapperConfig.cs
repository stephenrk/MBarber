using AutoMapper;
using UNASP.MBarber.DataAccess;
using UNASP.MBarber.UI.Web.ViewModels;

namespace UNASP.MBarber.UI.Web.App_Start
{
    public class AutoMapperConfig
    {

        public static void Initialize()
        {
            // Inicialização do Mapper de Login
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Login, LoginModel>().ForMember(x => x.Cliente, y => y.Ignore());
            });
        }
    }
}