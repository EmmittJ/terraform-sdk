using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_oam_link.
/// </summary>
public partial class AwsOamLinkDataSource : TerraformDataSource
{
    public AwsOamLinkDataSource(string name) : base("aws_oam_link", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The link_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkIdentifier is required")]
    [TerraformProperty("link_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LinkIdentifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformProperty("label")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Label { get; }

    /// <summary>
    /// The label_template attribute.
    /// </summary>
    [TerraformProperty("label_template")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LabelTemplate { get; }

    /// <summary>
    /// The link_configuration attribute.
    /// </summary>
    [TerraformProperty("link_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> LinkConfiguration { get; }

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    [TerraformProperty("link_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LinkId { get; }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [TerraformProperty("resource_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> ResourceTypes { get; }

    /// <summary>
    /// The sink_arn attribute.
    /// </summary>
    [TerraformProperty("sink_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SinkArn { get; }

}
