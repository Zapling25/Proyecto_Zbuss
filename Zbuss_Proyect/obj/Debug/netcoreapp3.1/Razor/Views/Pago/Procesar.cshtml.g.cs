#pragma checksum "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\Pago\Procesar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b7211b23ac8e27af866a177d4a710f627f06d6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pago_Procesar), @"mvc.1.0.view", @"/Views/Pago/Procesar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b7211b23ac8e27af866a177d4a710f627f06d6d", @"/Views/Pago/Procesar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5720722c64ff9b7cdee343c5ac97ea6bb54da30", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pago_Procesar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagenes/visa_logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("visaLogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("35"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagenes/mastercard_logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("mastercardLogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\Pago\Procesar.cshtml"
  
    ViewData["Title"] = "ProcesarPago";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Pagar</h1>\r\n\r\n<h4>Procesar pago de viaje</h4>\r\n<hr />\r\n<div class=\"row justify-content-between\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b7211b23ac8e27af866a177d4a710f627f06d6d6713", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b7211b23ac8e27af866a177d4a710f627f06d6d6983", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 15 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\Pago\Procesar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div class=""form-group"">
                <label class=""control-label"">Número de tarjeta</label>
                <input class=""form-control"" id=""nroTarjeta"" maxlength=""16"" placeholder=""1234123412341234"">
            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <input checked=""checked"" id=""visa"" type=""radio"" name=""credit-card"" value=""visa"" />
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b7211b23ac8e27af866a177d4a710f627f06d6d9143", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <input id=\"mastercard\" type=\"radio\" name=\"credit-card\" value=\"mastercard\" />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b7211b23ac8e27af866a177d4a710f627f06d6d10704", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Caducidad</label>
                <input class=""form-control"" id=""caducidad"" placeholder=""MM/AA"" maxlength=""5""/>
                <span class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Código de seguridad/CVV</label>
                <input class=""form-control"" id=""codSeguridad"" placeholder=""123"" maxlength=""3""/>
                <span class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Titular de la tarjeta</label>
                <input class=""form-control"" maxlength=""20""/>
                <span class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Email</label>
                <input class=""form-control"" id=""emai");
                WriteLiteral(@"l"" placeholder=""zbuss2022@gmail.com""/>
                <span class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""button"" value=""Pagar"" class=""btn btn-success"" id=""btnPagar"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-md-4"">
        <h2>Detalle de compra</h2>
        <div class=""form-group"">
            <h4 class=""control-label"">Subtotal:</h4>
            S/<span class=""control-label"" id=""txtSubTotal""></span>
        </div>
        <div class=""form-group"">
            <h4 class=""control-label"">Código de asiento:</h4>
            <span class=""control-label"" id=""txtCodAsiento""></span>
        </div>
        <div class=""form-group"">
            <h4 class=""control-label"">Igv:</h4>
            S/<span class=""control-label"" id=""txtIgv"">0</span>
        </div>
        <div class=""form-group"">
            <h4 class=""control-label"">Descuento:</h4>
            S/<span class=""control-label"">0</span>
        </div>
        <div class=""form-group"">
            <h4 class=""control-label"">Total a pagar:</h4>
            S/<span class=""control-label"" id=""txtTotal""></span>
        </div>
    </div>
</div>
<script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
<script ty");
            WriteLiteral(@"pe=""text/javascript"">
    var idAsiento = localStorage.getItem(""idAsi"");
    var precioAsiento = localStorage.getItem(""precioAsi"");
    var codAsiento = localStorage.getItem(""codAsi"");
    var idPasajero = localStorage.getItem(""idPas"");
    var fechaV = localStorage.getItem(""fechaViaje"");
    var igv = localStorage.getItem(""Igv"");
    var total = localStorage.getItem(""Total"");

    $(document).ready(function () {

        $('#txtIgv').text(igv);
        $('#txtSubTotal').text(precioAsiento);
        $('#txtCodAsiento').text(codAsiento);
        $('#txtTotal').text(total);
    })
    $('#btnPagar').click(function (e) {

        var nroTarjeta = $('#nroTarjeta').val();
        var codSeguridad = $('#codSeguridad').val();
        var correo = $('#email').val();

        if (nroTarjeta.length < 16) {
            alert(""Faltan números de tarjeta"");
            return false;
        }
        else if (codSeguridad.length < 3) {
            alert(""Faltan números de código de seguridad"");
");
            WriteLiteral(@"            return false;
        }

        var params = {
            Iduser: idPasajero,
            Idasiento: idAsiento,
            SubTotal: precioAsiento,
            FechaViaje: fechaV,
            Total: total
        }

        var VG_RUTA_SERVIDOR = """";
        /*console.log(params);*/
        $.ajax
            ({
                type: ""POST"",
                url: ""/Pago/ProcesarCompra"",
                data: { pVenta: params },
                dataType: ""json"",
                success: function (result) {
                    if (result == null) {
                        alert(""El asiento ya ha comprado o hubo un error en la compra"");
                    }

                    console.log(result);
                    localStorage.setItem(""idVe"", result.idventa);
                    localStorage.setItem(""igvVe"", result.igv);
                    localStorage.setItem(""subtotalVe"", result.subTotal);
                    localStorage.setItem(""metodoVe"", result.metodoPago);
");
            WriteLiteral("                    localStorage.setItem(\"totalVe\", result.total);\r\n                    console.log(result.idventa);\r\n\r\n                    var id = result.idventa;\r\n                    var url = \"");
#nullable restore
#line 143 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\Pago\Procesar.cshtml"
                          Write(Url.Action("Reservas","Ventas"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
                    window.location = url;
                },
                error: function (result) {
                    if (result == null) {
                        alert(""El asiento ya ha comprado o hubo un error en la compra"");
                    }

                    console.log(result);
                    localStorage.setItem(""idVe"", result.idventa);
                    localStorage.setItem(""igvVe"", result.igv);
                    localStorage.setItem(""subtotalVe"", result.subTotal);
                    localStorage.setItem(""metodoVe"", result.metodoPago);
                    localStorage.setItem(""totalVe"", result.total);
                    console.log(result.idventa);

                    var id = result.idventa;
                    var url = """);
#nullable restore
#line 160 "C:\Proyecto_Zbuss\Zbuss_Proyect\Views\Pago\Procesar.cshtml"
                          Write(Url.Action("Reservas","Ventas"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
                    window.location = url;
                }
            })
    })

    //document.getElementById('caducidad').addEventListener('keydown', event => {
    //    var caducidad = document.getElementById('caducidad').value();
    //    alert(caducidad);

    //    if (caducidad.length > 1) {
    //        document.getElementById('caducidad').innerHTML = caducidad + '/';
    //    };
    //});


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
