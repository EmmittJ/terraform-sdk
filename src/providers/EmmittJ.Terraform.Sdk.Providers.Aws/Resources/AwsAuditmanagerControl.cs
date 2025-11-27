using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for control_mapping_sources in AwsAuditmanagerControl.
/// Nesting mode: set
/// </summary>
public class AwsAuditmanagerControlControlMappingSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control_mapping_sources";

    /// <summary>
    /// The source_description attribute.
    /// </summary>
    public TerraformValue<string>? SourceDescription
    {
        get => new TerraformReference<string>(this, "source_description");
        set => SetArgument("source_description", value);
    }

    /// <summary>
    /// The source_frequency attribute.
    /// </summary>
    public TerraformValue<string>? SourceFrequency
    {
        get => new TerraformReference<string>(this, "source_frequency");
        set => SetArgument("source_frequency", value);
    }

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    public TerraformValue<string> SourceId
    {
        get => new TerraformReference<string>(this, "source_id");
    }

    /// <summary>
    /// The source_keyword attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceKeyword
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "source_keyword").ResolveNodes(ctx));
        set => SetArgument("source_keyword", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformValue<string> SourceName
    {
        get => new TerraformReference<string>(this, "source_name");
        set => SetArgument("source_name", value);
    }

    /// <summary>
    /// The source_set_up_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSetUpOption is required")]
    public required TerraformValue<string> SourceSetUpOption
    {
        get => new TerraformReference<string>(this, "source_set_up_option");
        set => SetArgument("source_set_up_option", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    public required TerraformValue<string> SourceType
    {
        get => new TerraformReference<string>(this, "source_type");
        set => SetArgument("source_type", value);
    }

    /// <summary>
    /// The troubleshooting_text attribute.
    /// </summary>
    public TerraformValue<string>? TroubleshootingText
    {
        get => new TerraformReference<string>(this, "troubleshooting_text");
        set => SetArgument("troubleshooting_text", value);
    }

}


/// <summary>
/// Represents a aws_auditmanager_control Terraform resource.
/// Manages a aws_auditmanager_control resource.
/// </summary>
public partial class AwsAuditmanagerControl(string name) : TerraformResource("aws_auditmanager_control", name)
{
    /// <summary>
    /// The action_plan_instructions attribute.
    /// </summary>
    public TerraformValue<string>? ActionPlanInstructions
    {
        get => new TerraformReference<string>(this, "action_plan_instructions");
        set => SetArgument("action_plan_instructions", value);
    }

    /// <summary>
    /// The action_plan_title attribute.
    /// </summary>
    public TerraformValue<string>? ActionPlanTitle
    {
        get => new TerraformReference<string>(this, "action_plan_title");
        set => SetArgument("action_plan_title", value);
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
    /// The testing_information attribute.
    /// </summary>
    public TerraformValue<string>? TestingInformation
    {
        get => new TerraformReference<string>(this, "testing_information");
        set => SetArgument("testing_information", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// ControlMappingSources block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAuditmanagerControlControlMappingSourcesBlock>? ControlMappingSources
    {
        get => GetArgument<TerraformSet<AwsAuditmanagerControlControlMappingSourcesBlock>>("control_mapping_sources");
        set => SetArgument("control_mapping_sources", value);
    }

}
