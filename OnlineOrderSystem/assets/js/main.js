

    var getPendingOrder = function () {
        $.ajax({
            type: "POST",
            contentType: "application/json",
            dataType: "json",
            url: 'services/pendingOredrService.asmx/GetPendingOrder',
            success: function (data) {
                console.log(data.d);
            },
            error: function (repo) {
                console.log("error"+ repo);
            }
        });
    }

    getPendingOrder();


