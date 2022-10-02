using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorserverWithTinymceStepbyStep
{
    public static class Interop
    {

        public static ValueTask<string> GetContent(IJSRuntime jSRuntime, string id)
        {
         var content=  jSRuntime.InvokeAsync<string>("blazeditorGetContent", id);
            return content;
                 
        }
            

    }
}
