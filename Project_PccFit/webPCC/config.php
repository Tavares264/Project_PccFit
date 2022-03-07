<?php
    $dbHost = 'Localhost';
    $dbUsername = 'root';
    $dbPassword = '@Flp1517';
    $dbName = 'pcc_fit';

    $Conexao = new mysqli($dbHost,$dbUsername,$dbPassword,$dbName);

    if($Conexao->connect_errno)
    {
        echo "Erro";
    }
    else
    {
        echo "conexao realizada com sucesso";
    }
?>