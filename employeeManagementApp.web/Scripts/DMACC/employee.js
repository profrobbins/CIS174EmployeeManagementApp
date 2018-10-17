function searchEmployee() {
    var search = $("#searchString").val();
    $.ajax({
        url: "Search",
        data: { searchString: search }
    }).done(function (data) {
        $("#FirstName").val(data.FirstName);
        $("#MiddleName").val(data.MiddleName);
        $("#LastName").val(data.LastName);
        $("#BirthDate").val(data.Birthdate);
        $("#HireDate").val(data.HireDate);
        $("#Department").val(data.Department);
        $("#JobTitle").val(data.JobTitle);
        $("#Salary").val(data.Salary);
        $("#EmployeeId").val(data.EmployeeId);
        $("#AvailableHrs").val(data.AvailableHrs);
    });
}

function updateEmployee() {
    var firstName = $("#FirstName").val();
    var middleName = $("#MiddleName").val();
    var lastName = $("#LastName").val();
    var birthDate = $("#BirthDate").val();
    var hireDate = $("#HireDate").val();
    var department = $("#Department").val();
    var jobTitle = $("#JobTitle").val();
    var salary = $("#Salary").val();
    var employeeId = $("#EmployeeId").val();
    var availableHrs = $("#AvailableHrs").val();

    //window.alert(firstName + "," + middleName + "," + lastName + "," + birthDate);
    $.ajax({
        url: "UpdateEmployee",
        dataType: "Json",
        data: {
            FirstName: firstName,
            MiddleName: middleName,
            LastName: lastName,
            BirthDate: birthDate,
            HireDate: hireDate,
            Department: department,
            JobTitle: jobTitle,
            Salary: salary,
            EmployeeId: employeeId,
            AvailableHrs: availableHrs
        }
    }).done(function(data) {
        if (data) {
            $("#successMessage").removeClass("hidden")
                .addClass("visible");
        } else {
            $("#errorMessage").removeClass("hidden")
                .addClass("visible");
        }
    });
}

 