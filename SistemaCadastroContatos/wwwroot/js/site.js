﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Script do Jquery DataTables
$(document).ready(function () {
    $('#table-contatos').DataTable();
});


$('.close-alert').click(function () {
    $('.alert').hide('hide');
})
