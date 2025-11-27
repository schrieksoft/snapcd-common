using SnapCd.Common.Dto.NamespaceInputs.Base;

namespace SnapCd.Common.Dto.NamespaceInputs;

public class NamespaceInputFromLiteralCreateDto : NamespaceInputCreateDto
{
    public string LiteralValue { get; set; } = null!;

    public InputType Type { get; set; }
}
