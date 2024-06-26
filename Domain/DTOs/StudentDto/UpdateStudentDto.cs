using Domain.Enums;

namespace Domain.DTOs.StudentDto;

public class UpdateStudentDto
{
    public int Id { get; set; }
    public required string FirstName { get; set; } 
    public required string LastName { get; set; } 
    public required string Address { get; set; } 
    public required string Phone { get; set; } 
    public required string Email { get; set; } 
    public Status Status { get; set; }
    public Gender Gender { get; set; }
    public DateTime DoB { get; set; }
}