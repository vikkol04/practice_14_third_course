#pragma checksum "F:\University\Интернет технологии и базы данных\Практика\14\practice_14_third_course\UserManagementApp\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fca9451ec935174f5330540cdd52fc7efe19a7dbf39f4a114e819cd96a478aa5"
// <auto-generated/>
#pragma warning disable 1591
namespace UserManagementApp.Shared
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\University\Интернет технологии и базы данных\Практика\14\practice_14_third_course\UserManagementApp\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "F:\University\Интернет технологии и базы данных\Практика\14\practice_14_third_course\UserManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "F:\University\Интернет технологии и базы данных\Практика\14\practice_14_third_course\UserManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "F:\University\Интернет технологии и базы данных\Практика\14\practice_14_third_course\UserManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "F:\University\Интернет технологии и базы данных\Практика\14\practice_14_third_course\UserManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "F:\University\Интернет технологии и базы данных\Практика\14\practice_14_third_course\UserManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "F:\University\Интернет технологии и базы данных\Практика\14\practice_14_third_course\UserManagementApp\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "F:\University\Интернет технологии и базы данных\Практика\14\practice_14_third_course\UserManagementApp\_Imports.razor"
using UserManagementApp

#nullable disable
    ;
#nullable restore
#line 9 "F:\University\Интернет технологии и базы данных\Практика\14\practice_14_third_course\UserManagementApp\_Imports.razor"
using UserManagementApp.Shared

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class MainLayout : LayoutComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<global::UserManagementApp.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "content px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddContent(12, 
#nullable restore
#line 15 "F:\University\Интернет технологии и базы данных\Практика\14\practice_14_third_course\UserManagementApp\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
