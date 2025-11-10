using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target_applications in .
/// Nesting mode: set
/// </summary>
public class AwsChimesdkvoiceSipRuleTargetApplicationsBlock : TerraformBlock
{
    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsRegion is required")]
    public required TerraformProperty<string> AwsRegion
    {
        get => GetProperty<TerraformProperty<string>>("aws_region");
        set => WithProperty("aws_region", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

    /// <summary>
    /// The sip_media_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SipMediaApplicationId is required")]
    public required TerraformProperty<string> SipMediaApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("sip_media_application_id");
        set => WithProperty("sip_media_application_id", value);
    }

}

/// <summary>
/// Manages a aws_chimesdkvoice_sip_rule resource.
/// </summary>
public class AwsChimesdkvoiceSipRule : TerraformResource
{
    public AwsChimesdkvoiceSipRule(string name) : base("aws_chimesdkvoice_sip_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The trigger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerType is required")]
    public required TerraformProperty<string> TriggerType
    {
        get => GetProperty<TerraformProperty<string>>("trigger_type");
        set => this.WithProperty("trigger_type", value);
    }

    /// <summary>
    /// The trigger_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerValue is required")]
    public required TerraformProperty<string> TriggerValue
    {
        get => GetProperty<TerraformProperty<string>>("trigger_value");
        set => this.WithProperty("trigger_value", value);
    }

    /// <summary>
    /// Block for target_applications.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetApplications block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 TargetApplications block(s) allowed")]
    public HashSet<AwsChimesdkvoiceSipRuleTargetApplicationsBlock>? TargetApplications
    {
        get => GetProperty<HashSet<AwsChimesdkvoiceSipRuleTargetApplicationsBlock>>("target_applications");
        set => this.WithProperty("target_applications", value);
    }

}
