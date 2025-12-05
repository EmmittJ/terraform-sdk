using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metadata_configuration in AwsS3BucketMetadataConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketMetadataConfigurationMetadataConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_configuration";

    /// <summary>
    /// The destination attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Destination
        => CreateReference("destination");

    /// <summary>
    /// InventoryTableConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketMetadataConfigurationMetadataConfigurationBlockInventoryTableConfigurationBlock>? InventoryTableConfiguration
    {
        get => GetArgument<TerraformList<AwsS3BucketMetadataConfigurationMetadataConfigurationBlockInventoryTableConfigurationBlock>>("inventory_table_configuration");
        set => SetArgument("inventory_table_configuration", value);
    }

    /// <summary>
    /// JournalTableConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketMetadataConfigurationMetadataConfigurationBlockJournalTableConfigurationBlock>? JournalTableConfiguration
    {
        get => GetArgument<TerraformList<AwsS3BucketMetadataConfigurationMetadataConfigurationBlockJournalTableConfigurationBlock>>("journal_table_configuration");
        set => SetArgument("journal_table_configuration", value);
    }

}

/// <summary>
/// Block type for inventory_table_configuration in AwsS3BucketMetadataConfigurationMetadataConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketMetadataConfigurationMetadataConfigurationBlockInventoryTableConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inventory_table_configuration";

    /// <summary>
    /// The configuration_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationState is required")]
    public required TerraformValue<string> ConfigurationState
    {
        get => GetRequiredArgument<TerraformValue<string>>("configuration_state");
        set => SetArgument("configuration_state", value);
    }

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    public TerraformValue<string> TableArn
        => CreateReference("table_arn");

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformValue<string> TableName
        => CreateReference("table_name");

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketMetadataConfigurationMetadataConfigurationBlockInventoryTableConfigurationBlockEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsS3BucketMetadataConfigurationMetadataConfigurationBlockInventoryTableConfigurationBlockEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

}

/// <summary>
/// Block type for encryption_configuration in AwsS3BucketMetadataConfigurationMetadataConfigurationBlockInventoryTableConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketMetadataConfigurationMetadataConfigurationBlockInventoryTableConfigurationBlockEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The sse_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SseAlgorithm is required")]
    public required TerraformValue<string> SseAlgorithm
    {
        get => GetRequiredArgument<TerraformValue<string>>("sse_algorithm");
        set => SetArgument("sse_algorithm", value);
    }

}

/// <summary>
/// Block type for journal_table_configuration in AwsS3BucketMetadataConfigurationMetadataConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketMetadataConfigurationMetadataConfigurationBlockJournalTableConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "journal_table_configuration";

    /// <summary>
    /// The table_arn attribute.
    /// </summary>
    public TerraformValue<string> TableArn
        => CreateReference("table_arn");

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformValue<string> TableName
        => CreateReference("table_name");

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketMetadataConfigurationMetadataConfigurationBlockJournalTableConfigurationBlockEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsS3BucketMetadataConfigurationMetadataConfigurationBlockJournalTableConfigurationBlockEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// RecordExpiration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketMetadataConfigurationMetadataConfigurationBlockJournalTableConfigurationBlockRecordExpirationBlock>? RecordExpiration
    {
        get => GetArgument<TerraformList<AwsS3BucketMetadataConfigurationMetadataConfigurationBlockJournalTableConfigurationBlockRecordExpirationBlock>>("record_expiration");
        set => SetArgument("record_expiration", value);
    }

}

/// <summary>
/// Block type for encryption_configuration in AwsS3BucketMetadataConfigurationMetadataConfigurationBlockJournalTableConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketMetadataConfigurationMetadataConfigurationBlockJournalTableConfigurationBlockEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The sse_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SseAlgorithm is required")]
    public required TerraformValue<string> SseAlgorithm
    {
        get => GetRequiredArgument<TerraformValue<string>>("sse_algorithm");
        set => SetArgument("sse_algorithm", value);
    }

}

/// <summary>
/// Block type for record_expiration in AwsS3BucketMetadataConfigurationMetadataConfigurationBlockJournalTableConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketMetadataConfigurationMetadataConfigurationBlockJournalTableConfigurationBlockRecordExpirationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record_expiration";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expiration is required")]
    public required TerraformValue<string> Expiration
    {
        get => GetRequiredArgument<TerraformValue<string>>("expiration");
        set => SetArgument("expiration", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsS3BucketMetadataConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsS3BucketMetadataConfigurationTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_s3_bucket_metadata_configuration Terraform resource.
/// Manages a aws_s3_bucket_metadata_configuration resource.
/// </summary>
public partial class AwsS3BucketMetadataConfiguration(string name) : TerraformResource("aws_s3_bucket_metadata_configuration", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// MetadataConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsS3BucketMetadataConfigurationMetadataConfigurationBlock>? MetadataConfiguration
    {
        get => GetArgument<TerraformList<AwsS3BucketMetadataConfigurationMetadataConfigurationBlock>>("metadata_configuration");
        set => SetArgument("metadata_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsS3BucketMetadataConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsS3BucketMetadataConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
