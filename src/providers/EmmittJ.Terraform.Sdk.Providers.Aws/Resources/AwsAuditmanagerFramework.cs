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
        => CreateReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
        get => GetRequiredArgument<TerraformValue<string>>("id");
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
        get => GetArgument<TerraformValue<string>>("compliance_type");
        set => SetArgument("compliance_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The framework_type attribute.
    /// </summary>
    public TerraformValue<string> FrameworkType
        => CreateReference("framework_type");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// ControlSets block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAuditmanagerFrameworkControlSetsBlock>? ControlSets
    {
        get => GetArgument<TerraformSet<AwsAuditmanagerFrameworkControlSetsBlock>>("control_sets");
        set => SetArgument("control_sets", value);
    }

}
