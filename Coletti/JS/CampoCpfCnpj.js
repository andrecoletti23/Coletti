//document.getElementById('cnpj').style.display = 'none';
//document.getElementById('razao').style.display = 'none';

//document.getElementById('cpf').style.display = 'none';
//document.getElementById('nome').style.display = 'none';

//function exibir_ocultar(val) {
//    if (val.value == 'pessoa_fisica') {
//        document.getElementById('cnpj').style.display = 'none';
//        document.getElementById('razao').style.display = 'none';
//        document.getElementById('cpf').style.display = 'block';
//        document.getElementById('nome').style.display = 'block';
//    }
//    else {
//        document.getElementById('cnpj').style.display = 'block';
//        document.getElementById('razao').style.display = 'block';
//        document.getElementById('cpf').style.display = 'none';
//        document.getElementById('nome').style.display = 'none';
//    }
    
//};
$("#campoJuridico").hide();
$("#campoFisico").hide();
$(function () { 
    var tipoPessoa = $("#tipo_pessoa option:selected").val();
    $("#tipo_pessoa").on("change", function () {
        console.log($(this).val());
        if ($(this).val() == "pessoa_fisica") {
            $("#campoJuridico").hide();
            $("#campoFisico").show();
        } else if ($(this).val() == "pessoa_juridica") {
            $("#campoFisico").hide();
            $("#campoJuridico").show();
        }
    });
});