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
        set => SetProperty("aws_region", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The sip_media_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SipMediaApplicationId is required")]
    public required TerraformProperty<string> SipMediaApplicationId
    {
        set => SetProperty("sip_media_application_id", value);
    }

}

/// <summary>
/// Manages a aws_chimesdkvoice_sip_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsChimesdkvoiceSipRule : TerraformResource
{
    public AwsChimesdkvoiceSipRule(string name) : base("aws_chimesdkvoice_sip_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("disabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("trigger_type");
        SetOutput("trigger_value");
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The trigger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerType is required")]
    public required TerraformProperty<string> TriggerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("trigger_type");
        set => SetProperty("trigger_type", value);
    }

    /// <summary>
    /// The trigger_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerValue is required")]
    public required TerraformProperty<string> TriggerValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("trigger_value");
        set => SetProperty("trigger_value", value);
    }

    /// <summary>
    /// Block for target_applications.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetApplications is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetApplications block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 TargetApplications block(s) allowed")]
    public HashSet<AwsChimesdkvoiceSipRuleTargetApplicationsBlock>? TargetApplications
    {
        set => SetProperty("target_applications", value);
    }

}
