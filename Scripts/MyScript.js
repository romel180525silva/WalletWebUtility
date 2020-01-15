$(document).ready(function () {

    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
    });


    $('#drpsort').change(function () {

        var selectedDT = $(this).val();
        $.ajax({
            url: "/Wallet/IndexSort/",
            data: {
                PageSize: selectedDT
            },
            beforeSend: function (e) {
                //$("#loadingModalniIan").modal('show');
                noTransitionAnimation();
            }
        }).done(function (data) {
            $("#loadingModalniIan").modal('hide');
            $("#himohimoniIan").html(data);
        });

    });
    function loadingOut(loading) {
        setTimeout(() => loading.out(), 3000);
    }
    function noTransitionAnimation() {
        var loading = new Loading({
            direction: 'hor',
            discription: 'Loading....',
            animationIn: false,
            animationOut: false,
            defaultApply: true,
        });
        loadingOut(loading);
    }

});

