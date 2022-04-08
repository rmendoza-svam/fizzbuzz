// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $("#AddValue").click(function () {
        let currentIndex = parseInt($("#rowCounter").val());
        $("#rowCounter").val(currentIndex + 1);
        var newRow = "<tr><td><input name='inputValue' id='inputValue" +
            "' data-value='' value = '' ></td></tr >";
        $('#tblProducts tbody').append(newRow);
    });
    $("#Submit").click(function () {
        //$("#tblProducts tbody tr").remove();

        //let data = getModel();
        //$.ajax({

        //    type: 'POST',

        //    url: 'FizzBuzz/Calculate',
        //    dataType: 'json',
        //    data: { data: data },
        //    success: function () {
        //        //window.location.href = "/FizzBuzz/Result";
        //    },
        //    error: function (ex) {
        //        var r = jQuery.parseJSON(response.responseText);
        //        alert("Message: " + r.Message);
        //        alert("StackTrace: " + r.StackTrace);
        //        alert("ExceptionType: " + r.ExceptionType);
        //    }
        //});
        return true;
    })

    function getModel() {
        let data = [];
        for (index = 0; index <= parseInt($("#rowCounter").val()); index++) {
            let inputId = "#inputValue-" + index;
            data.push($(inputId).val());
        }
        return data;//{ data: data, dataResult: [,] };
    }
});