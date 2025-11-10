using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesConfigurationSetDeliveryOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    [TerraformPropertyName("tls_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TlsPolicy { get; set; }

}

/// <summary>
/// Block type for tracking_options in .
/// Nesting mode: list
/// </summary>
public class AwsSesConfigurationSetTrackingOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The custom_redirect_domain attribute.
    /// </summary>
    [TerraformPropertyName("custom_redirect_domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomRedirectDomain { get; set; }

}

/// <summary>
/// Manages a aws_ses_configuration_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSesConfigurationSet : TerraformResource
{
    public AwsSesConfigurationSet(string name) : base("aws_ses_configuration_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The reputation_metrics_enabled attribute.
    /// </summary>
    [TerraformPropertyName("reputation_metrics_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ReputationMetricsEnabled { get; set; }

    /// <summary>
    /// The sending_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sending_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SendingEnabled { get; set; }

    /// <summary>
    /// Block for delivery_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryOptions block(s) allowed")]
    [TerraformPropertyName("delivery_options")]
    public TerraformList<TerraformBlock<AwsSesConfigurationSetDeliveryOptionsBlock>>? DeliveryOptions { get; set; } = new();

    /// <summary>
    /// Block for tracking_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrackingOptions block(s) allowed")]
    [TerraformPropertyName("tracking_options")]
    public TerraformList<TerraformBlock<AwsSesConfigurationSetTrackingOptionsBlock>>? TrackingOptions { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The last_fresh_start attribute.
    /// </summary>
    [TerraformPropertyName("last_fresh_start")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastFreshStart => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_fresh_start");

}
