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
        get => GetArgument<TerraformValue<string>>("source_description");
        set => SetArgument("source_description", value);
    }

    /// <summary>
    /// The source_frequency attribute.
    /// </summary>
    public TerraformValue<string>? SourceFrequency
    {
        get => GetArgument<TerraformValue<string>>("source_frequency");
        set => SetArgument("source_frequency", value);
    }

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    public TerraformValue<string> SourceId
        => CreateReference("source_id");

    /// <summary>
    /// The source_keyword attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceKeyword
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("source_keyword") ?? CreateReference("source_keyword");
        set => SetArgument("source_keyword", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformValue<string> SourceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_name");
        set => SetArgument("source_name", value);
    }

    /// <summary>
    /// The source_set_up_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSetUpOption is required")]
    public required TerraformValue<string> SourceSetUpOption
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_set_up_option");
        set => SetArgument("source_set_up_option", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    public required TerraformValue<string> SourceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_type");
        set => SetArgument("source_type", value);
    }

    /// <summary>
    /// The troubleshooting_text attribute.
    /// </summary>
    public TerraformValue<string>? TroubleshootingText
    {
        get => GetArgument<TerraformValue<string>>("troubleshooting_text");
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
        get => GetArgument<TerraformValue<string>>("action_plan_instructions");
        set => SetArgument("action_plan_instructions", value);
    }

    /// <summary>
    /// The action_plan_title attribute.
    /// </summary>
    public TerraformValue<string>? ActionPlanTitle
    {
        get => GetArgument<TerraformValue<string>>("action_plan_title");
        set => SetArgument("action_plan_title", value);
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
    /// The testing_information attribute.
    /// </summary>
    public TerraformValue<string>? TestingInformation
    {
        get => GetArgument<TerraformValue<string>>("testing_information");
        set => SetArgument("testing_information", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// ControlMappingSources block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAuditmanagerControlControlMappingSourcesBlock>? ControlMappingSources
    {
        get => GetArgument<TerraformSet<AwsAuditmanagerControlControlMappingSourcesBlock>>("control_mapping_sources");
        set => SetArgument("control_mapping_sources", value);
    }

}
