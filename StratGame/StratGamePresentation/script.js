function getMap() {
    $.ajax({
        type: "GET",
        url: "https://localhost:5001/api/game/getmap",
        cache: false,
        success: function (data) {
            //$("#value").text(data.tiles);
            $.each(data.tiles, function(key, item){
                let id = "#" + item.x + item.y;
                $(id).empty();
                if(item.unit !== null){
                    if(item.unit.name == "S1") $("<img src=\"src/images/soldier-sm.png\">").appendTo(id);
                    else $("<img src=\"src/images/soldier2-sm.png\">").appendTo(id);
                }
                else{
                    $("<img src=\"src/images/earth-tile-sm.jpg\">").appendTo(id);
                }
                
            })
        }
    });
}

$(document).ready(function () {
    $("#moveCommand").on('submit', function () {
        var id = $("#id").val();
        var x = $("#x").val();
        var y = $("#y").val();
        var command = { id: id, x: x, y: y };
        $.ajax({
            type: "POST",
            url: "https://localhost:5001/api/game/move",
            cache: false,
            contentType: "application/json",
            data: JSON.stringify(command),
            success: function (data) {
                getMap();
            }
        });
        return false;
    });

    getMap();
});