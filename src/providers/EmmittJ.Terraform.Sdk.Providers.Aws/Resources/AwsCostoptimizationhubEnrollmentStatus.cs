using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_costoptimizationhub_enrollment_status resource.
/// </summary>
public partial class AwsCostoptimizationhubEnrollmentStatus : TerraformResource
{
    public AwsCostoptimizationhubEnrollmentStatus(string name) : base("aws_costoptimizationhub_enrollment_status", name)
    {
    }

    /// <summary>
    /// The include_member_accounts attribute.
    /// </summary>
    [TerraformProperty("include_member_accounts")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> IncludeMemberAccounts { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
