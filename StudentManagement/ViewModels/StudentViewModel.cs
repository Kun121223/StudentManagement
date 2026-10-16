using System.ComponentModel.DataAnnotations;

namespace StudentManagement.ViewModels
{
    /// <summary>
    /// ViewModel used exclusively by the Create/Edit Razor forms and the REST API request bodies.
    ///
    /// WHY A SEPARATE VIEWMODEL INSTEAD OF BINDING DIRECTLY TO THE ENTITY?
    /// 1. It prevents "over-posting" attacks (a malicious client setting fields like IsActive or DateCreated).
    /// 2. It lets us tailor validation messages / attributes specifically for the UI.
    /// 3. It decouples the persistence model (Student) from the presentation model, so either can change
    ///    independently - a core SOLID (Single Responsibility) idea applied to layers, not just classes.
    /// </summary>
    public class StudentViewModel
    {
        /// <summary>Guid.Empty when creating a new student, otherwise the id of the student being edited.</summary>
        public Guid StudentId { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mã sinh viên.")]
        [StringLength(20, MinimumLength = 3,ErrorMessage = "Mã sinh viên phải từ 3 đến 20 ký tự.")]
        [Display(Name = "Mã sinh viên")]
        public string StudentNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập tên.")]
        [StringLength(100, ErrorMessage = "Tên không thể vượt quá 100 ký tự.")]
        [Display(Name = "Tên")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập họ.")]
        [StringLength(100, ErrorMessage = "Họ không thể vượt quá 100 ký tự.")]
        [Display(Name = "Họ")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ email.")]
        [EmailAddress(ErrorMessage = "Vui lòng nhập một địa chỉ email hợp lệ.")]
        [StringLength(150)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập ngành học.")]
        [StringLength(100)]
        [Display(Name = "Ngành học")]
        public string Course { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng chọn năm học.")]
        [Range(1, 6, ErrorMessage = "Năm học phải từ 1 đến 6.")]
        [Display(Name = "Năm học")]
        public int YearLevel { get; set; }

        // Read-only informational fields shown on the Edit/Details view, not editable by the user.
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
