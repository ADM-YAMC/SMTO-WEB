function fValidarTarjeta(numero) {
    return new Promise(resolve => {
        if (numero.match(/^4\d{3}-?\d{4}-?\d{4}-?\d{4}$/) || numero.match(/^5[1-5]\d{2}-?\d{4}-?\d{4}-?\d{4}$/)) {
            resolve(true)
        } else {
            resolve(false)
        }
    })
}