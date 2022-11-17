$(document).ready(function () {

});

function GetAllStudents() {
    $.getJSON("/Students/GetAllStudents", function (students) {
        $("#tblStudent tbody tr").remove();
        $.map(students, function (student) {
            var qr = "<tr><td>" + student.ID + "</td><td>" + student.Name + "</td><td>" + student.RollNo + "</td><td>" 
                + "   <button class='btn-success' onclick='Edit(" + student.StudentId + ")' style='margin'>Edit</button>  "
                + "   <button class='btn-danger' onclick='Delete(" + student.StudentId + ")' >Delete</button>"+" </tr > ";
            $("#tblStudent tbody").append(qr);
        });
    });
}


function AddStudent() {
    var _student = {
        Id: $("#txtStudentId").val(),
        Name: $("#txtStudentName").val(),
        RollNo: $("#txtStudentRoll").val()
    };

    $.post("/Students/AddUpdateStudent", _student)
        .done(function (data) {
            GetAllStudents
        });
}

function Edit(studentId) {
    if (StudentId > 0) {
        $.getJSON("/Students/GetById?studentId=" + StudentId, function (student) {
            $("#txtStudentId").val(student.StudentId);
            $("#txtStudentName").val(student.Name);
            $("#txtStudent Roll").val(student.RollNo);
        });
    }
}

function Delete(studentId) {
    if (Id > 0) {
        $.ajax({
            url: '/Students/Delete?Id=' + StudentId,
            type: 'DELETE',
            dataType: 'json',
            success: function (data) {
            }
                error: function (ex) {
                console.log('Error in Operation');
            }
        });
    }
}