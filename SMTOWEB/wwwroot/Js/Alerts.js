
function success() {
    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 5000,
        timerProgressBar: true,
        didOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer)
            toast.addEventListener('mouseleave', Swal.resumeTimer)
        }
    })

    Toast.fire({
        icon: 'success',
        title: 'El usuario se registro con exito!!!'
    })
}

function successDeleted(mensaje) {
    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 5000,
        timerProgressBar: true,
        didOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer)
            toast.addEventListener('mouseleave', Swal.resumeTimer)
        }
    })

    Toast.fire({
        icon: 'success',
        title: mensaje
    })
}

function error() {
    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 5000,
        timerProgressBar: true,
        didOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer)
            toast.addEventListener('mouseleave', Swal.resumeTimer)
        }
    })

    Toast.fire({
        icon: 'error',
        title: 'El usuario ya existe...'
    })
}

function errorNotFound() {
    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 10000,
        timerProgressBar: true,
        didOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer)
            toast.addEventListener('mouseleave', Swal.resumeTimer)
        }
    })

    Toast.fire({
        icon: 'error',
        title: 'Lo sentimos, no podemos conectar con los servicios... Revivce su conexion.'
    })
}

function AlertLoginforms(mensaje, alerta) {
    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 10000,
        timerProgressBar: true,
        didOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer)
            toast.addEventListener('mouseleave', Swal.resumeTimer)
        }
    })
    

    Toast.fire({
        icon: alerta,
        title: mensaje
    })
}

function myfunction(mensaje) {
    console.log(mensaje);
}

function RecargaSuccess() {
    Swal.fire({
        title: '¡Exito!',
        text: 'La recarga se a depositado con exito...',
        icon: 'success',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
    }).then((result) => {
        if (result.isConfirmed) {
            
        }
    })
}

function DismmissModal(modal) {
    $(modal).modal('hide');
    confirm("Hola mundo")
}
export function CloseModal(modalId) {
    $(modalId).modal('hide');
}