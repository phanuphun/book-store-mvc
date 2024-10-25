﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBookStoreManagementSystem.Models
{
    public class Account 
    {
        [Key]
        [DisplayName("รหัสผู้ใช้งาน")]
        public int Id { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        [EmailAddress(ErrorMessage = "กรุณากรอกอีเมลให้ถูกต้อง")]
        [DisplayName("อีเมล")]
        public string Email { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนชื่อผู้ใช้งาน")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "ชื่อผู้ใช้งานต้องมีความยาวระหว่าง 4 ถึง 100 ตัวอักษร")]
        [DisplayName("ชื่อผู้ใช้งาน")]
        public string Username { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        [MinLength(4, ErrorMessage = "รหัสผ่านต้องมีความยาวอย่างน้อย 4 ตัวอักษร")]
        [DisplayName("รหัสผ่าน")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "กรุณาป้อนรหัสผ่านอีกครั้งเพื่อยืนยัน")]
        [DisplayName("ยืนยันรหัสผ่าน")]
        [Compare("Password", ErrorMessage = "รหัสผ่านไม่ตรงกัน กรุณาตรวจสอบ")]
        public string ConfirmPassword { get; set; }
    }
}