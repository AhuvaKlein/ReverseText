$(() => {

    $('#reverse-button').on('click', function () {

        const s = $('#textbox-original').val();
        console.log(s);

        $.get('/home/ReverseText', { text: s}, function (text) {

            $('#textbox-reversed').val(text);

        });

    });



})