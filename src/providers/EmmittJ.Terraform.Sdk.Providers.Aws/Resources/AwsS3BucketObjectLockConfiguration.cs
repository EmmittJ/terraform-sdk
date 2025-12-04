using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in AwsS3BucketObjectLockConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketObjectLockConfigurationRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// DefaultRetention block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRetention is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultRetention block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRetention block(s) allowed")]
    public required TerraformList<AwsS3BucketObjectLockConfigurationRuleBlockDefaultRetentionBlock> DefaultRetention
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketObjectLockConfigurationRuleBlockDefaultRetentionBlock>>("default_retention");
        set => SetArgument("default_retention", value);
    }

}

/// <summary>
/// Block type for default_retention in AwsS3BucketObjectLockConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketObjectLockConfigurationRuleBlockDefaultRetentionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_retention";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The years attribute.
    /// </summary>
    public TerraformValue<double>? Years
    {
        get => GetArgument<TerraformValue<double>>("years");
        set => SetArgument("years", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket_object_lock_configuration Terraform resource.
/// Manages a aws_s3_bucket_object_lock_configuration resource.
/// </summary>
public partial class AwsS3BucketObjectLockConfiguration(string name) : TerraformResource("aws_s3_bucket_object_lock_configuration", name)
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
    public TerraformValue<string>? ExpectedBucketOwner
    {
        get => GetArgument<TerraformValue<string>>("expected_bucket_owner");
        set => SetArgument("expected_bucket_owner", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object_lock_enabled attribute.
    /// </summary>
    public TerraformValue<string>? ObjectLockEnabled
    {
        get => GetArgument<TerraformValue<string>>("object_lock_enabled");
        set => SetArgument("object_lock_enabled", value);
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
    /// The token attribute.
    /// </summary>
    public TerraformValue<string>? Token
    {
        get => GetArgument<TerraformValue<string>>("token");
        set => SetArgument("token", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rule block(s) allowed")]
    public TerraformList<AwsS3BucketObjectLockConfigurationRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AwsS3BucketObjectLockConfigurationRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}
