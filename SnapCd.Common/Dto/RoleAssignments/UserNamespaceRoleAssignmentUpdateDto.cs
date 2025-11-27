using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserNamespaceRoleAssignmentUpdateDto : UserNamespaceRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
