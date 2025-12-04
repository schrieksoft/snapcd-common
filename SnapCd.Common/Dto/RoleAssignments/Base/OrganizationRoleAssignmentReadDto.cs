using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments.Base;

public class OrganizationRoleAssignmentReadDto : OrganizationRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}