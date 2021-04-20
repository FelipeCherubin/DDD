using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Dtos.User;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        // Task<UserEntity> Get(Guid id);
        // Task<IEnumerable<UserEntity>> GetAll();
        // Task<UserEntity> Post(UserEntity user);
        // Task<UserEntity> Put(UserEntity user);
        // Task<bool> Delete(Guid id);

        Task<UserDto> Get(Guid id);
        Task<IEnumerable<UserDto>> GetAll();
        Task<UserDtoCreateResult> Post(UserDto user);
        Task<UserDtoUpdateResult> Put(UserDto user);
        Task<bool> Delete(Guid id);


    }
}
