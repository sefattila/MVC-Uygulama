function GetList() {
    $.ajax({
        url: "/Person/GetPeople",
        method: "get",
        success: function (response) {
            $("#list").html(response);
            $("#create").html("");
            $("#update").html("");
            $("#error").html("");
        },
        error: function () {
            $("#error").html("Bir hata oluştu");
        }
    });
}

function GetCreatePage() {
    $.ajax({
        url: "/Person/Create",
        method: "get",
        success: function (response) {
            $("#create").html(response);
            $("#list").html("");
            $("#update").html("");
            $("#error").html("");
        },
        error: function () {
            $("#error").html("Bir Hata Oluştu(Ekleme)");
        }
    });
}

function CreatePerson() {
    //var firstName = $("#createFirstName").val();
    //var lastName = $("#createLastName").val();
    //var birthDate = $("#createBirthDate").val();
    //var computerCounts = $("#createComputerCounts").val();
    var person = {
        firstName: $("#createFirstName").val(),
        lastName: $("#createLastName").val(),
        birthDate: $("#createBirthDate").val(),
        computerCounts: $("#createComputerCounts").val()
    };
    $.ajax({
        url: "Person/Create",
        method: "post",
        data: person,
        success: function (response) {
            if (response == "ok") {
                GetList();
            }
            else {
                $("#error").html("Kayıt işlemi sırasında hata oluştu");
            }
        }
    });
}

function GetUpdatePage(id) {
    $.ajax({
        url: "Person/Update/" + id,
        method:"get",
        success: function (response) {
            $("#update").html(response);
            $("#error").html("Hata(Güncelleme Sayfası)");
        }
    });
}

function UpdatePerson(sid) {
    var person = {
        id:sid,
        firstName: $("#updateFirstName").val(),
        lastName: $("#updateLastName").val(),
        birthDate: $("#updateBirthDate").val(),
        computerCounts: $("#updateComputerCounts").val(),
    };
    $.ajax({
        url: "Person/Update",
        method: "post",
        data: person,
        success: function (response) {
            if (response == "ok") {
                GetList();
            }
            else {
                $("error").html("Güncelleme işleminde hata oluştu");
            }
        }
    });
}