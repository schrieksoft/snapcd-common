using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments.Base;

public class ModuleRoleAssignmentDto : ModuleRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}