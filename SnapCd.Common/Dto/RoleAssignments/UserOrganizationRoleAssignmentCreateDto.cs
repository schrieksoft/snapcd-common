namespace SnapCd.Common.Dto.RoleAssignments;

public class UserOrganizationRoleAssignmentCreateDto
{
    public Guid UserId { get; set; }

    public OrganizationRole RoleName { get; set; }
}
