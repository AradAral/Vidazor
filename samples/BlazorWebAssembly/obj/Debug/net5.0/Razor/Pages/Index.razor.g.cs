#pragma checksum "D:\Development\Vidazor\samples\BlazorWebAssembly\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1328b70f2b24a9fb89edd20f36542f9bcce1077"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebAssembly.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Development\Vidazor\samples\BlazorWebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Development\Vidazor\samples\BlazorWebAssembly\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Development\Vidazor\samples\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Development\Vidazor\samples\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Development\Vidazor\samples\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Development\Vidazor\samples\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Development\Vidazor\samples\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Development\Vidazor\samples\BlazorWebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Development\Vidazor\samples\BlazorWebAssembly\_Imports.razor"
using BlazorWebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Development\Vidazor\samples\BlazorWebAssembly\_Imports.razor"
using BlazorWebAssembly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Development\Vidazor\samples\BlazorWebAssembly\_Imports.razor"
using Vidazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Development\Vidazor\samples\BlazorWebAssembly\_Imports.razor"
using Vidazor.Types;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Vidazor.VidazorVideo>(0);
            __builder.AddAttribute(1, "src", "/sample.mp4");
            __builder.AddAttribute(2, "class", "video");
            __builder.AddAttribute(3, "controls", true);
            __builder.AddComponentReferenceCapture(4, (__value) => {
#nullable restore
#line 3 "D:\Development\Vidazor\samples\BlazorWebAssembly\Pages\Index.razor"
                    video = (Vidazor.VidazorVideo)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1 class=\"heading\">Methods:</h1>\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "type", "button");
            __builder.AddAttribute(11, "class", "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\Development\Vidazor\samples\BlazorWebAssembly\Pages\Index.razor"
                                                   () => video.Play()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Play()");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "class", "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\Development\Vidazor\samples\BlazorWebAssembly\Pages\Index.razor"
                                                   () => video.Pause()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Pause()");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\Development\Vidazor\samples\BlazorWebAssembly\Pages\Index.razor"
                                                   () => video.Load()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Load()");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "button");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\Development\Vidazor\samples\BlazorWebAssembly\Pages\Index.razor"
                                                     () => canPlayType = video.CanPlayType("video/mp4")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "CanPlayType(\"video/mp4\") ");
            __builder.AddContent(32, 
#nullable restore
#line 10 "D:\Development\Vidazor\samples\BlazorWebAssembly\Pages\Index.razor"
                                                                                                                                    canPlayType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\Development\Vidazor\samples\BlazorWebAssembly\Pages\Index.razor"
       
    VidazorVideo video;

    MediaPlayableStatus? canPlayType;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591