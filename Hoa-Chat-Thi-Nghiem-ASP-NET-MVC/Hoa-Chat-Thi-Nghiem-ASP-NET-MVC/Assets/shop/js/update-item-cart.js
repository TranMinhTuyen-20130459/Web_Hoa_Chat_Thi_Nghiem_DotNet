function addItem(idProduct) {
    $.post("/Cart/AddItem?idProduct=" + idProduct)
}

function addItems(idProduct, quantity, incremental) {
    console.log(incremental)
    $.post("/Cart/AddItem?idProduct=" + idProduct + "&quantity=" + quantity + "&incremental=" + incremental)
}

function minus(idProduct) {
    $.post("/Cart/MinusQuantity?idProduct=" + idProduct)
}

function deleteItem(input) {
    $.post("/Cart/RemoveItem?idProduct=" + input)
}