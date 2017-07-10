// <copyright file="ChequeController.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ZoombracoDemo.Logic.Controllers
{
    using System;
    using System.Web;
    using System.Web.Mvc;
    using Umbraco.Web.Models;
    using Umbraco.Web.Mvc;
    using Zoombraco.ComponentModel.Caching;
    using Zoombraco.Controllers;
    using ZoombracoDemo.Logic.Models;

    /// <summary>
    /// The Generic page controller
    /// </summary>
    [UmbracoOutputCache]
    public class ChequeController : SurfaceController
    {
        /// <summary>
        /// Display details of a cheque
        /// </summary>
        /// <param name="model">The cheque details</param>
        /// <returns>Return NestedCheque model contains data</returns>
        public ActionResult Index()
        {
            NestedCheque model = new NestedCheque();
            model.ChequeName = new HtmlString(this.Request.Params["cn"]);
            model.ChequeDate = Convert.ToDateTime(this.Request.Params["cd"]);
            model.ChequeAmount = decimal.Parse(this.Request.Params["ca"]);
            model.ChequePay = new HtmlString(this.Request.Params["cp"]);

            //return PartialView("~/Views/Partials/Shared/Nested/_NestedCheque.cshtml", model);
            return PartialView("~/Views/Cheque/Index.cshtml", model);
            //return this.View(model);
        }
    }
}