function addRowDT(data) {
    var table = $("#tbl_pacientes").DataTable();
    for (var i = 0; i < data.length; i++) {
        table.fnAddData([
            data.codigo,
            data.nomes,
            data.sobrenomes,
            data.sexo,
            data.idade,
            data.endereco,
            data.estado
        ]);
    }
}
function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "GestionarPaciente.aspx/ListarPaciente",
        data: {},
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, throwError) {
            console.log(xhr.status + "\n" + xhr.responseText, "\n" + throwError);
        },
        success: function (data) {
            console.log(data);
            //addRowDT(data)
        }
    });
}
//chamar a funçao de ajax ao carregar o documento