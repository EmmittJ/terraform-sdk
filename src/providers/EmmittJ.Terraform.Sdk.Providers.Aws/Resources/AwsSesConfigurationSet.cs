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
        get => GetProperty<TerraformProperty<string>>("tls_policy");
        set => WithProperty("tls_policy", value);
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
        get => GetProperty<TerraformProperty<string>>("custom_redirect_domain");
        set => WithProperty("custom_redirect_domain", value);
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
        this.WithOutput("arn");
        this.WithOutput("last_fresh_start");
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// The reputation_metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ReputationMetricsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("reputation_metrics_enabled");
        set => this.WithProperty("reputation_metrics_enabled", value);
    }

    /// <summary>
    /// The sending_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SendingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sending_enabled");
        set => this.WithProperty("sending_enabled", value);
    }

    /// <summary>
    /// Block for delivery_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryOptions block(s) allowed")]
    public List<AwsSesConfigurationSetDeliveryOptionsBlock>? DeliveryOptions
    {
        get => GetProperty<List<AwsSesConfigurationSetDeliveryOptionsBlock>>("delivery_options");
        set => this.WithProperty("delivery_options", value);
    }

    /// <summary>
    /// Block for tracking_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrackingOptions block(s) allowed")]
    public List<AwsSesConfigurationSetTrackingOptionsBlock>? TrackingOptions
    {
        get => GetProperty<List<AwsSesConfigurationSetTrackingOptionsBlock>>("tracking_options");
        set => this.WithProperty("tracking_options", value);
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
