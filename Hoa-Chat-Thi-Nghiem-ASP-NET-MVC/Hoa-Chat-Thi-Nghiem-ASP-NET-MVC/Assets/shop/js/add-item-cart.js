function addItem(input) {
    $.post("/Cart/AddItem?idProduct=" + input) 
}

function deleteItem(input) {
    $.post("/Cart/RemoveItem?idProduct=" + input)
}