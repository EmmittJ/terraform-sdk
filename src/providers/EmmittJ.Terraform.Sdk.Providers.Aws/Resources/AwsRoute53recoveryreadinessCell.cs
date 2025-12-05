using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsRoute53recoveryreadinessCell.
/// Nesting mode: single
/// </summary>
public class AwsRoute53recoveryreadinessCellTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_route53recoveryreadiness_cell Terraform resource.
/// Manages a aws_route53recoveryreadiness_cell resource.
/// </summary>
public partial class AwsRoute53recoveryreadinessCell(string name) : TerraformResource("aws_route53recoveryreadiness_cell", name)
{
    /// <summary>
    /// The cell_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CellName is required")]
    public required TerraformValue<string> CellName
    {
        get => GetRequiredArgument<TerraformValue<string>>("cell_name");
        set => SetArgument("cell_name", value);
    }

    /// <summary>
    /// The cells attribute.
    /// </summary>
    public TerraformList<string>? Cells
    {
        get => GetArgument<TerraformList<string>>("cells");
        set => SetArgument("cells", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The parent_readiness_scopes attribute.
    /// </summary>
    public TerraformList<string> ParentReadinessScopes
        => CreateReference("parent_readiness_scopes");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53recoveryreadinessCellTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53recoveryreadinessCellTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
