function addItems(idProduct, incremental) {
    const quantity = document.getElementsByTagName('input')[2].value;
    console.log(quantity);
    $.post("/Cart/AddItems?idProduct=" + idProduct + "&quantity=" + quantity + "&incremental=" + incremental);
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