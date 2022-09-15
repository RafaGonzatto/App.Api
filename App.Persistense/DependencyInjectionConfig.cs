using App.Domain.Interfaces.Repositories;
using App.Persistense.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistense
{
    public class DependencyInjectionConfig //Relacionar a Dependency com a Service, vamos chamar a interface, não a Service, mas é a Service que executara ela, por isso o Dependency Injetion para ligalas
    {       //Sem a Dependency o Controller falara que a Service não está relacionada com nada
        public static void Inject(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        }
    }
}
