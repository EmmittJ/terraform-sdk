using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsShieldDrtAccessLogBucketAssociation.
/// Nesting mode: single
/// </summary>
public class AwsShieldDrtAccessLogBucketAssociationTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_shield_drt_access_log_bucket_association Terraform resource.
/// Manages a aws_shield_drt_access_log_bucket_association resource.
/// </summary>
public partial class AwsShieldDrtAccessLogBucketAssociation(string name) : TerraformResource("aws_shield_drt_access_log_bucket_association", name)
{
    /// <summary>
    /// The log_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogBucket is required")]
    public required TerraformValue<string> LogBucket
    {
        get => GetArgument<TerraformValue<string>>("log_bucket");
        set => SetArgument("log_bucket", value);
    }

    /// <summary>
    /// Unused
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArnAssociationId is required")]
    public required TerraformValue<string> RoleArnAssociationId
    {
        get => GetArgument<TerraformValue<string>>("role_arn_association_id");
        set => SetArgument("role_arn_association_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsShieldDrtAccessLogBucketAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsShieldDrtAccessLogBucketAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
