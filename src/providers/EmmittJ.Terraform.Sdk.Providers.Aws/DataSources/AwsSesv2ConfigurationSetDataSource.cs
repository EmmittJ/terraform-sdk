using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sesv2_configuration_set.
/// </summary>
public class AwsSesv2ConfigurationSetDataSource : TerraformDataSource
{
    public AwsSesv2ConfigurationSetDataSource(string name) : base("aws_sesv2_configuration_set", name)
    {
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    [TerraformPropertyName("configuration_set_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConfigurationSetName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The delivery_options attribute.
    /// </summary>
    [TerraformPropertyName("delivery_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DeliveryOptions => new TerraformReference(this, "delivery_options");

    /// <summary>
    /// The reputation_options attribute.
    /// </summary>
    [TerraformPropertyName("reputation_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ReputationOptions => new TerraformReference(this, "reputation_options");

    /// <summary>
    /// The sending_options attribute.
    /// </summary>
    [TerraformPropertyName("sending_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SendingOptions => new TerraformReference(this, "sending_options");

    /// <summary>
    /// The suppression_options attribute.
    /// </summary>
    [TerraformPropertyName("suppression_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SuppressionOptions => new TerraformReference(this, "suppression_options");

    /// <summary>
    /// The tracking_options attribute.
    /// </summary>
    [TerraformPropertyName("tracking_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TrackingOptions => new TerraformReference(this, "tracking_options");

    /// <summary>
    /// The vdm_options attribute.
    /// </summary>
    [TerraformPropertyName("vdm_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VdmOptions => new TerraformReference(this, "vdm_options");

}
