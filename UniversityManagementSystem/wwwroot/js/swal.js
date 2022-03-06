function functionConfirm(event) {
    swal({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        type: 'warning',
        showCancelButton: true,
        cancelButtonText: 'No',
        cancelButtonClass: 'btn btn-danger',
        showConfirmButton: true,
        confirmButtonText: 'Yes, delete it!',
        confirmButtonClass: 'btn btn-success'
    }, function (isConfirm) {
        if (isConfirm) {
            $('form').submit();
            return true;
        } else {
            return false;
        }
    });
    return false;
}