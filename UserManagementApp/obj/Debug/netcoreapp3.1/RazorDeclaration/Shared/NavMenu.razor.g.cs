// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "F:\University\Интернет технологии и базы данных\Практика\14\practice_14_third_course\UserManagementApp\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
