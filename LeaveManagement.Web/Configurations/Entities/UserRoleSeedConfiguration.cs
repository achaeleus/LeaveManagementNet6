using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(

                new IdentityUserRole<string>
                {
                    RoleId = "0c63c4fc-1178-4816-93d5-ba16426036d9",
                    UserId = "c50c87dd-be7b-4618-bb49-fd45040cda92"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2",
                    UserId = "7c0677d-2447-42cb-bc97-8eba952e4468"
                }

            );
        }
    }
}