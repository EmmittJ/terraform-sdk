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
        get => GetProperty<TerraformProperty<double>>("max_delivery_seconds");
        set => WithProperty("max_delivery_seconds", value);
    }

    /// <summary>
    /// The sending_pool_name attribute.
    /// </summary>
    public TerraformProperty<string>? SendingPoolName
    {
        get => GetProperty<TerraformProperty<string>>("sending_pool_name");
        set => WithProperty("sending_pool_name", value);
    }

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
        get => GetProperty<TerraformProperty<string>>("last_fresh_start");
        set => WithProperty("last_fresh_start", value);
    }

    /// <summary>
    /// The reputation_metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ReputationMetricsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("reputation_metrics_enabled");
        set => WithProperty("reputation_metrics_enabled", value);
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
        get => GetProperty<TerraformProperty<bool>>("sending_enabled");
        set => WithProperty("sending_enabled", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("suppressed_reasons");
        set => WithProperty("suppressed_reasons", value);
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
        get => GetProperty<TerraformProperty<string>>("custom_redirect_domain");
        set => WithProperty("custom_redirect_domain", value);
    }

    /// <summary>
    /// The https_policy attribute.
    /// </summary>
    public TerraformProperty<string>? HttpsPolicy
    {
        get => GetProperty<TerraformProperty<string>>("https_policy");
        set => WithProperty("https_policy", value);
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
public class AwsSesv2ConfigurationSet : TerraformResource
{
    public AwsSesv2ConfigurationSet(string name) : base("aws_sesv2_configuration_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    public required TerraformProperty<string> ConfigurationSetName
    {
        get => GetProperty<TerraformProperty<string>>("configuration_set_name");
        set => this.WithProperty("configuration_set_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for delivery_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryOptions block(s) allowed")]
    public List<AwsSesv2ConfigurationSetDeliveryOptionsBlock>? DeliveryOptions
    {
        get => GetProperty<List<AwsSesv2ConfigurationSetDeliveryOptionsBlock>>("delivery_options");
        set => this.WithProperty("delivery_options", value);
    }

    /// <summary>
    /// Block for reputation_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReputationOptions block(s) allowed")]
    public List<AwsSesv2ConfigurationSetReputationOptionsBlock>? ReputationOptions
    {
        get => GetProperty<List<AwsSesv2ConfigurationSetReputationOptionsBlock>>("reputation_options");
        set => this.WithProperty("reputation_options", value);
    }

    /// <summary>
    /// Block for sending_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SendingOptions block(s) allowed")]
    public List<AwsSesv2ConfigurationSetSendingOptionsBlock>? SendingOptions
    {
        get => GetProperty<List<AwsSesv2ConfigurationSetSendingOptionsBlock>>("sending_options");
        set => this.WithProperty("sending_options", value);
    }

    /// <summary>
    /// Block for suppression_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuppressionOptions block(s) allowed")]
    public List<AwsSesv2ConfigurationSetSuppressionOptionsBlock>? SuppressionOptions
    {
        get => GetProperty<List<AwsSesv2ConfigurationSetSuppressionOptionsBlock>>("suppression_options");
        set => this.WithProperty("suppression_options", value);
    }

    /// <summary>
    /// Block for tracking_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrackingOptions block(s) allowed")]
    public List<AwsSesv2ConfigurationSetTrackingOptionsBlock>? TrackingOptions
    {
        get => GetProperty<List<AwsSesv2ConfigurationSetTrackingOptionsBlock>>("tracking_options");
        set => this.WithProperty("tracking_options", value);
    }

    /// <summary>
    /// Block for vdm_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VdmOptions block(s) allowed")]
    public List<AwsSesv2ConfigurationSetVdmOptionsBlock>? VdmOptions
    {
        get => GetProperty<List<AwsSesv2ConfigurationSetVdmOptionsBlock>>("vdm_options");
        set => this.WithProperty("vdm_options", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
