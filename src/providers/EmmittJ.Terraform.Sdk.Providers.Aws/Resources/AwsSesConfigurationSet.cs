using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesConfigurationSetDeliveryOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    [TerraformProperty("tls_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TlsPolicy { get; set; }

}

/// <summary>
/// Block type for tracking_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesConfigurationSetTrackingOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The custom_redirect_domain attribute.
    /// </summary>
    [TerraformProperty("custom_redirect_domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomRedirectDomain { get; set; }

}

/// <summary>
/// Manages a aws_ses_configuration_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSesConfigurationSet : TerraformResource
{
    public AwsSesConfigurationSet(string name) : base("aws_ses_configuration_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The reputation_metrics_enabled attribute.
    /// </summary>
    [TerraformProperty("reputation_metrics_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReputationMetricsEnabled { get; set; }

    /// <summary>
    /// The sending_enabled attribute.
    /// </summary>
    [TerraformProperty("sending_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SendingEnabled { get; set; }

    /// <summary>
    /// Block for delivery_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryOptions block(s) allowed")]
    [TerraformProperty("delivery_options")]
    public partial TerraformList<TerraformBlock<AwsSesConfigurationSetDeliveryOptionsBlock>>? DeliveryOptions { get; set; }

    /// <summary>
    /// Block for tracking_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrackingOptions block(s) allowed")]
    [TerraformProperty("tracking_options")]
    public partial TerraformList<TerraformBlock<AwsSesConfigurationSetTrackingOptionsBlock>>? TrackingOptions { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The last_fresh_start attribute.
    /// </summary>
    [TerraformProperty("last_fresh_start")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastFreshStart { get; }

}
