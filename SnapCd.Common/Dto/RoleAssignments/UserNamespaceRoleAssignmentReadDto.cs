using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserNamespaceRoleAssignmentReadDto : UserNamespaceRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}