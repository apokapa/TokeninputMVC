function GetPrepopulate() {

    var url = "/Home/GetPrepopulate/";
    var jsonArray = [];
    var _selected = document.getElementById("tokenbox").value;

    $.ajax({
        url: url,
        data: { selected: _selected },
        cache: false,
        type: "POST",
        success: function (data) {
            jsonArray = data;
            if (data[0] != null) {
                for (var x = 0; x < data.length; x++) {
                    $("#tokenbox").tokenInput("add", { id: data[x].id, name: data[x].name });
                }
            }
        },
        error: function (reponse) {
            alert("error : " + reponse);
        }
    });

}
