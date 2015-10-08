using System.Collections.Generic;

namespace code.features.catalog_browsing
{
  public interface IGetDepartments
  {
    IEnumerable<MainDepartment> main_departments();
  }
}