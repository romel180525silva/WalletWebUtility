﻿$(document).ready(function () {
    $('#sidebar').toggleClass("active");
    $('#sidebarOpen').click(function () {
        $('#sidebar').toggleClass("active");
        $('.overlay').addClass('active');
        $('.collapse.in').toggleClass('in');
        $('a[aria-expanded=true]').attr('aria-expanded', 'false');
    });
    $('#sidebarClose,.overlay').click(function () {
        $('#sidebar').toggleClass("active");
        $('.overlay').removeClass('active');
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
    $('#btnModalDlt').click(function () {
        $('#exampleModal').modal().show();
        $('#btnDeleteDevice').attr('disabled', true);
        $('.WalletNumber').text($('#btnModalDlt').val());

    });
    $('#txtDeleteDevice').on('input', function () {
        if ($(this).val() == $('#btnModalDlt').val()) {
            $('#btnDeleteDevice').attr('disabled', false);
            $('#btnDeleteDevice').val($('#btnModalDlt').val())
        } else {
            $('#btnDeleteDevice').attr('disabled', true);
        }
    });


});

