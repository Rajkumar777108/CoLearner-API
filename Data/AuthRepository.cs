using System;
using System.Threading.Tasks;
using CoLearner.API.Model;
using Microsoft.EntityFrameworkCore;

namespace CoLearner.API.Data
{
    public class AuthRepository : IAuthRepository
    {

        private readonly DBEntity _dbEntity;

        public AuthRepository(DBEntity dbEntity)
        {
            _dbEntity = dbEntity;
        }
        public async Task<User> Login(string userName, string password)
        {
            var user =  await _dbEntity.Users.FirstOrDefaultAsync(x => x.UserName == userName);

            if(user == null)
            return null;

            if(!VerifyPassword(password, user.PasswordHash,user.PasswordSalt))
            return null;

            return user;
        }

        private bool VerifyPassword(string password, byte[] passwordHash,byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var  computedPasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                for(int i = 0; i<computedPasswordHash.Length;i++)
                {
                    if(computedPasswordHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePassword(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _dbEntity.Users.AddAsync(user);
            await _dbEntity.SaveChangesAsync();

            return user;
        }

        private void CreatePassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

        }

        public async Task<bool> UserExist(string userName)
        {
            if(await _dbEntity.Users.AnyAsync(x=>x.UserName==userName))
                return true;

            return false;
        }
    }
}