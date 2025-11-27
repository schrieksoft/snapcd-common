using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserNamespaceRoleAssignmentDto : UserNamespaceRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}