using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_shield_protection.
/// </summary>
public partial class AwsShieldProtectionDataSource : TerraformDataSource
{
    public AwsShieldProtectionDataSource(string name) : base("aws_shield_protection", name)
    {
    }

    /// <summary>
    /// The protection_id attribute.
    /// </summary>
    [TerraformProperty("protection_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ProtectionId { get; set; }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformProperty("resource_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResourceArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The protection_arn attribute.
    /// </summary>
    [TerraformProperty("protection_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProtectionArn { get; }

}
