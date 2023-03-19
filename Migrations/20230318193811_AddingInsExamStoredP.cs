using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddingInsExamStoredP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Course__C92D7187959CD6B2", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Departme__B2079BED57225AF8", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "getInstructorExams",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    Mark = table.Column<int>(type: "int", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CourseToic",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    TopicName = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CourseTo__022E0F5D1A05C68B", x => x.TopicId);
                    table.ForeignKey(
                        name: "FK__CourseToi__Cours__1DB06A4F",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseID");
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    ExamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<int>(type: "int", nullable: true),
                    CourseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Exam__297521A768A21B7C", x => x.ExamID);
                    table.ForeignKey(
                        name: "FK__Exam__CourseID__3E52440B",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelAnswer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CourseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Question__0DC06FAC1E318558", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Question_Course",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID");
                });

            migrationBuilder.CreateTable(
                name: "DepartmentCourses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DepartmentCourses_PK", x => new { x.CourseID, x.DepartmentID });
                    table.ForeignKey(
                        name: "FK__Departmen__Cours__5812160E",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK__Departmen__Depar__59063A47",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentId");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    SSN = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Role = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__CA1E8E3DE84BF71F", x => x.SSN);
                    table.ForeignKey(
                        name: "FK__Users__Departmen__46E78A0C",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId");
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    QuestionID = table.Column<int>(type: "int", nullable: false),
                    QuestionAnswer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey", x => new { x.QuestionID, x.QuestionAnswer });
                    table.ForeignKey(
                        name: "ForeginKey",
                        column: x => x.QuestionID,
                        principalTable: "Question",
                        principalColumn: "QuestionId");
                });

            migrationBuilder.CreateTable(
                name: "ExamQuestions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    ExamID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ExamQuestions_PK", x => new { x.QuestionId, x.ExamID });
                    table.ForeignKey(
                        name: "FK__ExamQuest__ExamI__4222D4EF",
                        column: x => x.ExamID,
                        principalTable: "Exam",
                        principalColumn: "ExamID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__ExamQuest__Quest__412EB0B6",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "QuestionId");
                });

            migrationBuilder.CreateTable(
                name: "InstructorCourses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    InstructorID = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("InstructorCourses_PK", x => new { x.CourseID, x.InstructorID });
                    table.ForeignKey(
                        name: "FK__Instructo__Cours__5441852A",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK__Instructo__Instr__5535A963",
                        column: x => x.InstructorID,
                        principalTable: "Users",
                        principalColumn: "SSN");
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("StudentCourses_PK", x => new { x.CourseID, x.StudentID });
                    table.ForeignKey(
                        name: "FK__StudentCo__Cours__5070F446",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID");
                    table.ForeignKey(
                        name: "FK__StudentCo__Stude__5165187F",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "SSN");
                });

            migrationBuilder.CreateTable(
                name: "StudentExamAnswer",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK", x => new { x.ExamId, x.StudentId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK__StudentEx__ExamI__18EBB532",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "ExamID");
                    table.ForeignKey(
                        name: "FK__StudentEx__Quest__1AD3FDA4",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "QuestionId");
                    table.ForeignKey(
                        name: "FK__StudentEx__Stude__19DFD96B",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "SSN");
                });

            migrationBuilder.CreateTable(
                name: "StudentExams",
                columns: table => new
                {
                    ExamID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false),
                    StudentGrade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("StudentExams_PK", x => new { x.ExamID, x.StudentID });
                    table.ForeignKey(
                        name: "FK__StudentEx__ExamI__4CA06362",
                        column: x => x.ExamID,
                        principalTable: "Exam",
                        principalColumn: "ExamID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__StudentEx__Stude__4D94879B",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "SSN");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseToic_CourseId",
                table: "CourseToic",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCourses_DepartmentID",
                table: "DepartmentCourses",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_CourseID",
                table: "Exam",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestions_ExamID",
                table: "ExamQuestions",
                column: "ExamID");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCourses_InstructorID",
                table: "InstructorCourses",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Question_CourseID",
                table: "Question",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_StudentID",
                table: "StudentCourses",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentExamAnswer_QuestionId",
                table: "StudentExamAnswer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentExamAnswer_StudentId",
                table: "StudentExamAnswer",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentExams_StudentID",
                table: "StudentExams",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentId",
                table: "Users",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "CourseToic");

            migrationBuilder.DropTable(
                name: "DepartmentCourses");

            migrationBuilder.DropTable(
                name: "ExamQuestions");

            migrationBuilder.DropTable(
                name: "getInstructorExams");

            migrationBuilder.DropTable(
                name: "InstructorCourses");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "StudentExamAnswer");

            migrationBuilder.DropTable(
                name: "StudentExams");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
