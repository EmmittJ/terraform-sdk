using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_costoptimizationhub_enrollment_status resource.
/// </summary>
public class AwsCostoptimizationhubEnrollmentStatus : TerraformResource
{
    public AwsCostoptimizationhubEnrollmentStatus(string name) : base("aws_costoptimizationhub_enrollment_status", name)
    {
    }

    /// <summary>
    /// The include_member_accounts attribute.
    /// </summary>
    [TerraformPropertyName("include_member_accounts")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> IncludeMemberAccounts { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
