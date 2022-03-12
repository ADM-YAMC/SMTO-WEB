function Session() {
    return sessionStorage.getItem("usuario")
}
function storage(dato) {
    sessionStorage.setItem(`usuario`, JSON.stringify(dato));
}