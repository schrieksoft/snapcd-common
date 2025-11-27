namespace SnapCd.Common.Dto.NamespaceInputs.Base;

public class NamespaceInputCreateDto
{
    public Guid NamespaceId { get; set; }
    public string Name { get; set; } = null!;

    public NamespaceInputUsageMode UsageMode { get; set; }
    public InputKind InputKind { get; set; }
}
