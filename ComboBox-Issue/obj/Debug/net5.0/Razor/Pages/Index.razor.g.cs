#pragma checksum "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb36772be800f9e2fafd28ce5f35c714fbaa47d7"
// <auto-generated/>
#pragma warning disable 1591
namespace ComboBox_Issue.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\_Imports.razor"
using ComboBox_Issue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\_Imports.razor"
using ComboBox_Issue.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\Pages\Index.razor"
using ComboBox_Issue.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<ComboBox_Issue.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<ComboBox_Issue.Components.JahrRange>(4);
            __builder.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 9 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\Pages\Index.razor"
                 jahre = (ComboBox_Issue.Components.JahrRange)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\Pages\Index.razor"
 
	JahrRange jahre;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591