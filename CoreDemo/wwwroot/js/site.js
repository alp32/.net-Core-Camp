// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(".form").submit(function (e) {
    e.preventDefault(); // avoid to execute the actual submit of the form.

    var form = $(this);
    var url = form.attr('action');

    $.ajax({
        type: "POST",
        url: url,
        data: form.serialize(), // serializes the form's elements.
        success: function (result) {

            console.log(result);

            if (result.success) {
                swal({
                    title: "Bilgi",
                    text: "Kayıt Başarılı",
                    icon: "success",
                    button: "Tamam",
                });





            }
            else {
                swal({
                    title: "Uyarı",
                    text: result.message,
                    icon: "error",
                    button: "Tamam",
                });
            }

        },
        error: function () {
            swal({
                title: "Uyarı",
                text: "saaa",
                icon: "error",
                button: "Tamam",
            });
        }
    });
});