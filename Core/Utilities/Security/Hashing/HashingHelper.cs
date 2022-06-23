using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //passwod verecez ve iki değeri dışarı cıkarmaya yarıyacak metotrur.
        //hangi algoritmayı kullanacagımızı söylüyor
        public static void CreatePasswordHash
            (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            //password salt ve hash oluşturmak için kulalnılır
            //her kullanıcı için bir key oluşturur.
            using (var hmac= new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        //göndermeye gerek yok out yok
        //yine aynı algoritma kullanırken daha önce onu oluştururken salt ı kullanarak dpğruluyoruz doğruluyoruz
        public static bool VerifyPasswordHash(string password,byte[] passwordHash, byte[] passwordSalt)
        //passwordheash ini doğrula demek
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
