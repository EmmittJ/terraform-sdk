using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sesv2_configuration_set.
/// </summary>
public partial class AwsSesv2ConfigurationSetDataSource : TerraformDataSource
{
    public AwsSesv2ConfigurationSetDataSource(string name) : base("aws_sesv2_configuration_set", name)
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
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The delivery_options attribute.
    /// </summary>
    [TerraformProperty("delivery_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DeliveryOptions { get; }

    /// <summary>
    /// The reputation_options attribute.
    /// </summary>
    [TerraformProperty("reputation_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ReputationOptions { get; }

    /// <summary>
    /// The sending_options attribute.
    /// </summary>
    [TerraformProperty("sending_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SendingOptions { get; }

    /// <summary>
    /// The suppression_options attribute.
    /// </summary>
    [TerraformProperty("suppression_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SuppressionOptions { get; }

    /// <summary>
    /// The tracking_options attribute.
    /// </summary>
    [TerraformProperty("tracking_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TrackingOptions { get; }

    /// <summary>
    /// The vdm_options attribute.
    /// </summary>
    [TerraformProperty("vdm_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> VdmOptions { get; }

}
