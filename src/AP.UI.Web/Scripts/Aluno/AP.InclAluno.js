
$(document).ready(function () {
    $('#formCadastroAluno').submit(function (e) {
        e.preventDefault();
        $.ajax({
            url: Router.Action("Incluir","Aluno"),
            method: "POST",
            data: {
                "Nome": $(this).find("#Nome").val(),
                "Sobrenome": $(this).find("#Sobrenome").val(),
                "CPF": $(this).find("#CPF").val(),
                "Sexo": $(this).find("#Sexo").val(),
                "Email": $(this).find("#Email").val(),
                "RA": $(this).find("#RA").val(),
                "Telefone": $(this).find("#Telefone").val(),
            },
            error:
                function (r) {
                    if (r.status == 400)
                        $.Notification.notify('error', 'top center', 'Falha', 'Ocoreru um erro.');
                        //ModalDialog("Ocorreu um erro", r.responseJSON);
                    //else if (r.status == 500)
                    //    //ModalDialog("Ocorreu um erro", "Ocorreu um erro interno no servidor.");
                },
            success:
                function (r) {
                    $.Notification.notify('success', 'top center', 'Sucesso', 'Alterado com sucesso.');
                    //ModalDialog("Sucesso!", r)
                    //$("#formCadastro")[0].reset();
                }
        });
    })

})

//function ModalDialog(titulo, texto) {
//    var random = Math.random().toString().replace('.', '');
//    var texto = '<div id="' + random + '" class="modal fade">                                                               ' +
//        '        <div class="modal-dialog">                                                                                 ' +
//        '            <div class="modal-content">                                                                            ' +
//        '                <div class="modal-header">                                                                         ' +
//        '                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>         ' +
//        '                    <h4 class="modal-title">' + titulo + '</h4>                                                    ' +
//        '                </div>                                                                                             ' +
//        '                <div class="modal-body">                                                                           ' +
//        '                    <p>' + texto + '</p>                                                                           ' +
//        '                </div>                                                                                             ' +
//        '                <div class="modal-footer">                                                                         ' +
//        '                    <button type="button" class="btn btn-default" data-dismiss="modal">Fechar</button>             ' +
//        '                                                                                                                   ' +
//        '                </div>                                                                                             ' +
//        '            </div><!-- /.modal-content -->                                                                         ' +
//        '  </div><!-- /.modal-dialog -->                                                                                    ' +
//        '</div> <!-- /.modal -->                                                                                        ';

//    $('body').append(texto);
//    $('#' + random).modal('show');
//}