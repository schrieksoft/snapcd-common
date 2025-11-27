using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserModuleRoleAssignmentUpdateDto : UserModuleRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
