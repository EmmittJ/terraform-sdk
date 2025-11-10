using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetDeliveryOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The max_delivery_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxDeliverySeconds
    {
        set => SetProperty("max_delivery_seconds", value);
    }

    /// <summary>
    /// The sending_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? SendingPoolName
    {
        set => SetProperty("sending_pool_name", value);
    }

    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    public TerraformProperty<string>? TlsPolicy
    {
        set => SetProperty("tls_policy", value);
    }

}

/// <summary>
/// Block type for reputation_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetReputationOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The last_fresh_start attribute.
    /// </summary>
    public TerraformProperty<string>? LastFreshStart
    {
        set => SetProperty("last_fresh_start", value);
    }

    /// <summary>
    /// The reputation_metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ReputationMetricsEnabled
    {
        set => SetProperty("reputation_metrics_enabled", value);
    }

}

/// <summary>
/// Block type for sending_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetSendingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The sending_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SendingEnabled
    {
        set => SetProperty("sending_enabled", value);
    }

}

/// <summary>
/// Block type for suppression_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetSuppressionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The suppressed_reasons attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SuppressedReasons
    {
        set => SetProperty("suppressed_reasons", value);
    }

}

/// <summary>
/// Block type for tracking_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetTrackingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The custom_redirect_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomRedirectDomain is required")]
    public required TerraformProperty<string> CustomRedirectDomain
    {
        set => SetProperty("custom_redirect_domain", value);
    }

    /// <summary>
    /// The https_policy attribute.
    /// </summary>
    public TerraformProperty<string>? HttpsPolicy
    {
        set => SetProperty("https_policy", value);
    }

}

/// <summary>
/// Block type for vdm_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetVdmOptionsBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_sesv2_configuration_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSesv2ConfigurationSet : TerraformResource
{
    public AwsSesv2ConfigurationSet(string name) : base("aws_sesv2_configuration_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("configuration_set_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    public required TerraformProperty<string> ConfigurationSetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration_set_name");
        set => SetProperty("configuration_set_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for delivery_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryOptions block(s) allowed")]
    public List<AwsSesv2ConfigurationSetDeliveryOptionsBlock>? DeliveryOptions
    {
        set => SetProperty("delivery_options", value);
    }

    /// <summary>
    /// Block for reputation_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReputationOptions block(s) allowed")]
    public List<AwsSesv2ConfigurationSetReputationOptionsBlock>? ReputationOptions
    {
        set => SetProperty("reputation_options", value);
    }

    /// <summary>
    /// Block for sending_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SendingOptions block(s) allowed")]
    public List<AwsSesv2ConfigurationSetSendingOptionsBlock>? SendingOptions
    {
        set => SetProperty("sending_options", value);
    }

    /// <summary>
    /// Block for suppression_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuppressionOptions block(s) allowed")]
    public List<AwsSesv2ConfigurationSetSuppressionOptionsBlock>? SuppressionOptions
    {
        set => SetProperty("suppression_options", value);
    }

    /// <summary>
    /// Block for tracking_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrackingOptions block(s) allowed")]
    public List<AwsSesv2ConfigurationSetTrackingOptionsBlock>? TrackingOptions
    {
        set => SetProperty("tracking_options", value);
    }

    /// <summary>
    /// Block for vdm_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VdmOptions block(s) allowed")]
    public List<AwsSesv2ConfigurationSetVdmOptionsBlock>? VdmOptions
    {
        set => SetProperty("vdm_options", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
