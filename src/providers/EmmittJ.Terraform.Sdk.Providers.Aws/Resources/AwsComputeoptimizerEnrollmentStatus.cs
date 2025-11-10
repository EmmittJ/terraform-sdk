using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsComputeoptimizerEnrollmentStatusTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_computeoptimizer_enrollment_status resource.
/// </summary>
public class AwsComputeoptimizerEnrollmentStatus : TerraformResource
{
    public AwsComputeoptimizerEnrollmentStatus(string name) : base("aws_computeoptimizer_enrollment_status", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputd");
        this.WithOutputumber_of_member_accounts_opted_in");
    }

    /// <summary>
    /// The include_member_accounts attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeMemberAccounts
    {
        get => GetProperty<TerraformProperty<bool>>("include_member_accounts");
        set => this.WithProperty("include_member_accounts", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformProperty<string> Status
    {
        get => GetRequiredProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsComputeoptimizerEnrollmentStatusTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsComputeoptimizerEnrollmentStatusTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The number_of_member_accounts_opted_in attribute.
    /// </summary>
    public TerraformExpression NumberOfMemberAccountsOptedIn => this["number_of_member_accounts_opted_in"];

}
