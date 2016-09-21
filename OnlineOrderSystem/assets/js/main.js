

    var getPendingOrder = function () {
        $.ajax({
            type: "POST",
            contentType: "application/json",
            dataType: "json",
            url: 'services/pendingOredrService.asmx/GetPendingOrder',
            success: function (data) {
                console.log(data.d);
                var order = JSON.parse(data.d);
                for (var i = 0; i < order.length; i++) {
                    $('#table_id').append("<tr><td>" + order[i].orderId +
                        "</td><td>" + order[i].customerName +
                        "</td><td>" + order[i].receivedDate +
                        "</td></td><td><button type='button' data-toggle='modal' data-target='#myModal' onClick='vieweMoreDetails(" + order[i].orderId + ")' class='btn btn-info'>" +
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
        
    }