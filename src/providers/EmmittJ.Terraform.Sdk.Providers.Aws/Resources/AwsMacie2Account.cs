using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_macie2_account resource.
/// </summary>
public class AwsMacie2Account : TerraformResource
{
    public AwsMacie2Account(string name) : base("aws_macie2_account", name)
    {
    }

    /// <summary>
    /// The finding_publishing_frequency attribute.
    /// </summary>
    [TerraformPropertyName("finding_publishing_frequency")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FindingPublishingFrequency { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "finding_publishing_frequency");

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
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Status { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [TerraformPropertyName("service_role")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceRole => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_role");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformPropertyName("updated_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "updated_at");

}
