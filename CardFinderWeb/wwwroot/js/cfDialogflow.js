



const dfMessenger = document.querySelector('df-messenger');
dfMessenger.addEventListener('df-chip-clicked', function (event) {
    chrome.debugger.attach(event.currentTarget, "1.2", function () {
        chrome.debugger.sendCommand(event.currentTarget, "df-messenger.DfChipClickedEvent", arguments)
    })
    text = "test"
    console.log( event.currentTarget + JSON.stringify(event));
    $.ajax({
        type: "POST",
        url: 'https://localhost:44308/api',
        data: { data: text },
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            console.log(msg);
        },
        error: function (e) {
            console.log(e,e.responseText);
        }
    });
});