#pragma checksum "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b8ee094dba8b80330d547b0aa323ba3e4ce5fee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ventas_CancerlarReserva), @"mvc.1.0.view", @"/Views/Ventas/CancerlarReserva.cshtml")]
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
#line 1 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\_ViewImports.cshtml"
using Zbuss_Proyect;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\_ViewImports.cshtml"
using Zbuss_Proyect.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b8ee094dba8b80330d547b0aa323ba3e4ce5fee", @"/Views/Ventas/CancerlarReserva.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5720722c64ff9b7cdee343c5ac97ea6bb54da30", @"/Views/_ViewImports.cshtml")]
    public class Views_Ventas_CancerlarReserva : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Zbuss_Proyect.Models.TbDetalleVenta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reservas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancerlarReserva", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
  
    ViewData["Title"] = "CancerlarReserva";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CancerlarReserva</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
 if (ViewBag.Alert != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning alert-dismissible\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">X</button>\r\n        <h2><i class=\"bi bi-exclamation-triangle-fill\"></i> Alerta!</h2>\r\n        ");
#nullable restore
#line 15 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
   Write(ViewBag.Alert);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>TbDetalleVenta</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            Fecha de compra:\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
       Write(Html.DisplayFor(model => model.FechaVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Fecha de embarque:\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
       Write(Html.DisplayFor(model => model.FechaViaje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Subtotal:\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
       Write(Html.DisplayFor(model => model.SubTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Método de pago:\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
       Write(Html.DisplayFor(model => model.MetodoPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Igv:\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 52 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
       Write(Html.DisplayFor(model => model.Igv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Descuento:\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 58 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
       Write(Html.DisplayFor(model => model.Descuento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Total:\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 64 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
       Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Fecha de viaje:\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 70 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
       Write(Html.DisplayFor(model => model.FechaViaje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Código de asiento:\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 76 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
       Write(Html.DisplayFor(model => model.IdasientoNavigation.CodAsiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Doc. de pasajero:\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 82 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
       Write(Html.DisplayFor(model => model.IduserNavigation.NroDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Correo de comprador:\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 88 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
       Write(Html.DisplayFor(model => model.IdusuarioNavigation.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b8ee094dba8b80330d547b0aa323ba3e4ce5fee11450", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5b8ee094dba8b80330d547b0aa323ba3e4ce5fee11717", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 93 "C:\Users\Leogladeador\Desktop\LEO ARCHIVOS\IDAT\CICLO IV\Proyecto_Zbuss\Zbuss_Proyect_HanyV14\Zbuss_Proyect\Views\Ventas\CancerlarReserva.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Idventa);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Cancelar reserva\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b8ee094dba8b80330d547b0aa323ba3e4ce5fee13584", async() => {
                    WriteLiteral("Regresar a lista de reservas");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zbuss_Proyect.Models.TbDetalleVenta> Html { get; private set; }
    }
}
#pragma warning restore 1591
