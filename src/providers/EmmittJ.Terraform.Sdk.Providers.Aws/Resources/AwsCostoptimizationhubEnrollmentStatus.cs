using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_costoptimizationhub_enrollment_status Terraform resource.
/// Manages a aws_costoptimizationhub_enrollment_status resource.
/// </summary>
public partial class AwsCostoptimizationhubEnrollmentStatus(string name) : TerraformResource("aws_costoptimizationhub_enrollment_status", name)
{
    /// <summary>
    /// The include_member_accounts attribute.
    /// </summary>
    public TerraformValue<bool> IncludeMemberAccounts
    {
        get => new TerraformReference<bool>(this, "include_member_accounts");
        set => SetArgument("include_member_accounts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
