


    var loginAuth = (function () {
        var UserName ='admin'
        var Password ='admin'
        return {
            login: function (uName, pwd) {
                if (uName == UserName && Password == pwd) {
                    window.location.href = "pendingOrders.aspx";
                    return;
                }
                else {
                    //invlid login details
                    notie.alert(3, 'Invalid use name or password!', 3);
                    return;
                }
            }
        }
    })();

    $('#loginBtn').on('click', function () {
        var userName = $('#userName').val();
        var passWord = $('#password').val();
        if (!userName) {
            notie.alert(3, 'Please enter user name', 3);
            $('#userName').focus();
            return;
        }
        if (!passWord) {
            notie.alert(3, 'Please enter passsowrd', 3);
            $('#password').focus();
            return;
        }
         loginAuth.login(userName,passWord);
    });
