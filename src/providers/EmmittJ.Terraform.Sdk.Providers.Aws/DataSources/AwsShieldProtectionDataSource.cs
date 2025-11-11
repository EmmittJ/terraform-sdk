using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_shield_protection.
/// </summary>
public class AwsShieldProtectionDataSource : TerraformDataSource
{
    public AwsShieldProtectionDataSource(string name) : base("aws_shield_protection", name)
    {
    }

    /// <summary>
    /// The protection_id attribute.
    /// </summary>
    [TerraformPropertyName("protection_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ProtectionId { get; set; } = default!;

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformPropertyName("resource_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ResourceArn { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The protection_arn attribute.
    /// </summary>
    [TerraformPropertyName("protection_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProtectionArn => new TerraformReference(this, "protection_arn");

}
