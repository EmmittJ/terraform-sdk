using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in AwsGlueSecurityConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsGlueSecurityConfigurationEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// CloudwatchEncryption block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchEncryption is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CloudwatchEncryption block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchEncryption block(s) allowed")]
    public required TerraformList<AwsGlueSecurityConfigurationEncryptionConfigurationBlockCloudwatchEncryptionBlock> CloudwatchEncryption
    {
        get => GetRequiredArgument<TerraformList<AwsGlueSecurityConfigurationEncryptionConfigurationBlockCloudwatchEncryptionBlock>>("cloudwatch_encryption");
        set => SetArgument("cloudwatch_encryption", value);
    }

    /// <summary>
    /// JobBookmarksEncryption block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobBookmarksEncryption is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 JobBookmarksEncryption block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobBookmarksEncryption block(s) allowed")]
    public required TerraformList<AwsGlueSecurityConfigurationEncryptionConfigurationBlockJobBookmarksEncryptionBlock> JobBookmarksEncryption
    {
        get => GetRequiredArgument<TerraformList<AwsGlueSecurityConfigurationEncryptionConfigurationBlockJobBookmarksEncryptionBlock>>("job_bookmarks_encryption");
        set => SetArgument("job_bookmarks_encryption", value);
    }

    /// <summary>
    /// S3Encryption block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Encryption is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Encryption block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Encryption block(s) allowed")]
    public required TerraformList<AwsGlueSecurityConfigurationEncryptionConfigurationBlockS3EncryptionBlock> S3Encryption
    {
        get => GetRequiredArgument<TerraformList<AwsGlueSecurityConfigurationEncryptionConfigurationBlockS3EncryptionBlock>>("s3_encryption");
        set => SetArgument("s3_encryption", value);
    }

}

/// <summary>
/// Block type for cloudwatch_encryption in AwsGlueSecurityConfigurationEncryptionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueSecurityConfigurationEncryptionConfigurationBlockCloudwatchEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_encryption";

    /// <summary>
    /// The cloudwatch_encryption_mode attribute.
    /// </summary>
    public TerraformValue<string>? CloudwatchEncryptionMode
    {
        get => GetArgument<TerraformValue<string>>("cloudwatch_encryption_mode");
        set => SetArgument("cloudwatch_encryption_mode", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}

/// <summary>
/// Block type for job_bookmarks_encryption in AwsGlueSecurityConfigurationEncryptionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueSecurityConfigurationEncryptionConfigurationBlockJobBookmarksEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "job_bookmarks_encryption";

    /// <summary>
    /// The job_bookmarks_encryption_mode attribute.
    /// </summary>
    public TerraformValue<string>? JobBookmarksEncryptionMode
    {
        get => GetArgument<TerraformValue<string>>("job_bookmarks_encryption_mode");
        set => SetArgument("job_bookmarks_encryption_mode", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}

/// <summary>
/// Block type for s3_encryption in AwsGlueSecurityConfigurationEncryptionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueSecurityConfigurationEncryptionConfigurationBlockS3EncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_encryption";

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The s3_encryption_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3EncryptionMode
    {
        get => GetArgument<TerraformValue<string>>("s3_encryption_mode");
        set => SetArgument("s3_encryption_mode", value);
    }

}


/// <summary>
/// Represents a aws_glue_security_configuration Terraform resource.
/// Manages a aws_glue_security_configuration resource.
/// </summary>
public partial class AwsGlueSecurityConfiguration(string name) : TerraformResource("aws_glue_security_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncryptionConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public required TerraformList<AwsGlueSecurityConfigurationEncryptionConfigurationBlock> EncryptionConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsGlueSecurityConfigurationEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

}
