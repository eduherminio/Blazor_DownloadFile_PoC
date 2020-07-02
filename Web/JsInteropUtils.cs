using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Web
{
    public static class JsInteropUtils
    {
        public static ValueTask<object> SaveAs(this IJSRuntime js, string filename, byte[] data)
        {
            return js.InvokeAsync<object>(
                "saveAsFile",
                filename,
                Convert.ToBase64String(data));
        }
    }
}
