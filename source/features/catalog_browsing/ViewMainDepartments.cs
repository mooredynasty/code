using code.web;

namespace code.features.catalog_browsing
{
  public class ViewMainDepartments : IRunAUserFeature
  {
    IGetDepartments departmentRepo;

    public ViewMainDepartments(IGetDepartments departmentRepo)
    {
        this.departmentRepo = departmentRepo;
    }

    public void process(IProvideDetailsToHandlers request)
    {
      this.departmentRepo.main_departments();
    }
  }
}