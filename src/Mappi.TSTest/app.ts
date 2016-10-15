/// <reference path="scripts/typings/jquery/jquery.d.ts" />

class area {
    minx: number;
    miny: number;
    maxx: number;
    maxy: number;
}

class Greeter {
    element: HTMLElement;
    span: HTMLElement;
    timerToken: number;

    constructor(element: HTMLElement) {
        this.element = element;
        this.element.innerHTML += "The time is: ";
        this.span = document.createElement('span');
        this.element.appendChild(this.span);
        this.span.innerText = new Date().toUTCString();
    }

    start() {
        this.readApi();
    }

    stop() {
        clearTimeout(this.timerToken);
    }

    readApi() {
        var a = new area();
        a.minx = 0;
        a.miny = 1;
        a.maxx = 2;
        a.maxy = 3;
        $.get(
            "http://localhost:52080/api/vehicles",
            a,
            e => { alert(JSON.stringify( e)); }
        );
    }

}

window.onload = () => {
    var el = document.getElementById('content');
    var greeter = new Greeter(el);
    greeter.start();
};