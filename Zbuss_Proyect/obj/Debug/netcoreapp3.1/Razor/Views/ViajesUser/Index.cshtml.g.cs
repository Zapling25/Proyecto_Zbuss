#pragma checksum "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c4887664f8b10f5efe316d42b3ddcb1094ac6b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViajesUser_Index), @"mvc.1.0.view", @"/Views/ViajesUser/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\_ViewImports.cshtml"
using Zbuss_Proyect;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\_ViewImports.cshtml"
using Zbuss_Proyect.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c4887664f8b10f5efe316d42b3ddcb1094ac6b7", @"/Views/ViajesUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5720722c64ff9b7cdee343c5ac97ea6bb54da30", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ViajesUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Zbuss_Proyect.Models.TbDetalleViaje>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
 if (ViewBag.Alert != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning alert-dismissible\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">X</button>\r\n        <h2><i class=\"bi bi-exclamation-triangle-fill\"></i> Alerta!</h2>\r\n        ");
#nullable restore
#line 13 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
   Write(ViewBag.Alert);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Elige tu viaje a reservar</h1>\r\n<br />\r\n\r\n<div id=\"prueba\">\r\n\r\n</div>\r\n<table class=\"table\">\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaSalida));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <label class=\"col-form-label font-weight-bold\">Fecha salida</label>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HoraSalida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td><i class=\"bi bi-arrow-right-square-fill\"></i></td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HoraLlegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PuntoPartida));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <label class=\"col-form-label font-weight-bold\"><i class=\"bi bi-geo-alt\"></i> Partida</label>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PuntoLlegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <label class=\"col-form-label font-weight-bold\"><i class=\"bi bi-geo-alt\"></i> Llegada</label>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NroAsientos));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <label class=\"col-form-label font-weight-bold\">Asientos</label>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DuracionViaje));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hrs.\r\n                </td>\r\n                <td>\r\n                    <input type=\"button\" value=\"Comprar boleto\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2016, "\"", 2052, 3);
            WriteAttributeValue("", 2026, "recuperarId(", 2026, 12, true);
#nullable restore
#line 55 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
WriteAttributeValue("", 2038, item.Idviaje, 2038, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2051, ")", 2051, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" />\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 58 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
<script type=""text/javascript"">

    function recuperarId(idViaje) {
        $.ajax
            ({
                type: ""POST"",
                url: ""/ViajesUser/RecuperarViaje"",
                data: { id: idViaje },
                dataType: ""json"",
                success: function (result) {

                    if (result == null) {
                        alert(""No se encontró el viaje"");
                    }

                    var fechav = result.fechaSalida;
                    var idBus = result.idbus;

                    localStorage.setItem(""fechaViaje"", fechav);
                    localStorage.setItem(""codBus"", idBus);
                    window.location = '");
#nullable restore
#line 82 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\ViajesUser\Index.cshtml"
                                  Write(Url.Action("Index", "Asientos"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n                },\r\n                error: function (result) {\r\n                    alert(\"Error al acceder al controlador\");\r\n                }\r\n            })\r\n    }\r\n\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Zbuss_Proyect.Models.TbDetalleViaje>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
