// "//-----------------------------------------------------------------------".
// <copyright file="ChartService.cs" company="">
// Copyright (c) All rights reserved.
// </copyright>
// "//-----------------------------------------------------------------------".

namespace ChartService
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Market I Entity
    /// </summary>
    [Table("marketI")]
    public partial class marketI
    {
        /// <summary>
        /// The primary key
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        /// <summary>
        /// The strategy/month
        /// </summary>
        [StringLength(20)]
        public string Strategy { get; set; }

        /// <summary>
        /// Point to be plotted on graph
        /// </summary>
        public int Point { get; set; }
    }
}
