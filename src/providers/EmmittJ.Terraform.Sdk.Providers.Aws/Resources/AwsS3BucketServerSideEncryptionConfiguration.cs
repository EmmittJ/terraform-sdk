using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in AwsS3BucketServerSideEncryptionConfiguration.
/// Nesting mode: set
/// </summary>
public class AwsS3BucketServerSideEncryptionConfigurationRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BucketKeyEnabled
    {
        get => new TerraformReference<bool>(this, "bucket_key_enabled");
        set => SetArgument("bucket_key_enabled", value);
    }

    /// <summary>
    /// ApplyServerSideEncryptionByDefault block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplyServerSideEncryptionByDefault block(s) allowed")]
    public TerraformList<AwsS3BucketServerSideEncryptionConfigurationRuleBlockApplyServerSideEncryptionByDefaultBlock>? ApplyServerSideEncryptionByDefault
    {
        get => GetArgument<TerraformList<AwsS3BucketServerSideEncryptionConfigurationRuleBlockApplyServerSideEncryptionByDefaultBlock>>("apply_server_side_encryption_by_default");
        set => SetArgument("apply_server_side_encryption_by_default", value);
    }

}

/// <summary>
/// Block type for apply_server_side_encryption_by_default in AwsS3BucketServerSideEncryptionConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketServerSideEncryptionConfigurationRuleBlockApplyServerSideEncryptionByDefaultBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "apply_server_side_encryption_by_default";

    /// <summary>
    /// The kms_master_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsMasterKeyId
    {
        get => new TerraformReference<string>(this, "kms_master_key_id");
        set => SetArgument("kms_master_key_id", value);
    }

    /// <summary>
    /// The sse_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SseAlgorithm is required")]
    public required TerraformValue<string> SseAlgorithm
    {
        get => new TerraformReference<string>(this, "sse_algorithm");
        set => SetArgument("sse_algorithm", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket_server_side_encryption_configuration Terraform resource.
/// Manages a aws_s3_bucket_server_side_encryption_configuration resource.
/// </summary>
public partial class AwsS3BucketServerSideEncryptionConfiguration(string name) : TerraformResource("aws_s3_bucket_server_side_encryption_configuration", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformValue<string>? ExpectedBucketOwner
    {
        get => new TerraformReference<string>(this, "expected_bucket_owner");
        set => SetArgument("expected_bucket_owner", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// Rule block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public required TerraformSet<AwsS3BucketServerSideEncryptionConfigurationRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformSet<AwsS3BucketServerSideEncryptionConfigurationRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}
