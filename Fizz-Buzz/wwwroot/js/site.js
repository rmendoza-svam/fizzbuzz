$(document).ready(function () {
    $("#AddValue").click(function () {
        let currentIndex = parseInt($("#rowCounter").val());
        $("#rowCounter").val(currentIndex + 1);
        var newRow = "<tr><td><input name='inputValue' id='inputValue" +
            "' data-value='' value = '' ></td></tr >";
        $('#tblProducts tbody').append(newRow);
    });

    function getModel() {
        let data = [];
        for (index = 0; index <= parseInt($("#rowCounter").val()); index++) {
            let inputId = "#inputValue-" + index;
            data.push($(inputId).val());
        }
        return data;
    }
});