using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesv2ConfigurationSetDeliveryOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_delivery_seconds attribute.
    /// </summary>
    [TerraformProperty("max_delivery_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxDeliverySeconds { get; set; }

    /// <summary>
    /// The sending_pool_name attribute.
    /// </summary>
    [TerraformProperty("sending_pool_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SendingPoolName { get; set; }

    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    [TerraformProperty("tls_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TlsPolicy { get; set; }

}

/// <summary>
/// Block type for reputation_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesv2ConfigurationSetReputationOptionsBlock : TerraformBlockBase
{

    /// <summary>
    /// The reputation_metrics_enabled attribute.
    /// </summary>
    [TerraformProperty("reputation_metrics_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ReputationMetricsEnabled { get; set; }

}

/// <summary>
/// Block type for sending_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesv2ConfigurationSetSendingOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The sending_enabled attribute.
    /// </summary>
    [TerraformProperty("sending_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> SendingEnabled { get; set; }

}

/// <summary>
/// Block type for suppression_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesv2ConfigurationSetSuppressionOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The suppressed_reasons attribute.
    /// </summary>
    [TerraformProperty("suppressed_reasons")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SuppressedReasons { get; set; }

}

/// <summary>
/// Block type for tracking_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesv2ConfigurationSetTrackingOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The custom_redirect_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomRedirectDomain is required")]
    [TerraformProperty("custom_redirect_domain")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CustomRedirectDomain { get; set; }

    /// <summary>
    /// The https_policy attribute.
    /// </summary>
    [TerraformProperty("https_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HttpsPolicy { get; set; }

}

/// <summary>
/// Block type for vdm_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesv2ConfigurationSetVdmOptionsBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_sesv2_configuration_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSesv2ConfigurationSet : TerraformResource
{
    public AwsSesv2ConfigurationSet(string name) : base("aws_sesv2_configuration_set", name)
    {
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    [TerraformProperty("configuration_set_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConfigurationSetName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for delivery_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryOptions block(s) allowed")]
    [TerraformProperty("delivery_options")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetDeliveryOptionsBlock>>? DeliveryOptions { get; set; }

    /// <summary>
    /// Block for reputation_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReputationOptions block(s) allowed")]
    [TerraformProperty("reputation_options")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetReputationOptionsBlock>>? ReputationOptions { get; set; }

    /// <summary>
    /// Block for sending_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SendingOptions block(s) allowed")]
    [TerraformProperty("sending_options")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetSendingOptionsBlock>>? SendingOptions { get; set; }

    /// <summary>
    /// Block for suppression_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuppressionOptions block(s) allowed")]
    [TerraformProperty("suppression_options")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetSuppressionOptionsBlock>>? SuppressionOptions { get; set; }

    /// <summary>
    /// Block for tracking_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TrackingOptions block(s) allowed")]
    [TerraformProperty("tracking_options")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetTrackingOptionsBlock>>? TrackingOptions { get; set; }

    /// <summary>
    /// Block for vdm_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VdmOptions block(s) allowed")]
    [TerraformProperty("vdm_options")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetVdmOptionsBlock>>? VdmOptions { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
