/// <reference path="scripts/typings/jquery/jquery.d.ts" />
var area = (function () {
    function area() {
    }
    return area;
}());
var Greeter = (function () {
    function Greeter(element) {
        this.element = element;
        this.element.innerHTML += "The time is: ";
        this.span = document.createElement('span');
        this.element.appendChild(this.span);
        this.span.innerText = new Date().toUTCString();
    }
    Greeter.prototype.start = function () {
        this.readApi();
    };
    Greeter.prototype.stop = function () {
        clearTimeout(this.timerToken);
    };
    Greeter.prototype.readApi = function () {
        var a = new area();
        a.minx = 0;
        a.miny = 1;
        a.maxx = 2;
        a.maxy = 3;
        $.get("http://localhost:52080/api/vehicles", a, function (e) { alert(JSON.stringify(e)); });
    };
    return Greeter;
}());
window.onload = function () {
    var el = document.getElementById('content');
    var greeter = new Greeter(el);
    greeter.start();
};
//# sourceMappingURL=app.js.map