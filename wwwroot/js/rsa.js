"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (rsaResponse) {
    console.log(rsaResponse);
    document.getElementById("cipherText").value=rsaResponse.cipherText;
    document.getElementById("publicKey").value=rsaResponse.publicKey;
    document.getElementById("privateKey").value=rsaResponse.privateKey;
    document.getElementById("decryptedText").value=rsaResponse.decryptedText;

});
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var plainText = document.getElementById("plainText").value;
    connection.invoke("rSAGenerate",  plainText).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});