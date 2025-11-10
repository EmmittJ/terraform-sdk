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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ProtectionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protection_id");

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformPropertyName("resource_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ResourceArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The protection_arn attribute.
    /// </summary>
    [TerraformPropertyName("protection_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProtectionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protection_arn");

}
