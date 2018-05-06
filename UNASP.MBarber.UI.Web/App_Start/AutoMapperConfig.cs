using AutoMapper;

namespace UNASP.MBarber.UI.Web.App_Start
{
    public class AutoMapperConfig
    {

        public static void Initialize()
        {
            // Inicialização do Mapper de Login
            Mapper.Initialize(cfg => { });
        }
    }
}