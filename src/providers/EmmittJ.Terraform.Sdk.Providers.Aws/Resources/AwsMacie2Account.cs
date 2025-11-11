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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FindingPublishingFrequency { get; set; } = default!;

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
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Status { get; set; } = default!;

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [TerraformPropertyName("service_role")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceRole => new TerraformReference(this, "service_role");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformPropertyName("updated_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdatedAt => new TerraformReference(this, "updated_at");

}
