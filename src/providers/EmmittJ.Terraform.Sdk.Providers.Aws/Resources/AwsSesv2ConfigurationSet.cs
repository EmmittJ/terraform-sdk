using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetDeliveryOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The max_delivery_seconds attribute.
    /// </summary>
    [TerraformPropertyName("max_delivery_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxDeliverySeconds { get; set; }

    /// <summary>
    /// The sending_pool_name attribute.
    /// </summary>
    [TerraformPropertyName("sending_pool_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SendingPoolName { get; set; }

    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    [TerraformPropertyName("tls_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TlsPolicy { get; set; }

}

/// <summary>
/// Block type for reputation_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetReputationOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The last_fresh_start attribute.
    /// </summary>
    [TerraformPropertyName("last_fresh_start")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastFreshStart => new TerraformReferenceProperty<TerraformProperty<string>>("", "last_fresh_start");

    /// <summary>
    /// The reputation_metrics_enabled attribute.
    /// </summary>
    [TerraformPropertyName("reputation_metrics_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ReputationMetricsEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "reputation_metrics_enabled");

}

/// <summary>
/// Block type for sending_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetSendingOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The sending_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sending_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SendingEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "sending_enabled");

}

/// <summary>
/// Block type for suppression_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetSuppressionOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The suppressed_reasons attribute.
    /// </summary>
    [TerraformPropertyName("suppressed_reasons")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SuppressedReasons { get; set; }

}

/// <summary>
/// Block type for tracking_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetTrackingOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The custom_redirect_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomRedirectDomain is required")]
    [TerraformPropertyName("custom_redirect_domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CustomRedirectDomain { get; set; }

    /// <summary>
    /// The https_policy attribute.
    /// </summary>
    [TerraformPropertyName("https_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpsPolicy { get; set; }

}

/// <summary>
/// Block type for vdm_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetVdmOptionsBlock : ITerraformBlock
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
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    [TerraformPropertyName("configuration_set_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConfigurationSetName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for delivery_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryOptions block(s) allowed")]
    [TerraformPropertyName("delivery_options")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetDeliveryOptionsBlock>>? DeliveryOptions { get; set; } = new();

    /// <summary>
    /// Block for reputation_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReputationOptions block(s) allowed")]
    [TerraformPropertyName("reputation_options")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetReputationOptionsBlock>>? ReputationOptions { get; set; } = new();

    /// <summary>
    /// Block for sending_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SendingOptions block(s) allowed")]
    [TerraformPropertyName("sending_options")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetSendingOptionsBlock>>? SendingOptions { get; set; } = new();

    /// <summary>
    /// Block for suppression_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuppressionOptions block(s) allowed")]
    [TerraformPropertyName("suppression_options")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetSuppressionOptionsBlock>>? SuppressionOptions { get; set; } = new();

    /// <summary>
    /// Block for tracking_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrackingOptions block(s) allowed")]
    [TerraformPropertyName("tracking_options")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetTrackingOptionsBlock>>? TrackingOptions { get; set; } = new();

    /// <summary>
    /// Block for vdm_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VdmOptions block(s) allowed")]
    [TerraformPropertyName("vdm_options")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetVdmOptionsBlock>>? VdmOptions { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
