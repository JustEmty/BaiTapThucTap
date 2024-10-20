function PrintForm() {
    $(".hideWhenPrint").hide();
    window.print();
    $(".hideWhenPrint").show();
}