// <copyright file="NestedCheque.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ZoombracoDemo.Logic.Models
{
    using System;
    using System.Web;
    using Zoombraco.Models;

    /// <summary>
    /// A nested video container. Youtube and Vimeo just now for brevity
    /// </summary>
    public class NestedCheque : NestedComponent
    {
        /// <summary>
        /// Gets or sets the cheque name
        /// </summary>
        public virtual HtmlString ChequeName { get; set; }

        /// <summary>
        /// Gets or sets the cheque date
        /// </summary>
        public virtual DateTime ChequeDate { get; set; }

        /// <summary>
        /// Gets or sets the cheque amount
        /// </summary>
        public virtual decimal ChequeAmount { get; set; }

        /// <summary>
        /// Gets or sets the cheque amount
        /// </summary>
        public virtual HtmlString ChequePay { get; set; }
    }
}