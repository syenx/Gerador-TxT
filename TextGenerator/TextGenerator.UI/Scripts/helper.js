$(document).ready(function () {
    $(".icon-input-btn").each(function () {
        var btnFont = $(this).find(".btn").css("font-size");
        var btnColor = $(this).find(".btn").css("color");
        $(this).find(".glyphicon").css("font-size", btnFont);
        $(this).find(".glyphicon").css("color", btnColor);
        if ($(this).find(".btn-xs").length) {
            $(this).find(".glyphicon").css("top", "24%");
        }
    });


    $(".datepicker").datepicker({
        format : 'dd/mm/yyyy'
    });
});


function Message(message, tipo) {
    
    var div = $("message");
    
    switch (tipo) {
        case "info":
            div.addClass("alert alert-info");
            break;
        case "erro":
            div.addClass("alert alert-error");
            break;
        case "aviso":
            div.addClass("alert alert-warning");
            break;
    }

    div.html(message);

    div.fadeIn(500);
}


//Aplicar o DataTable
function AplicarDataTable(nomeTabela) {

    //DataTable
    $("#" + nomeTabela).DataTable({

        "language": {
            "sEmptyTable": "Nenhum registro encontrado",
            "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando 0 até 0 de 0 registros",
            "sInfoFiltered": "(Filtrados de _MAX_ registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "_MENU_ resultados por página",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar",
            "oPaginate": {
                "sNext": "Próximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Último"
            },
            "oAria": {
                "sSortAscending": ": Ordenar colunas de forma ascendente",
                "sSortDescending": ": Ordenar colunas de forma descendente"
            }
        }
        , searching: false
    });

}
