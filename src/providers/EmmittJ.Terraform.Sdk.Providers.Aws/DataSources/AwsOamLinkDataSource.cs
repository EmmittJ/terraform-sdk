using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_oam_link.
/// </summary>
public class AwsOamLinkDataSource : TerraformDataSource
{
    public AwsOamLinkDataSource(string name) : base("aws_oam_link", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The link_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkIdentifier is required")]
    [TerraformPropertyName("link_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LinkIdentifier { get; set; }

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
    /// The label attribute.
    /// </summary>
    [TerraformPropertyName("label")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Label => new TerraformReference(this, "label");

    /// <summary>
    /// The label_template attribute.
    /// </summary>
    [TerraformPropertyName("label_template")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelTemplate => new TerraformReference(this, "label_template");

    /// <summary>
    /// The link_configuration attribute.
    /// </summary>
    [TerraformPropertyName("link_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LinkConfiguration => new TerraformReference(this, "link_configuration");

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    [TerraformPropertyName("link_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LinkId => new TerraformReference(this, "link_id");

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [TerraformPropertyName("resource_types")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ResourceTypes => new TerraformReference(this, "resource_types");

    /// <summary>
    /// The sink_arn attribute.
    /// </summary>
    [TerraformPropertyName("sink_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SinkArn => new TerraformReference(this, "sink_arn");

}
