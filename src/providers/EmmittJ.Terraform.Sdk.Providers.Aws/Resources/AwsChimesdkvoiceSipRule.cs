using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target_applications in AwsChimesdkvoiceSipRule.
/// Nesting mode: set
/// </summary>
public class AwsChimesdkvoiceSipRuleTargetApplicationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_applications";

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsRegion is required")]
    public required TerraformValue<string> AwsRegion
    {
        get => GetRequiredArgument<TerraformValue<string>>("aws_region");
        set => SetArgument("aws_region", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetRequiredArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The sip_media_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SipMediaApplicationId is required")]
    public required TerraformValue<string> SipMediaApplicationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("sip_media_application_id");
        set => SetArgument("sip_media_application_id", value);
    }

}


/// <summary>
/// Represents a aws_chimesdkvoice_sip_rule Terraform resource.
/// Manages a aws_chimesdkvoice_sip_rule resource.
/// </summary>
public partial class AwsChimesdkvoiceSipRule(string name) : TerraformResource("aws_chimesdkvoice_sip_rule", name)
{
    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
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
    /// The trigger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerType is required")]
    public required TerraformValue<string> TriggerType
    {
        get => GetRequiredArgument<TerraformValue<string>>("trigger_type");
        set => SetArgument("trigger_type", value);
    }

    /// <summary>
    /// The trigger_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerValue is required")]
    public required TerraformValue<string> TriggerValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("trigger_value");
        set => SetArgument("trigger_value", value);
    }

    /// <summary>
    /// TargetApplications block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetApplications is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetApplications block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 TargetApplications block(s) allowed")]
    public required TerraformSet<AwsChimesdkvoiceSipRuleTargetApplicationsBlock> TargetApplications
    {
        get => GetRequiredArgument<TerraformSet<AwsChimesdkvoiceSipRuleTargetApplicationsBlock>>("target_applications");
        set => SetArgument("target_applications", value);
    }

}
