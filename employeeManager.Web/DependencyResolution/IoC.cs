using StructureMap;
using employeeManager.Domain;
using employeeManager.Web.Infrastructure;

namespace employeeManager.Web {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IDepartmentDataSoure>().HttpContextScoped().Use<DepartmentDB>();
                        });
            return ObjectFactory.Container;
        }
    }
}