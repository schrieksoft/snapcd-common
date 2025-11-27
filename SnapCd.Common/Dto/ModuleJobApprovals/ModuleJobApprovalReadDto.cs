using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleJobApprovals;

public class ModuleJobApprovalReadDto : ModuleJobApprovalCreateDto, IDto
{
    public Guid Id { get; set; }
}