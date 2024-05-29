using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NklLession06.Models
{
    public class NklSong
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Nkl:Hãy nhập tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string NklTitle { get; set; }

        [Required(ErrorMessage = "Nkl:Hãy nhập tác giả")]
        [DisplayName("tác giả")]
        public string NklAuthor { get; set; }

        [Required(ErrorMessage = "Nkl:Hãy nhập nghệ sĩ")]
        [DisplayName("nghệ sĩ")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Nkl: Tên nghệ sĩ  có tối thiểu 2 ký tự, tối đa 50 ký tự")]
        public string NklArtist { get; set; }

        [Required(ErrorMessage = "Nkl:Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "Nkl: năm xuất bản phải có 4 ký tự số")]
        [Range(1900, 2024, ErrorMessage = "Nkl: Năm xuất bản từ 1900-2024")]
        [DisplayName("năm xuất bản")]

        public int NklYearRelease { get; set; }
    }
}