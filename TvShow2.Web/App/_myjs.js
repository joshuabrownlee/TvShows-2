var masterAjax = function (method, url, callback, data) {
    var request = new XMLHttpRequest();
    request.open(method, url);
    request.onload = function () {
        if (this.status >= 200 && this.status < 400) {
            if(this.response != ""){
                callback(JSON.parse(this.response));
            } else {
                callback();
            }
        } else {
            console.log("error" + this.response);
        }       
    }
    request.onerror = function () {
    
        console.log("connection error");
    }
        if (data) {
            request.send(JSON.stringify(data));
        } else {
            request.send();
    }
}
var submitShow = function () {
    var title = document.getElementById("Title").value;
    var description = document.getElementById("Description").value;
    var obj = { Title: title, Description: description };
    masterAjax("POST", "/api/v1/TvShow", getShows, obj);
};
var getShows = function () {
    masterAjax("GET", "/api/v1/TvShow", function (data) {
        var renderString = "";
        data.forEach(function (show) {
            renderString += show.Title + "<br/>"; 
        })
        document.getElementById("Result").innerHTML = renderString;
    })

}
getShows();