#pragma checksum "C:\Users\Campus-Comuputer\source\repos\Parking Alert\Parking Alert\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5f03dd1530f43fa2799212de4ad5f9a966d22d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\Campus-Comuputer\source\repos\Parking Alert\Parking Alert\Views\_ViewImports.cshtml"
using Parking_Alert;

#line default
#line hidden
#line 2 "C:\Users\Campus-Comuputer\source\repos\Parking Alert\Parking Alert\Views\_ViewImports.cshtml"
using Parking_Alert.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5f03dd1530f43fa2799212de4ad5f9a966d22d2", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c4163973ad224c481b7264870c9d697c6816834", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 1240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5f03dd1530f43fa2799212de4ad5f9a966d22d23290", async() => {
                BeginContext(43, 757, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content=""Purpose is a unique and beautiful collection of UI elements that are all flexible and modular. A complete and customizable solution to building the website of your dreams."">
    <meta name=""author"" content=""Webpixels"">
    <title>Purpose Website UI Kit - Purpose is a unique and beautiful collection of UI elements that are all flexible and modular. A complete and customizable solution to building the website of your dreams.</title>
    <!-- Favicon -->
    <link rel=""icon"" href=""../../assets/img/brand/favicon.png"" type=""image/png"">
    <!-- Font Awesome 5 -->
    <link rel=""stylesheet""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 800, "\"", 871, 3);
                WriteAttributeValue("", 807, "../../assets/libs/", 807, 18, true);
                WriteAttributeValue("", 825, "@", 825, 1, true);
                WriteAttributeValue("", 827, "fortawesome/fontawesome-free/css/all.min.css", 827, 44, true);
                EndWriteAttribute();
                BeginContext(872, 213, true);
                WriteLiteral("><!-- Page CSS -->\r\n    <link rel=\"stylesheet\" href=\"../../assets/libs/animate.css/animate.min.css\">\r\n    <link rel=\"stylesheet\" href=\"../../assets/libs/swiper/dist/css/swiper.min.css\">\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1085, "\"", 1159, 3);
                WriteAttributeValue("", 1092, "../../assets/libs/", 1092, 18, true);
                WriteAttributeValue("", 1110, "@", 1110, 1, true);
                WriteAttributeValue("", 1112, "fancyapps/fancybox/dist/jquery.fancybox.min.css", 1112, 47, true);
                EndWriteAttribute();
                BeginContext(1160, 110, true);
                WriteLiteral(">\r\n    <!-- Purpose CSS -->\r\n    <link rel=\"stylesheet\" href=\"../../assets/css/purpose.css\" id=\"stylesheet\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1277, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1280, 12, false);
#line 20 "C:\Users\Campus-Comuputer\source\repos\Parking Alert\Parking Alert\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(1292, 3512, true);
            WriteLiteral(@"
<footer class=""footer footer-dark bg-dark"" id=""footer-main"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 mb-5 mb-lg-0"">
                <a href=""../../index.html"">
                    <img src=""../../assets/img/brand/white.png"" alt=""Footer logo"" style=""height: 70px;"">
                </a>
                <p class=""text-sm"">A unique and beautiful collection of UI elements that are all flexible and modular. A complete and customizable solution to building the website of your dreams.</p>
            </div>
            <div class=""col-lg-2 col-6 col-sm-4 ml-lg-auto mb-5 mb-lg-0"">
                <h6 class=""heading mb-3"">Account</h6>
                <ul class=""list-unstyled"">
                    <li><a href=""../../pages/account-profile.html"">Profile</a></li>
                    <li><a href=""../../pages/account-settings.html"">Settings</a></li>
                    <li><a href=""../../pages/account-billing.html"">Billing</a></li>
                    <li><a hre");
            WriteLiteral(@"f=""../../pages/account-notifications.html"">Notifications</a></li>
                </ul>
            </div>
            <div class=""col-lg-2 col-6 col-sm-4 mb-5 mb-lg-0"">
                <h6 class=""heading mb-3"">About</h6>

                <ul class=""list-unstyled text-small"">
                    <li><a href=""#"">Services</a></li>
                    <li><a href=""#"">Contact</a></li>
                    <li><a href=""#"">Careers</a></li>
                </ul>
            </div>
            <div class=""col-lg-2 col-sm-4 mb-5 mb-lg-0"">
                <h6 class=""heading mb-3"">Company</h6>
                <ul class=""list-unstyled"">
                    <li><a href=""#"">Terms</a></li>
                    <li><a href=""#"">Privacy</a></li>
                    <li><a href=""#"">Support</a></li>
                </ul>
            </div>
        </div>
        <div class=""row align-items-center justify-content-md-between py-4 mt-4 delimiter-top"">
            <div class=""col-md-6"">
                <div clas");
            WriteLiteral(@"s=""copyright text-sm font-weight-bold text-center text-md-left"">
                    &copy; 2019 <a href="""" class=""font-weight-bold"" target=""_blank"">Webpixels</a>. All rights reserved.
                </div>
            </div>
            <div class=""col-md-6"">
                <ul class=""nav justify-content-center justify-content-md-end mt-3 mt-md-0"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""https://dribbble.com/"" target=""_blank"">
                            <i class=""fab fa-dribbble""></i>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link active"" href=""https://instagram.com/"" target=""_blank"">
                            <i class=""fab fa-instagram""></i>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""https://github.com/"" target=""_blank"">
                   ");
            WriteLiteral(@"         <i class=""fab fa-github""></i>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""https://facebook.com/"" target=""_blank"">
                            <i class=""fab fa-facebook""></i>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</footer>

</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
