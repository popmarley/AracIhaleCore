using System;

namespace AracIhale.UI.Models.Enums
{
	
	public enum UserRoles
	{
		Admin = 1,
		Kullanici = 2,
		PlusAdmin = 3
	}
	public static class UserRolesHelper
	{
		public static string GetRoleName(int roleId)
		{
			return Enum.GetName(typeof(UserRoles), roleId);
		}
	}


}
