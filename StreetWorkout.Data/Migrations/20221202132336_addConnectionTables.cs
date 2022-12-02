using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StreetWorkout.Data.Migrations
{
    /// <inheritdoc />
    public partial class addConnectionTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseTraining_Exercises_ExercisesId",
                table: "ExerciseTraining");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseTraining_Trainings_TrainingsId",
                table: "ExerciseTraining");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramTraining_Programs_ProgramsId",
                table: "ProgramTraining");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramTraining_Trainings_TrainingsId",
                table: "ProgramTraining");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseTraining",
                table: "ExerciseTraining");

            migrationBuilder.DropIndex(
                name: "IX_ExerciseTraining_TrainingsId",
                table: "ExerciseTraining");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgramTraining",
                table: "ProgramTraining");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "ProgramTraining",
                newName: "ProgramTraining",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "TrainingsId",
                table: "ExerciseTraining",
                newName: "NumberOfReps");

            migrationBuilder.RenameColumn(
                name: "ExercisesId",
                table: "ExerciseTraining",
                newName: "TrainingId");

            migrationBuilder.RenameColumn(
                name: "TrainingsId",
                schema: "dbo",
                table: "ProgramTraining",
                newName: "TrainingId");

            migrationBuilder.RenameColumn(
                name: "ProgramsId",
                schema: "dbo",
                table: "ProgramTraining",
                newName: "ProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgramTraining_TrainingsId",
                schema: "dbo",
                table: "ProgramTraining",
                newName: "IX_ProgramTraining_TrainingId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trainings",
                type: "nvarchar(40)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "Difficulty",
                table: "Trainings",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Trainings",
                type: "nvarchar(400)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Programs",
                type: "nvarchar(40)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "Difficulty",
                table: "Programs",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Programs",
                type: "nvarchar(400)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExerciseId",
                table: "ExerciseTraining",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "BreakAfterExercise",
                table: "ExerciseTraining",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(40)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exercises",
                type: "nvarchar(300)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Equipment",
                type: "nvarchar(40)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "ProgramTraining",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeek",
                schema: "dbo",
                table: "ProgramTraining",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseTraining",
                table: "ExerciseTraining",
                columns: new[] { "ExerciseId", "TrainingId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgramTraining",
                schema: "dbo",
                table: "ProgramTraining",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Dumbells" },
                    { 2, "Pull up bar" },
                    { 3, "Rings" },
                    { 4, "Training bands" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Really basic exercise.", "Pull up" },
                    { 2, "Another basic exercise", "Push up" },
                    { 3, "An interesting push up", "Archer push up" }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "Description", "Difficulty", "Name" },
                values: new object[] { 1, "A program everyone should start with.", (short)0, "Begginers luck" });

            migrationBuilder.InsertData(
                table: "Trainings",
                columns: new[] { "Id", "Description", "Difficulty", "Name" },
                values: new object[] { 1, "Evereyone should start with this training", (short)1, "Pull push" });

            migrationBuilder.InsertData(
                table: "ExerciseTraining",
                columns: new[] { "ExerciseId", "TrainingId", "BreakAfterExercise", "NumberOfReps" },
                values: new object[,]
                {
                    { 1, 1, new TimeSpan(0, 0, 1, 0, 0), 10 },
                    { 2, 1, new TimeSpan(0, 0, 1, 0, 0), 25 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ProgramTraining",
                columns: new[] { "Id", "DayOfWeek", "ProgramId", "TrainingId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 3, 1, 1 },
                    { 3, 5, 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTraining_TrainingId",
                table: "ExerciseTraining",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramTraining_ProgramId",
                schema: "dbo",
                table: "ProgramTraining",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTraining_Exercises_ExerciseId",
                table: "ExerciseTraining",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTraining_Trainings_TrainingId",
                table: "ExerciseTraining",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramTraining_Programs_ProgramId",
                schema: "dbo",
                table: "ProgramTraining",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramTraining_Trainings_TrainingId",
                schema: "dbo",
                table: "ProgramTraining",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseTraining_Exercises_ExerciseId",
                table: "ExerciseTraining");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseTraining_Trainings_TrainingId",
                table: "ExerciseTraining");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramTraining_Programs_ProgramId",
                schema: "dbo",
                table: "ProgramTraining");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramTraining_Trainings_TrainingId",
                schema: "dbo",
                table: "ProgramTraining");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseTraining",
                table: "ExerciseTraining");

            migrationBuilder.DropIndex(
                name: "IX_ExerciseTraining_TrainingId",
                table: "ExerciseTraining");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgramTraining",
                schema: "dbo",
                table: "ProgramTraining");

            migrationBuilder.DropIndex(
                name: "IX_ProgramTraining_ProgramId",
                schema: "dbo",
                table: "ProgramTraining");

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExerciseTraining",
                keyColumns: new[] { "ExerciseId", "TrainingId" },
                keyColumnTypes: new[] { "int", "int" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ExerciseTraining",
                keyColumns: new[] { "ExerciseId", "TrainingId" },
                keyColumnTypes: new[] { "int", "int" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ProgramTraining",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ProgramTraining",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ProgramTraining",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "ExerciseTraining");

            migrationBuilder.DropColumn(
                name: "BreakAfterExercise",
                table: "ExerciseTraining");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "dbo",
                table: "ProgramTraining");

            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                schema: "dbo",
                table: "ProgramTraining");

            migrationBuilder.RenameTable(
                name: "ProgramTraining",
                schema: "dbo",
                newName: "ProgramTraining");

            migrationBuilder.RenameColumn(
                name: "NumberOfReps",
                table: "ExerciseTraining",
                newName: "TrainingsId");

            migrationBuilder.RenameColumn(
                name: "TrainingId",
                table: "ExerciseTraining",
                newName: "ExercisesId");

            migrationBuilder.RenameColumn(
                name: "TrainingId",
                table: "ProgramTraining",
                newName: "TrainingsId");

            migrationBuilder.RenameColumn(
                name: "ProgramId",
                table: "ProgramTraining",
                newName: "ProgramsId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgramTraining_TrainingId",
                table: "ProgramTraining",
                newName: "IX_ProgramTraining_TrainingsId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Trainings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)");

            migrationBuilder.AlterColumn<int>(
                name: "Difficulty",
                table: "Trainings",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Trainings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Programs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)");

            migrationBuilder.AlterColumn<int>(
                name: "Difficulty",
                table: "Programs",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Programs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseTraining",
                table: "ExerciseTraining",
                columns: new[] { "ExercisesId", "TrainingsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgramTraining",
                table: "ProgramTraining",
                columns: new[] { "ProgramsId", "TrainingsId" });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTraining_TrainingsId",
                table: "ExerciseTraining",
                column: "TrainingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTraining_Exercises_ExercisesId",
                table: "ExerciseTraining",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTraining_Trainings_TrainingsId",
                table: "ExerciseTraining",
                column: "TrainingsId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramTraining_Programs_ProgramsId",
                table: "ProgramTraining",
                column: "ProgramsId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramTraining_Trainings_TrainingsId",
                table: "ProgramTraining",
                column: "TrainingsId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
