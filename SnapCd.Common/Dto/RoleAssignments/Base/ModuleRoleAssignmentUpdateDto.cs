using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments.Base;

public class ModuleRoleAssignmentUpdateDto : ModuleRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
