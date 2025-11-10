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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> IncludeMemberAccounts { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "include_member_accounts");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
