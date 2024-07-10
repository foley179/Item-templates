using OnHousing.Domain.Users.Entities;
using RubixxExtensibility.Authentication.Users.Dtos;

namespace $rootnamespace$;

internal class $safeitemname$ 
{
    #region Backing fields
    private LinkUser? _user;
    #endregion

    public  Build()
    {
        CreateMissingRequiredFields();

        return entity;
    }

    #region Private methods
    private $safeitemname$ CreateMissingRequiredFields()
    {
        _user = new(UserDto.UnknownUser.Id, "Forename", "Surname", "Email");

        return this;
    }
    #endregion
}
