using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsComputeoptimizerEnrollmentStatus.
/// Nesting mode: single
/// </summary>
public class AwsComputeoptimizerEnrollmentStatusTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_computeoptimizer_enrollment_status Terraform resource.
/// Manages a aws_computeoptimizer_enrollment_status resource.
/// </summary>
public partial class AwsComputeoptimizerEnrollmentStatus(string name) : TerraformResource("aws_computeoptimizer_enrollment_status", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The number_of_member_accounts_opted_in attribute.
    /// </summary>
    public TerraformValue<double> NumberOfMemberAccountsOptedIn
    {
        get => new TerraformReference<double>(this, "number_of_member_accounts_opted_in");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsComputeoptimizerEnrollmentStatusTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsComputeoptimizerEnrollmentStatusTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
