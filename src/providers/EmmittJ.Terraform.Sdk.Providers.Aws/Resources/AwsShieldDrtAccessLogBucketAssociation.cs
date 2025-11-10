using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsShieldDrtAccessLogBucketAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_shield_drt_access_log_bucket_association resource.
/// </summary>
public class AwsShieldDrtAccessLogBucketAssociation : TerraformResource
{
    public AwsShieldDrtAccessLogBucketAssociation(string name) : base("aws_shield_drt_access_log_bucket_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("log_bucket");
        SetOutput("role_arn_association_id");
    }

    /// <summary>
    /// The log_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogBucket is required")]
    public required TerraformProperty<string> LogBucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_bucket");
        set => SetProperty("log_bucket", value);
    }

    /// <summary>
    /// Unused
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArnAssociationId is required")]
    public required TerraformProperty<string> RoleArnAssociationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn_association_id");
        set => SetProperty("role_arn_association_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsShieldDrtAccessLogBucketAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
