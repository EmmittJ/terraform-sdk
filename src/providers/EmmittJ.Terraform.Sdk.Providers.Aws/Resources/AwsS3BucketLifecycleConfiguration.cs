using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in AwsS3BucketLifecycleConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLifecycleConfigurationRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix") ?? AsReference("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => GetRequiredArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// AbortIncompleteMultipartUpload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketLifecycleConfigurationRuleBlockAbortIncompleteMultipartUploadBlock>? AbortIncompleteMultipartUpload
    {
        get => GetArgument<TerraformList<AwsS3BucketLifecycleConfigurationRuleBlockAbortIncompleteMultipartUploadBlock>>("abort_incomplete_multipart_upload");
        set => SetArgument("abort_incomplete_multipart_upload", value);
    }

    /// <summary>
    /// Expiration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketLifecycleConfigurationRuleBlockExpirationBlock>? Expiration
    {
        get => GetArgument<TerraformList<AwsS3BucketLifecycleConfigurationRuleBlockExpirationBlock>>("expiration");
        set => SetArgument("expiration", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketLifecycleConfigurationRuleBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsS3BucketLifecycleConfigurationRuleBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// NoncurrentVersionExpiration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketLifecycleConfigurationRuleBlockNoncurrentVersionExpirationBlock>? NoncurrentVersionExpiration
    {
        get => GetArgument<TerraformList<AwsS3BucketLifecycleConfigurationRuleBlockNoncurrentVersionExpirationBlock>>("noncurrent_version_expiration");
        set => SetArgument("noncurrent_version_expiration", value);
    }

    /// <summary>
    /// NoncurrentVersionTransition block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsS3BucketLifecycleConfigurationRuleBlockNoncurrentVersionTransitionBlock>? NoncurrentVersionTransition
    {
        get => GetArgument<TerraformSet<AwsS3BucketLifecycleConfigurationRuleBlockNoncurrentVersionTransitionBlock>>("noncurrent_version_transition");
        set => SetArgument("noncurrent_version_transition", value);
    }

    /// <summary>
    /// Transition block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsS3BucketLifecycleConfigurationRuleBlockTransitionBlock>? Transition
    {
        get => GetArgument<TerraformSet<AwsS3BucketLifecycleConfigurationRuleBlockTransitionBlock>>("transition");
        set => SetArgument("transition", value);
    }

}

/// <summary>
/// Block type for abort_incomplete_multipart_upload in AwsS3BucketLifecycleConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLifecycleConfigurationRuleBlockAbortIncompleteMultipartUploadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "abort_incomplete_multipart_upload";

    /// <summary>
    /// The days_after_initiation attribute.
    /// </summary>
    public TerraformValue<double>? DaysAfterInitiation
    {
        get => GetArgument<TerraformValue<double>>("days_after_initiation");
        set => SetArgument("days_after_initiation", value);
    }

}

