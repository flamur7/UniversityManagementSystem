function showInPopup(url, title) {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#Popup-modal .modal-body").html(res);
            $("#Popup-modal .modal-title").html(title);
            $("#Popup-modal ").modal('show');
        }
    });
}

function getProduct(url, title, prodId) {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#Popup-modal .modal-body").html(res);
            $("#Popup-modal .modal-title").html(title);
            $("#Popup-modal ").modal('show');
        }
    });
}


function jQuaryAjaxPost(form) {

    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $("#view-all").html(res.html);
                    $("#Popup-modal .modal-body").html('');
                    $("#Popup-modal .modal-title").html('');
                    $("#Popup-modal ").modal('hide');

                }
                else {
                    $("#Popup-modal .modal-body").html(res.html);
                }
            },
            error: function (err) {
                console.log(err);
            }

        });

    } catch (e) {
        console.log(e);
    }



    //to prevent default form submit event
    return false
}