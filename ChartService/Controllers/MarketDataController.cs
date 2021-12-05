// "//-----------------------------------------------------------------------".
// <copyright file="ChartService.cs" company="">
// Copyright (c) All rights reserved.
// </copyright>
// "//-----------------------------------------------------------------------".

using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ChartService.Controllers
{
    /// <summary>
    /// The Market data controller
    /// </summary>
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class MarketDataController : ApiController
    {
        //Entity Framework dbcontext object.
        private MarketIEF db = new MarketIEF();

        // GET: api/MarketData
        public IQueryable<marketI> GetmarketIs()
        {
            return db.marketIs;
        }
    }
}