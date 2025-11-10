using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesConfigurationSetDeliveryOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    public TerraformProperty<string>? TlsPolicy
    {
        set => SetProperty("tls_policy", value);
    }

}

/// <summary>
/// Block type for tracking_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesConfigurationSetTrackingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The custom_redirect_domain attribute.
    /// </summary>
    public TerraformProperty<string>? CustomRedirectDomain
    {
        set => SetProperty("custom_redirect_domain", value);
    }

}

/// <summary>
/// Manages a aws_ses_configuration_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSesConfigurationSet : TerraformResource
{
    public AwsSesConfigurationSet(string name) : base("aws_ses_configuration_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("last_fresh_start");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("reputation_metrics_enabled");
        SetOutput("sending_enabled");
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
    /// The reputation_metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ReputationMetricsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("reputation_metrics_enabled");
        set => SetProperty("reputation_metrics_enabled", value);
    }

    /// <summary>
    /// The sending_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SendingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sending_enabled");
        set => SetProperty("sending_enabled", value);
    }

    /// <summary>
    /// Block for delivery_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryOptions block(s) allowed")]
    public List<AwsSesConfigurationSetDeliveryOptionsBlock>? DeliveryOptions
    {
        set => SetProperty("delivery_options", value);
    }

    /// <summary>
    /// Block for tracking_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrackingOptions block(s) allowed")]
    public List<AwsSesConfigurationSetTrackingOptionsBlock>? TrackingOptions
    {
        set => SetProperty("tracking_options", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The last_fresh_start attribute.
    /// </summary>
    public TerraformExpression LastFreshStart => this["last_fresh_start"];

}
