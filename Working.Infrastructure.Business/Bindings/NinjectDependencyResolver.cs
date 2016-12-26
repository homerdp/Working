using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Web;
using System.Web.Mvc;

namespace Working.Infrastructure.Business.Bindings
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            //Mock<IBookRepository> mock = new Mock<IBookRepository>();
            //mock.Setup(m => m.Books).Returns(new List<Book>
            //{
            //    new Book {Name = "Язык программирования c# 5.0", Author = "Troelsern", Price = 1179 },
            //    new Book {Name = "Платформа c# 5.0", Author = "Troelsern", Price = 850 },
            //    new Book {Name = "Асинхронное программирование c# 5.0", Author = "Troelsern", Price = 1234 },
            //});
            //kernel.Bind<IBookRepository>().To<EFBookRepository>();

        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}
