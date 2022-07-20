ymaps.ready(function () {
    var myMap = new ymaps.Map('map', {
        center: [55.753994, 37.622093],
        zoom: 9,
        controls: ['routePanelControl']
    });

    var control = myMap.controls.get('routePanelControl');

    control.routePanel.state.set({
        type: 'auto',
        from: getCookie('from'),
        to: getCookie('to'),
    });

    $('#findRoute').bind('click', function(e) {
        setCookie('from', $('#from').val(), 7);
        setCookie('to', $('#to').val(), 7);
    });

    function getCookie(name) {
        var nameEQ = name + "=";
        var ca = document.cookie.split(';');
        for(var i=0;i < ca.length;i++) {
            var c = ca[i];
            while (c.charAt(0)==' ') c = c.substring(1,c.length);
            if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length,c.length);
        }
        
        return null;
        
    }

      function setCookie(name,value,days) {
        var expires = "";
        if (days) {
            var date = new Date();
            date.setTime(date.getTime() + (days*24*60*60*1000));
            expires = "; expires=" + date.toUTCString();
        }
        document.cookie = name + "=" + (value || "")  + expires + "; path=/";
    }
});