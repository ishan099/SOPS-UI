﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DAO;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using Newtonsoft.Json;


namespace OnlineOrderSystem.services
{
    /// <summary>
    /// Summary description for pendingOredrService
    /// </summary>
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    [System.Web.Script.Services.ScriptService]
    public class pendingOredrService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetPendingOrder()
        {
            List<OrderSummary> _lstPendingLst = new List<OrderSummary>();
            PendingOrder _pendingOrder = new PendingOrder();
            _lstPendingLst = _pendingOrder.GetAllPendingOrder();
            var jsonss = Newtonsoft.Json.JsonConvert.SerializeObject(_lstPendingLst);
            return jsonss;
        }


        //{ parameter orderId = 0}
        //get current pending order
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetCurrentPendingOrder(string orderId)
        {
            List<CurrentOrderDetails> _lstCurrentOrderLst = new List<CurrentOrderDetails>();
            PendingOrder _pendingOrder = new PendingOrder();
            _lstCurrentOrderLst = _pendingOrder.GetCurrentPendingOrder(orderId);
            var jsonss = Newtonsoft.Json.JsonConvert.SerializeObject(_lstCurrentOrderLst);
            return jsonss;
        }
    }
}