/// <summary>
/// Block type for expiration in AwsS3BucketLifecycleConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLifecycleConfigurationRuleBlockExpirationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expiration";

    /// <summary>
    /// The date attribute.
    /// </summary>
    public TerraformValue<string>? Date
    {
        get => GetArgument<TerraformValue<string>>("date");
        set => SetArgument("date", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double> Days
    {
        get => GetArgument<TerraformValue<double>>("days") ?? AsReference("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The expired_object_delete_marker attribute.
    /// </summary>
    public TerraformValue<bool> ExpiredObjectDeleteMarker
    {
        get => GetArgument<TerraformValue<bool>>("expired_object_delete_marker") ?? AsReference("expired_object_delete_marker");
        set => SetArgument("expired_object_delete_marker", value);
    }

}

/// <summary>
/// Block type for filter in AwsS3BucketLifecycleConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLifecycleConfigurationRuleBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The object_size_greater_than attribute.
    /// </summary>
    public TerraformValue<double> ObjectSizeGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("object_size_greater_than") ?? AsReference("object_size_greater_than");
        set => SetArgument("object_size_greater_than", value);
    }

    /// <summary>
    /// The object_size_less_than attribute.
    /// </summary>
    public TerraformValue<double> ObjectSizeLessThan
    {
        get => GetArgument<TerraformValue<double>>("object_size_less_than") ?? AsReference("object_size_less_than");
        set => SetArgument("object_size_less_than", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string> Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix") ?? AsReference("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// And block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketLifecycleConfigurationRuleBlockFilterBlockAndBlock>? And
    {
        get => GetArgument<TerraformList<AwsS3BucketLifecycleConfigurationRuleBlockFilterBlockAndBlock>>("and");
        set => SetArgument("and", value);
    }

    /// <summary>
    /// Tag block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketLifecycleConfigurationRuleBlockFilterBlockTagBlock>? Tag
    {
        get => GetArgument<TerraformList<AwsS3BucketLifecycleConfigurationRuleBlockFilterBlockTagBlock>>("tag");
        set => SetArgument("tag", value);
    }

}

/// <summary>
/// Block type for and in AwsS3BucketLifecycleConfigurationRuleBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLifecycleConfigurationRuleBlockFilterBlockAndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "and";

    /// <summary>
    /// The object_size_greater_than attribute.
    /// </summary>
    public TerraformValue<double> ObjectSizeGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("object_size_greater_than") ?? AsReference("object_size_greater_than");
        set => SetArgument("object_size_greater_than", value);
    }

    /// <summary>
    /// The object_size_less_than attribute.
    /// </summary>
    public TerraformValue<double> ObjectSizeLessThan
    {
        get => GetArgument<TerraformValue<double>>("object_size_less_than") ?? AsReference("object_size_less_than");
        set => SetArgument("object_size_less_than", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string> Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix") ?? AsReference("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for tag in AwsS3BucketLifecycleConfigurationRuleBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLifecycleConfigurationRuleBlockFilterBlockTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for noncurrent_version_expiration in AwsS3BucketLifecycleConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLifecycleConfigurationRuleBlockNoncurrentVersionExpirationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "noncurrent_version_expiration";

    /// <summary>
    /// The newer_noncurrent_versions attribute.
    /// </summary>
    public TerraformValue<double>? NewerNoncurrentVersions
    {
        get => GetArgument<TerraformValue<double>>("newer_noncurrent_versions");
        set => SetArgument("newer_noncurrent_versions", value);
    }

    /// <summary>
    /// The noncurrent_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NoncurrentDays is required")]
    public required TerraformValue<double> NoncurrentDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("noncurrent_days");
        set => SetArgument("noncurrent_days", value);
    }

}

/// <summary>
/// Block type for noncurrent_version_transition in AwsS3BucketLifecycleConfigurationRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsS3BucketLifecycleConfigurationRuleBlockNoncurrentVersionTransitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "noncurrent_version_transition";

    /// <summary>
    /// The newer_noncurrent_versions attribute.
    /// </summary>
    public TerraformValue<double>? NewerNoncurrentVersions
    {
        get => GetArgument<TerraformValue<double>>("newer_noncurrent_versions");
        set => SetArgument("newer_noncurrent_versions", value);
    }

    /// <summary>
    /// The noncurrent_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NoncurrentDays is required")]
    public required TerraformValue<double> NoncurrentDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("noncurrent_days");
        set => SetArgument("noncurrent_days", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformValue<string> StorageClass
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

}

/// <summary>
/// Block type for transition in AwsS3BucketLifecycleConfigurationRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsS3BucketLifecycleConfigurationRuleBlockTransitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transition";

    /// <summary>
    /// The date attribute.
    /// </summary>
    public TerraformValue<string>? Date
    {
        get => GetArgument<TerraformValue<string>>("date");
        set => SetArgument("date", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double> Days
    {
        get => GetArgument<TerraformValue<double>>("days") ?? AsReference("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformValue<string> StorageClass
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsS3BucketLifecycleConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsS3BucketLifecycleConfigurationTimeoutsBlock : TerraformBlock
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
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket_lifecycle_configuration Terraform resource.
/// Manages a aws_s3_bucket_lifecycle_configuration resource.
/// </summary>
public partial class AwsS3BucketLifecycleConfiguration(string name) : TerraformResource("aws_s3_bucket_lifecycle_configuration", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformValue<string> ExpectedBucketOwner
    {
        get => GetArgument<TerraformValue<string>>("expected_bucket_owner") ?? AsReference("expected_bucket_owner");
        set => SetArgument("expected_bucket_owner", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The transition_default_minimum_object_size attribute.
    /// </summary>
    public TerraformValue<string> TransitionDefaultMinimumObjectSize
    {
        get => GetArgument<TerraformValue<string>>("transition_default_minimum_object_size") ?? AsReference("transition_default_minimum_object_size");
        set => SetArgument("transition_default_minimum_object_size", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// Rule block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketLifecycleConfigurationRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AwsS3BucketLifecycleConfigurationRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsS3BucketLifecycleConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsS3BucketLifecycleConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
