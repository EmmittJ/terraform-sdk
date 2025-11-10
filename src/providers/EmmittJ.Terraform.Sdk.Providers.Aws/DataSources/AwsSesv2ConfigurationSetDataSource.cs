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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The delivery_options attribute.
    /// </summary>
    [TerraformPropertyName("delivery_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DeliveryOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "delivery_options");

    /// <summary>
    /// The reputation_options attribute.
    /// </summary>
    [TerraformPropertyName("reputation_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ReputationOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "reputation_options");

    /// <summary>
    /// The sending_options attribute.
    /// </summary>
    [TerraformPropertyName("sending_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SendingOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "sending_options");

    /// <summary>
    /// The suppression_options attribute.
    /// </summary>
    [TerraformPropertyName("suppression_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SuppressionOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "suppression_options");

    /// <summary>
    /// The tracking_options attribute.
    /// </summary>
    [TerraformPropertyName("tracking_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TrackingOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "tracking_options");

    /// <summary>
    /// The vdm_options attribute.
    /// </summary>
    [TerraformPropertyName("vdm_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VdmOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vdm_options");

}
