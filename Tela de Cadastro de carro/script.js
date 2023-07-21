$(document).ready(function(){ 

//Quando clicar no botão  Adcionar 
$('#btnAdicionar').click(function(){

    //validação dos campos 
    var erro = '';

    if($('#txtMarca').val().trim() == ''){
        erro += '- Marca \n';
    }
    if($('#txtModelo').val().trim() == ''){
        erro += '- Modelo \n';
    }
    if($('#txtAno').val().trim() == ''){
        erro += '- Ano \n';
    }
    if($('#txtValor').val().trim() == ''){
        erro += '- Valor \n';
    }
    if($('#txtKmLitro').val().trim() == ''){
        erro += '- Km por Litro \n';
    }

    if(erro != ''){
        alert('Os campos abaixo são obrigatórios:\n\n' + erro)
    }

    else
    {
    //criar um objeto carro
    var carro = new Object();
    carro.marca = $('#txtMarcar').val();
    carro.modelo = $('#txtModelo').val();
    carro.ano = $('#txtAno').val();
    carro.valor = $('#txtValor').val();
    carro.kmPorLitro = $('#txtKmLitro').val();

    console.log(carro);

    //criando a nova linha da tabela 
    var linha = '';
    linha += '<tr>';
    linha += '<td>' + carro.marca + '</td>';
    linha += '<td>' + carro.modelo + '</td>';
    linha += '<td>' + carro.ano + '</td>';
    linha += '<td>' + carro.valor + '</td>';
    linha += '<td>' + carro.KmPorLitro + '</td>';
    linha += '</td>';

    //adcionar a nova linha na tabela
    $('#tabelaDeCarros tbody').append(linha);
    }

    //limpar os campos
    $('#txtMarca').val('');
    $('#txtModelo').val('');
    $('#txtAno').val('');
    $('#txtValor').val('');
    $('#txtKmLitro').val('');

    //colocando o cursor no campo Marca
    $('#txtMarca').focus();

})

});