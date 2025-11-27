using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.ModuleJobApprovals;

public class ModuleJobApprovalUpdateDto : ModuleJobApprovalCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
