(function () {
    'use strict';

    // Show/Hide password
    $(function () {
        $('.click-eye').click(function () {
            $(this).toggleClass('bx-show bx-hide')
            var input = $($(this).attr('toggle'))
            if (input.attr('type') == 'password')
                input.attr('type', 'text')
            else
                input.attr('type', 'password')
        });
    })

    function validateFormLogin() {

        var x = document.forms["form-login"]["username"].value;
        var y = document.forms["form-login"]["password"].value;
        if (x == "" || y == "") {
            alert("Hay nhap day du thong tin ^.^");
            return false;
        }

    }