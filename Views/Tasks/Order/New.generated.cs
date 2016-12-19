﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.WebsiteBuilder;
    using MixERP.Purchases;
    
    #line 1 "..\..\Views\Tasks\Order\New.cshtml"
    using MixERP.Purchases.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/Order/New.cshtml")]
    public partial class _Views_Tasks_Order_New_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_Order_New_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Tasks\Order\New.cshtml"
  
    ViewBag.Title = "Purchase";
    Layout = ViewBag.PurchaseLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 9 "..\..\Views\Tasks\Order\New.cshtml"
Write(Html.PartialView("Shared/ItemList.cshtml", TenantConvention.GetTenant()));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n<script>\r\n    function initializeUI() {\r\n        const template = `<div cla" +
"ss=\"one summary items\">\r\n                            <div class=\"terms item\">\r\n " +
"                               <div class=\"description\">Terms & Conditions</div>" +
"\r\n                                <div class=\"control\">\r\n                       " +
"             <textarea id=\"TermsTextArea\" type=\"text\"></textarea>\r\n             " +
"                   </div>\r\n                            </div>\r\n                 " +
"       </div>\r\n                        <div class=\"one summary items\">\r\n        " +
"                    <div class=\"terms item\">\r\n                                <d" +
"iv class=\"description\">Internal Memo</div>\r\n                                <div" +
" class=\"control\">\r\n                                    <textarea id=\"InternalMem" +
"oTextArea\" type=\"text\"></textarea>\r\n                                </div>\r\n    " +
"                        </div>\r\n                        </div>`;\r\n\r\n        $(\"." +
"page.title\").html(\"Purchase Order\");\r\n\r\n        const expectedDeliveryDate =\r\n  " +
"          $(\"<input type=\'text\' class=\'date\' value=\'7d\' id=\'ExpectedDeliveryDate" +
"InputText\' />\");\r\n        $(\"#BookDateInputDate\").after(expectedDeliveryDate).re" +
"move();\r\n        expectedDeliveryDate.parent().parent().find(\".description\").htm" +
"l(\"Expected Delivery Date\");\r\n\r\n        $(\"#StatementReferenceInputText\").closes" +
"t(\".two.summary.items\").attr(\"class\", \"one summary items\")\r\n            .after(t" +
"emplate);\r\n\r\n        $(\".memo.item\").remove();\r\n        $(\"#CostCenterSelect\").c" +
"losest(\".two.summary.items\").attr(\"class\", \"one summary items\");\r\n        $(\".co" +
"st.center.item\").remove();\r\n        $(\".store.item\").remove();\r\n\r\n        //wind" +
"ow.loadDatepicker();\r\n    };\r\n\r\n    initializeUI();\r\n\r\n    $(\"#CheckoutButton\")." +
"unbind(\"click\").bind(\"click\", function () {\r\n        function request(model) {\r\n" +
"            const url = \"/dashboard/purchase/tasks/order/new\";\r\n            cons" +
"t data = JSON.stringify(model);\r\n            return window.getAjaxRequest(url, \"" +
"POST\", data);\r\n        };\r\n\r\n        function getModel() {\r\n            function" +
" getDetails() {\r\n                const items = $(\"#PurchaseItems .item\");\r\n     " +
"           var model = [];\r\n\r\n                $.each(items, function () {\r\n     " +
"               const el = $(this);\r\n                    const itemId = parseInt(" +
"el.attr(\"data-item-id\"));\r\n                    const quantity = parseInt(el.find" +
"(\"input.quantity\").val());\r\n                    const unitId = parseInt(el.find(" +
"\"select.unit\").val());\r\n                    const price = parseFloat(el.find(\"in" +
"put.price\").val() || 0);\r\n                    const discount = parseFloat(el.fin" +
"d(\"input.discount\").val() || 0);\r\n                    const tax = window.parseFl" +
"oat(el.find(\".tax-amount\").html() || 0);\r\n\r\n                    model.push({\r\n  " +
"                      ValueDate: $(\"#ValueDateInputDate\").datepicker(\"getDate\")," +
"\r\n                        ItemId: itemId,\r\n                        Quantity: qua" +
"ntity,\r\n                        Tax: tax,\r\n                        UnitId: unitI" +
"d,\r\n                        Price: price,\r\n                        DiscountRate:" +
" discount\r\n                    });\r\n                });\r\n\r\n                retur" +
"n model;\r\n            };\r\n\r\n            const valueDate = $(\"#ValueDateInputDate" +
"\").datepicker(\"getDate\");\r\n            const expectedDeliveryDate = $(\"#Expected" +
"DeliveryDateInputText\").datepicker(\"getDate\");\r\n            const referenceNumbe" +
"r = $(\"#ReferenceNumberInputText\").val();\r\n            const terms = $(\"#TermsTe" +
"xtArea\").val();\r\n            const internalMemo = $(\"#InternalMemoTextArea\").val" +
"();\r\n            const supplierId = $(\"#SupplierSelect\").val();\r\n            con" +
"st priceTypeId = $(\"#PriceTypeSelect\").val();\r\n            const shipperId = $(\"" +
"#ShipperSelect\").val();\r\n            const details = getDetails();\r\n\r\n          " +
"  return {\r\n                ValueDate: valueDate,\r\n                ExpectedDeliv" +
"eryDate: expectedDeliveryDate,\r\n                ReferenceNumber: referenceNumber" +
",\r\n                Terms: terms,\r\n                InternalMemo: internalMemo,\r\n " +
"               SupplierId: supplierId,\r\n                PriceTypeId: priceTypeId" +
",\r\n                ShipperId: shipperId,\r\n                Details: details\r\n    " +
"        };\r\n        };\r\n\r\n        const model = getModel();\r\n\r\n        if (!mode" +
"l.Details.length) {\r\n            alert(\"Please select an item.\");\r\n            r" +
"eturn;\r\n        };\r\n\r\n        const confirmed = confirm(\"Are you sure\");\r\n\r\n    " +
"    if (!confirmed) {\r\n            return;\r\n        };\r\n\r\n\r\n        $(\"#Checkout" +
"Button\").addClass(\"loading\");\r\n\r\n        const ajax = request(model);\r\n\r\n       " +
" ajax.success(function (response) {\r\n            const id = response;\r\n         " +
"   document.location = `/dashboard/purchase/tasks/order/checklist/${id}`;\r\n     " +
"   });\r\n\r\n        ajax.fail(function (xhr) {\r\n            $(\"#CheckoutButton\").r" +
"emoveClass(\"loading\");\r\n            window.logAjaxErrorMessage(xhr);\r\n        })" +
";\r\n    });\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591