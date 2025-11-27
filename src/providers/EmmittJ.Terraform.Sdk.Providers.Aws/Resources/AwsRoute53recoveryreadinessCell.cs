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
        get => new TerraformReference<string>(this, "delete");
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
        get => new TerraformReference<string>(this, "cell_name");
        set => SetArgument("cell_name", value);
    }

    /// <summary>
    /// The cells attribute.
    /// </summary>
    public TerraformList<string>? Cells
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cells").ResolveNodes(ctx));
        set => SetArgument("cells", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The parent_readiness_scopes attribute.
    /// </summary>
    public TerraformList<string> ParentReadinessScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "parent_readiness_scopes").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53recoveryreadinessCellTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53recoveryreadinessCellTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
