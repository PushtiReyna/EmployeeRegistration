using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeRegistration.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    [Required(ErrorMessage = "Please enter your  First name"), MaxLength(20)]
    //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter only letters.")]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your  Middle name"), MaxLength(20)]
    //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter only letters.")]
    public string MiddleName { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your last name"), MaxLength(20)]
    //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter only letters.")]
    public string LastName { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your  Address"), MaxLength(50)]
    public string Address { get; set; } = null!;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Please enter valid email.")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your  Date Of Birth")]
    public DateTime Dob { get; set; }

    [Required(ErrorMessage = "Please enter your Mobile no.")]
    [MinLength(10, ErrorMessage = "The Mobile no. must be at least 10 characters")]
    [MaxLength(10, ErrorMessage = "The Mobile no. cannot be more than 10 characters")]
    public string Mobile1 { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your Alternate Mobile No.")]
    [MinLength(10, ErrorMessage = "The Alternate Mobile No. must be at least 10 characters")]
    [MaxLength(10, ErrorMessage = "The Alternate Mobile No. cannot be more than 10 characters")]
    public string Mobile2 { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your Pincode")]
    [MinLength(6, ErrorMessage = "The pincode must be at least 6 characters")]
    [MaxLength(6, ErrorMessage = "The pincode cannot be more than 6 characters")]
    public string PinCode { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your  Gender")]
    public string Gender { get; set; } = null!;
}
