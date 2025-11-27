using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments.Base;

public class NamespaceRoleAssignmentUpdateDto : NamespaceRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
