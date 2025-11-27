using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupModuleRoleAssignmentUpdateDto : GroupModuleRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
