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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The link_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkIdentifier is required")]
    [TerraformPropertyName("link_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LinkIdentifier { get; set; }

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
    /// The label attribute.
    /// </summary>
    [TerraformPropertyName("label")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Label => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "label");

    /// <summary>
    /// The label_template attribute.
    /// </summary>
    [TerraformPropertyName("label_template")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LabelTemplate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "label_template");

    /// <summary>
    /// The link_configuration attribute.
    /// </summary>
    [TerraformPropertyName("link_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LinkConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "link_configuration");

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    [TerraformPropertyName("link_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LinkId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "link_id");

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    [TerraformPropertyName("resource_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ResourceTypes => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "resource_types");

    /// <summary>
    /// The sink_arn attribute.
    /// </summary>
    [TerraformPropertyName("sink_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SinkArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sink_arn");

}
