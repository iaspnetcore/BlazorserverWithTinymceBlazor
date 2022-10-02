using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorserverWithTinymceStepbyStep
{
    public static class Interop
    {


        public static ValueTask<object> InitializeTextEditor(IJSRuntime jSRuntime)
        {
           var id = jSRuntime.InvokeAsync<object>( "blazeditorInit" );

            return id;

        }

        public static ValueTask<string> GetContent(IJSRuntime jSRuntime, string id)
        {
         var content=  jSRuntime.InvokeAsync<string>("blazeditorGetContent", id);
            return content;
                 
        }
            

    }
}
