// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ComboBox_Issue.Components
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
#line 1 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\Components\FormItemBase.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
    public partial class FormItemBase : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\t.markus.FAO20\source\repos\ComboBox-Issue\ComboBox-Issue\Components\FormItemBase.razor"
       
    private const int BOOTSTRAP_GRID_COLUMNS = 12;
    private const int _LeftCol = 4;
    private string LeftCol = $"{_LeftCol}";
    private string RightCol = $"{BOOTSTRAP_GRID_COLUMNS - _LeftCol}";

    [Parameter]
    public string Id { get; set; } = RandomId;

    [Parameter]
    public string Label { get; set; } = "Label";

    [Parameter]
    public string Description { get; set; } = "";

    [Parameter]
    public RenderFragment Content { get; set; }

    private static string RandomId
    {
        get { return Guid.NewGuid().ToString(); }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591