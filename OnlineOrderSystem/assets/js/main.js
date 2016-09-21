


    var getPendingOrder = function () {
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


    var vieweMoreDetails = function (id) {
        
        $.ajax({
            type: "POST",
            data: JSON.stringify({ 'orderId': id}),
            contentType: "application/json",
            dataType: "json",
            url: 'services/pendingOredrService.asmx/GetCurrentPendingOrder',
            success: function (data) {
                var currentOrder = JSON.parse(data.d);
                if (currentOrder.length > 0) {
                    document.getElementById('orderId').innerHTML = currentOrder[0].customer[0].orderId;
                    document.getElementById('customerName').innerHTML = currentOrder[0].customer[0].customerName;;

                    for (var i = 0; i < currentOrder.length; i++) {
                        $('#OrderView_id').append("<tr><td>" + currentOrder[0].currentOrder[i].itemName +
                                "</td><td>" + currentOrder[0].currentOrder[i].itemCode +
                                "</td><td>" + +currentOrder[0].currentOrder[i].qty +
                                "</td><td>" + +currentOrder[0].currentOrder[i].unitPrice +
                                "</td><td>" + +currentOrder[0].currentOrder[i].value +
                                "</tr>");
                    }
                }
            },
            error: function (repo) {
                console.log("error" + repo);
            }
        });
    }


   