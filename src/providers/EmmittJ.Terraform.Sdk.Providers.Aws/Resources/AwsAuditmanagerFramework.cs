using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for control_sets in AwsAuditmanagerFramework.
/// Nesting mode: set
/// </summary>
public class AwsAuditmanagerFrameworkControlSetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_sets";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Controls block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAuditmanagerFrameworkControlSetsBlockControlsBlock>? Controls
    {
        get => GetArgument<TerraformSet<AwsAuditmanagerFrameworkControlSetsBlockControlsBlock>>("controls");
        set => SetArgument("controls", value);
    }

}

/// <summary>
/// Block type for controls in AwsAuditmanagerFrameworkControlSetsBlock.
/// Nesting mode: set
/// </summary>
public class AwsAuditmanagerFrameworkControlSetsBlockControlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "controls";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

}


/// <summary>
/// Represents a aws_auditmanager_framework Terraform resource.
/// Manages a aws_auditmanager_framework resource.
/// </summary>
public partial class AwsAuditmanagerFramework(string name) : TerraformResource("aws_auditmanager_framework", name)
{
    /// <summary>
    /// The compliance_type attribute.
    /// </summary>
    public TerraformValue<string>? ComplianceType
    {
        get => new TerraformReference<string>(this, "compliance_type");
        set => SetArgument("compliance_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The framework_type attribute.
    /// </summary>
    public TerraformValue<string> FrameworkType
    {
        get => new TerraformReference<string>(this, "framework_type");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// ControlSets block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAuditmanagerFrameworkControlSetsBlock>? ControlSets
    {
        get => GetArgument<TerraformSet<AwsAuditmanagerFrameworkControlSetsBlock>>("control_sets");
        set => SetArgument("control_sets", value);
    }

}
