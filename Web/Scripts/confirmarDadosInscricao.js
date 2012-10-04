$(document).ready(function () {
    // Confirmar Dados
    $('#confirmarDados').dialog({
        autoOpen: false,
        width: 500,
        modal: true,
        resizable: false,
        buttons: {
            "Submit": function () {
                $(".ui-dialog-buttonpane button:contains('Submit')").button("disable");
                $(".ui-dialog-buttonpane button:contains('Edit')").button("disable");
                document.formularioInscricao.submit();
            },
            "Edit": function () {
                $(this).dialog("close");
            }
        }
    });

    $('#formularioInscricao').submit(function (e) {
        e.preventDefault();

        // Valida campo com MVC validation.
        if ($(this).valid()) {
            var field;
            var confirmDiv;

            field = $("#tipoInsccricao");
            confirmDiv = $("#confirmaTipoInscricao");
            confirmDiv.html(field.val());

            field = $("#nome");
            confirmDiv = $("#confirmaNome");
            confirmDiv.html(field.val());

            field = $("#instituicao");
            confirmDiv = $("#confirmaInstituição");
            confirmDiv.html(field.val());

            field = $("#email");
            confirmDiv = $("#confirmaEmail");
            confirmDiv.html(field.val());

            field = $("#telefone");
            confirmDiv = $("#confirmaTelefone");
            confirmDiv.html(field.val());

            field = $("#curso");
            confirmDiv = $("#confirmaCurso");
            confirmDiv.html(field.val());

            $('#confirmarDados').dialog('open');
        }
    });
});