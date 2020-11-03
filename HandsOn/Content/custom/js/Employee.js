function GetEmployees() {

    var id = "";

    id = $("#search").val();

    $.get("/v1/HandsOn/Employees?id=" + id, {}, function (data) {
        var table = $("#table tbody");
        table.empty();
        $.each(data, function (idx, elem) {
            table.append("<tr><td>" + elem.Id + "</td><td>" + elem.Name + "</td>   <td>" + elem.RoleId + "</td> <td>" + elem.RoleName + "</td> <td>" + elem.RoleDescription + "</td> <td>" + elem.contractTypeName + "</td> <td>" + elem.AnnualSalary + "</td></tr>");
        });
    });
}
