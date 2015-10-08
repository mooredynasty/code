using System.Collections.Generic;
using System.Linq;

namespace code.web
{
  public class WebHandlers : IGetWebRequestHandlers
  {
    IEnumerable<IHandleOneWebRequest> handlers;

    public WebHandlers(IEnumerable<IHandleOneWebRequest> handlers)
    {
        this.handlers = handlers;
    }

    public IHandleOneWebRequest get_handler_for_request(IProvideDetailsToHandlers request)
    {
        return this.handlers.Where(h => h.can_process(request)).First();
    }
  }
}