﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.Views.Shared.EditorTemplates
{
    using Common;
    using Common.Helpers;
    using Common.HtmlHelpers;
    using Common.Services;
    using ExigoService;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EditorTemplates/TaxID.cshtml")]
    public partial class _TaxID : System.Web.Mvc.WebViewPage<String>
    {
        public _TaxID()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\EditorTemplates\TaxID.cshtml"
  
    Layout = "~/Views/Shared/EditorTemplates/_FormField.cshtml";

    var htmlAttributes = Html.GetEditorHtmlAttributes(new
    {
        data_restrict_input = "taxid"
    });

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n    <span");

WriteLiteral(" class=\"input-group-addon\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa-question-circle\"");

WriteLiteral(" data-toggle=\"popover\"");

WriteLiteral(" data-container=\"body\"");

WriteLiteral(" data-title=\"Why do we need this?\"");

WriteLiteral(" data-trigger=\"hover\"");

WriteLiteral(" data-placement=\"top\"");

WriteLiteral(" data-content=\"In order to be paid commissions, you must provide your SSN/Tax ID." +
"\"");

WriteLiteral("></i></span>\r\n");

WriteLiteral("    ");

            
            #line 13 "..\..\Views\Shared\EditorTemplates\TaxID.cshtml"
Write(Html.EditorFor(c => c, htmlAttributes));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n<script>$(\"#");

            
            #line 16 "..\..\Views\Shared\EditorTemplates\TaxID.cshtml"
        Write(Html.IdFor(c => c));

            
            #line default
            #line hidden
WriteLiteral("\").popover();</script>\r\n");

        }
    }
}
#pragma warning restore 1591
