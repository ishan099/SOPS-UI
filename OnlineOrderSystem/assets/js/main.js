


var getPendingOrder = function () {

     $('#table_id').html("");
        $.ajax({
            type: "POST",
            contentType: "application/json",
            dataType: "json",
            url: 'services/pendingOredrService.asmx/GetPendingOrder',
            success: function (data) {
                var order = JSON.parse(data.d);
                for (var i = 0; i < order.length; i++) {
                    $('#table_id').append("<tr><td>" + order[i].orderId +
                        "</td><td>" + order[i].customerName +
                        "</td><td>" + order[i].receivedDate +
                        "</td></td><td><button type='button'  data-toggle='modal' data-target='#myModal'" +
                        "onClick='vieweMoreDetails(" + order[i].orderId + ")' class='btn btn-info'>" +
                       " View Order</button></td></tr>");
                }
            },
            error: function (repo) {
                console.log("error"+ repo);
            }
        });
    }

getPendingOrder();

var getProcessingOrder = function () {

    $('#tablePro_id').html("");
    $.ajax({
        type: "POST",
        contentType: "application/json",
        dataType: "json",
        url: 'services/pendingOredrService.asmx/GetProcessingOrder',
        success: function (data) {
            var order = JSON.parse(data.d);
            for (var i = 0; i < order.length; i++) {
                $('#tablePro_id').append("<tr><td>" + order[i].orderId +
                    "</td><td>" + order[i].customerName +
                    "</td><td>" + order[i].receivedDate +
                    "</td></td><td><button type='button'  data-toggle='modal'" +
                    "onClick='updateOrder(" + order[i].orderId + ",3)' class='btn btn-warning'>" +
                   " Order Complete</button></td></tr>");
            }
        },
        error: function (repo) {
            console.log("error" + repo);
        }
    });
}
getProcessingOrder();


var getCompleteOrder = function () {

    $('#tableComplete_id').html("");
    $.ajax({
        type: "POST",
        contentType: "application/json",
        dataType: "json",
        url: 'services/pendingOredrService.asmx/GetCompeleteOrder',
        success: function (data) {
            var order = JSON.parse(data.d);
            for (var i = 0; i < order.length; i++) {
                $('#tableComplete_id').append("<tr><td>" + order[i].orderId +
                    "</td><td>" + order[i].customerName +
                    "</td><td>" + order[i].receivedDate +
                    "</td></td><td><button type='button'  data-toggle='modal'" +
                    " class='btn btn-success  disabled'>" +
                   " Complete</button></td></tr>");
            }
        },
        error: function (repo) {
            console.log("error" + repo);
        }
    });
}
getCompleteOrder();


    var vieweMoreDetails = function (id) {
        
        $.ajax({
            type: "POST",
            data: JSON.stringify({ 'orderId': id}),
            contentType: "application/json",
            dataType: "json",
            url: 'services/pendingOredrService.asmx/GetCurrentPendingOrder',
            success: function (data) {
                var currentOrder = JSON.parse(data.d);
                $('#OrderView_id').html("");
                $('#total').html("");
                var total = parseInt("0");
                if (currentOrder.length > 0) {
                    document.getElementById('orderId').innerHTML = currentOrder[0].customer[0].orderId;
                    document.getElementById('customerName').innerHTML = currentOrder[0].customer[0].customerName;
                   
                    for (var i = 0; i < currentOrder[0].currentOrder.length; i++) {
                        total = total + parseInt(currentOrder[0].currentOrder[i].value)
                        $('#OrderView_id').append("<tr><td>" + currentOrder[0].currentOrder[i].itemName +
                                "</td><td>" + currentOrder[0].currentOrder[i].itemCode +
                                "</td><td>" + +currentOrder[0].currentOrder[i].qty +
                                "</td><td>" + +currentOrder[0].currentOrder[i].unitPrice +
                                "</td><td>" + +currentOrder[0].currentOrder[i].value +
                                "</tr>");
                    }
                    document.getElementById('total').innerHTML = total = null ? "Total Rs : 0" : "Total Rs : " + total;
                }
            },
            error: function (repo) {
                console.log("error" + repo);
            }
        });
    }

    var updateOrder = function (orderId, status) {
        var orderId = orderId;
        var status = status;
        if (orderId == null || orderId == "") {
            var orderId = document.getElementById('orderId').innerHTML;
            var status = 2;
        }
       
        $.ajax({
            type: "POST",
            data: JSON.stringify({ 'orderId': orderId, 'status': status }),
            contentType: "application/json",
            dataType: "json",
            url: 'services/pendingOredrService.asmx/UpdateOrderStatus',
            success: function (data) {
                if (data.d) {
                    getPendingOrder();
                    getProcessingOrder();
                    $('#myModal').modal('toggle');
                }
            },
            error: function (repo) {
                console.log("error" + repo);
            }
        });
    }


   