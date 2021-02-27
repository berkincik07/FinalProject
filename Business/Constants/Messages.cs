using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Şu anda bakımdayız.";
        public static string ProductListed = "Ürünler Listelendi.";
        public static string ProductCountOfCategoryError ="Aynı kategoride maksimum 10 ürün olabilir.";
        public static string SameProductNameError = "Aynı isimde başka ürün bulunuyor.";
        public static string FullCategoryError = "Kategori sayısı maksimum 15 olabilir.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı kaydedildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı.";
        public static string AccessTokenCreated = "Erişim tokeni oluşturuldu.";
    }
}
