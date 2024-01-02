using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO
                {
                    Titulo="Manejador de presupuesto",
                    Descripcion="Desarrollado con ASP.NET Core y Dapper",
                    Link="https://amazon.com",
                    ImagenURL="/img/amz.png"
                },
                new ProyectoDTO
                {
                    Titulo="Manejador de tarear",
                    Descripcion="Desarrollado con ASP.NET Core y EFC",
                    Link="https://amazon.com",
                    ImagenURL="/img/nyt.jpg"
                },
                new ProyectoDTO
                {
                    Titulo="Proyectos variados",
                    Descripcion="Proyectos universitarios realizados en distintos ambitos",
                    Link="https://amazon.com",
                    ImagenURL="/img/rdt.png"
                }
            };
        }
    }
}
