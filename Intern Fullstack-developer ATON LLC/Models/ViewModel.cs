using System.ComponentModel.DataAnnotations;

namespace Intern_Fullstack_developer_ATON_LLC_Web.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "���� \"�����\" ����������� ��� ����������.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "���� \"������\" ����������� ��� ����������.")]
        public string Password { get; set; }
    }

    public class ChangeStatusViewModel
    {
        [Required]
        public int ClientId { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
