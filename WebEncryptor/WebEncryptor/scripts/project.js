﻿$(document).ready(function () {
    $(function () {
        $("#btnEncrypt").click(
            function () {
            var msg = $("#message").val();
            if (msg == "") {
                alert("Введите сообщение");
                return;
            }
            var message = { msg: msg };
            $.post("/Home/Index", message, onAjaxSuccess);
            }

        );
    }

    );
});
function onAjaxSuccess(data) {
    $("#TextArea1").val($("#TextArea1").val() + data)
}