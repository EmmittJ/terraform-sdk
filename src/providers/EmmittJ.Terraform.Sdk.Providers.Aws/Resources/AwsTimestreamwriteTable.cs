using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for magnetic_store_write_properties in AwsTimestreamwriteTable.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "magnetic_store_write_properties";

    /// <summary>
    /// The enable_magnetic_store_writes attribute.
    /// </summary>
    public TerraformValue<bool>? EnableMagneticStoreWrites
    {
        get => new TerraformReference<bool>(this, "enable_magnetic_store_writes");
        set => SetArgument("enable_magnetic_store_writes", value);
    }

    /// <summary>
    /// MagneticStoreRejectedDataLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MagneticStoreRejectedDataLocation block(s) allowed")]
    public TerraformList<AwsTimestreamwriteTableMagneticStoreWritePropertiesBlockMagneticStoreRejectedDataLocationBlock>? MagneticStoreRejectedDataLocation
    {
        get => GetArgument<TerraformList<AwsTimestreamwriteTableMagneticStoreWritePropertiesBlockMagneticStoreRejectedDataLocationBlock>>("magnetic_store_rejected_data_location");
        set => SetArgument("magnetic_store_rejected_data_location", value);
    }

}

/// <summary>
/// Block type for magnetic_store_rejected_data_location in AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableMagneticStoreWritePropertiesBlockMagneticStoreRejectedDataLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "magnetic_store_rejected_data_location";

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Configuration block(s) allowed")]
    public TerraformList<AwsTimestreamwriteTableMagneticStoreWritePropertiesBlockMagneticStoreRejectedDataLocationBlockS3ConfigurationBlock>? S3Configuration
    {
        get => GetArgument<TerraformList<AwsTimestreamwriteTableMagneticStoreWritePropertiesBlockMagneticStoreRejectedDataLocationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsTimestreamwriteTableMagneticStoreWritePropertiesBlockMagneticStoreRejectedDataLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableMagneticStoreWritePropertiesBlockMagneticStoreRejectedDataLocationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The encryption_option attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionOption
    {
        get => new TerraformReference<string>(this, "encryption_option");
        set => SetArgument("encryption_option", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The object_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ObjectKeyPrefix
    {
        get => new TerraformReference<string>(this, "object_key_prefix");
        set => SetArgument("object_key_prefix", value);
    }

}


/// <summary>
/// Block type for retention_properties in AwsTimestreamwriteTable.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableRetentionPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_properties";

    /// <summary>
    /// The magnetic_store_retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MagneticStoreRetentionPeriodInDays is required")]
    public required TerraformValue<double> MagneticStoreRetentionPeriodInDays
    {
        get => new TerraformReference<double>(this, "magnetic_store_retention_period_in_days");
        set => SetArgument("magnetic_store_retention_period_in_days", value);
    }

    /// <summary>
    /// The memory_store_retention_period_in_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryStoreRetentionPeriodInHours is required")]
    public required TerraformValue<double> MemoryStoreRetentionPeriodInHours
    {
        get => new TerraformReference<double>(this, "memory_store_retention_period_in_hours");
        set => SetArgument("memory_store_retention_period_in_hours", value);
    }

}


/// <summary>
/// Block type for schema in AwsTimestreamwriteTable.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema";

    /// <summary>
    /// CompositePartitionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CompositePartitionKey block(s) allowed")]
    public TerraformList<AwsTimestreamwriteTableSchemaBlockCompositePartitionKeyBlock>? CompositePartitionKey
    {
        get => GetArgument<TerraformList<AwsTimestreamwriteTableSchemaBlockCompositePartitionKeyBlock>>("composite_partition_key");
        set => SetArgument("composite_partition_key", value);
    }

}

/// <summary>
/// Block type for composite_partition_key in AwsTimestreamwriteTableSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsTimestreamwriteTableSchemaBlockCompositePartitionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "composite_partition_key";

    /// <summary>
    /// The enforcement_in_record attribute.
    /// </summary>
    public TerraformValue<string>? EnforcementInRecord
    {
        get => new TerraformReference<string>(this, "enforcement_in_record");
        set => SetArgument("enforcement_in_record", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_timestreamwrite_table Terraform resource.
/// Manages a aws_timestreamwrite_table resource.
/// </summary>
public partial class AwsTimestreamwriteTable(string name) : TerraformResource("aws_timestreamwrite_table", name)
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
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
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// MagneticStoreWriteProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MagneticStoreWriteProperties block(s) allowed")]
    public TerraformList<AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock>? MagneticStoreWriteProperties
    {
        get => GetArgument<TerraformList<AwsTimestreamwriteTableMagneticStoreWritePropertiesBlock>>("magnetic_store_write_properties");
        set => SetArgument("magnetic_store_write_properties", value);
    }

    /// <summary>
    /// RetentionProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionProperties block(s) allowed")]
    public TerraformList<AwsTimestreamwriteTableRetentionPropertiesBlock>? RetentionProperties
    {
        get => GetArgument<TerraformList<AwsTimestreamwriteTableRetentionPropertiesBlock>>("retention_properties");
        set => SetArgument("retention_properties", value);
    }

    /// <summary>
    /// Schema block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    public TerraformList<AwsTimestreamwriteTableSchemaBlock>? Schema
    {
        get => GetArgument<TerraformList<AwsTimestreamwriteTableSchemaBlock>>("schema");
        set => SetArgument("schema", value);
    }

}
