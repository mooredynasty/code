using code.web;

namespace code.features.catalog_browsing
{
  public class ViewMainDepartments : IRunAUserFeature
  {
      private IGetDepartments departments;

      public ViewMainDepartments(IGetDepartments departments)
      {
          this.departments = departments;
      }
    public void process(IProvideDetailsToHandlers request)
    {
        this.departments = departments;
        departments.main_departments();
    }
  }
}