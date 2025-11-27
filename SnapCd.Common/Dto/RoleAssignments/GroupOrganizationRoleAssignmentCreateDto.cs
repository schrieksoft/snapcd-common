namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupOrganizationRoleAssignmentCreateDto
{
    public Guid GroupId { get; set; }

    public OrganizationRole RoleName { get; set; }
}
