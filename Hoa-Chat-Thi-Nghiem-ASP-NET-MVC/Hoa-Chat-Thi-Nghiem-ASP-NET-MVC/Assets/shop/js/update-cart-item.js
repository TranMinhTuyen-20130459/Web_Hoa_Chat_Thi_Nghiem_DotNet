function addItems(idProduct, incremental) {
    var quantity = getQuantity();
    $.post("/Cart/AddItem?idProduct=" + idProduct + "&quantity=" + quantity + "&incremental=" + incremental);
}

function addItem(idProduct) {
    $.post("/Cart/AddItem?idProduct=" + idProduct);
}

function minus(idProduct) {
    $.post("/Cart/MinusQuantity?idProduct=" + idProduct);
}

function deleteItem(input) {
    $.post("/Cart/RemoveItem?idProduct=" + input);
}

function getQuantity() {
    var quantity = document.getElementsByTagName('input')[2].value;
    console.log(quantity);
}