using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for feature_definition in AwsSagemakerFeatureGroup.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupFeatureDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "feature_definition";

    /// <summary>
    /// The collection_type attribute.
    /// </summary>
    public TerraformValue<string>? CollectionType
    {
        get => GetArgument<TerraformValue<string>>("collection_type");
        set => SetArgument("collection_type", value);
    }

    /// <summary>
    /// The feature_name attribute.
    /// </summary>
    public TerraformValue<string>? FeatureName
    {
        get => GetArgument<TerraformValue<string>>("feature_name");
        set => SetArgument("feature_name", value);
    }

    /// <summary>
    /// The feature_type attribute.
    /// </summary>
    public TerraformValue<string>? FeatureType
    {
        get => GetArgument<TerraformValue<string>>("feature_type");
        set => SetArgument("feature_type", value);
    }

    /// <summary>
    /// CollectionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CollectionConfig block(s) allowed")]
    public TerraformList<AwsSagemakerFeatureGroupFeatureDefinitionBlockCollectionConfigBlock>? CollectionConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerFeatureGroupFeatureDefinitionBlockCollectionConfigBlock>>("collection_config");
        set => SetArgument("collection_config", value);
    }

}

/// <summary>
/// Block type for collection_config in AwsSagemakerFeatureGroupFeatureDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupFeatureDefinitionBlockCollectionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "collection_config";

    /// <summary>
    /// VectorConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VectorConfig block(s) allowed")]
    public TerraformList<AwsSagemakerFeatureGroupFeatureDefinitionBlockCollectionConfigBlockVectorConfigBlock>? VectorConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerFeatureGroupFeatureDefinitionBlockCollectionConfigBlockVectorConfigBlock>>("vector_config");
        set => SetArgument("vector_config", value);
    }

}

/// <summary>
/// Block type for vector_config in AwsSagemakerFeatureGroupFeatureDefinitionBlockCollectionConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupFeatureDefinitionBlockCollectionConfigBlockVectorConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vector_config";

    /// <summary>
    /// The dimension attribute.
    /// </summary>
    public TerraformValue<double>? Dimension
    {
        get => GetArgument<TerraformValue<double>>("dimension");
        set => SetArgument("dimension", value);
    }

}


/// <summary>
/// Block type for offline_store_config in AwsSagemakerFeatureGroup.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupOfflineStoreConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "offline_store_config";

    /// <summary>
    /// The disable_glue_table_creation attribute.
    /// </summary>
    public TerraformValue<bool>? DisableGlueTableCreation
    {
        get => GetArgument<TerraformValue<bool>>("disable_glue_table_creation");
        set => SetArgument("disable_glue_table_creation", value);
    }

    /// <summary>
    /// The table_format attribute.
    /// </summary>
    public TerraformValue<string>? TableFormat
    {
        get => GetArgument<TerraformValue<string>>("table_format");
        set => SetArgument("table_format", value);
    }

    /// <summary>
    /// DataCatalogConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCatalogConfig block(s) allowed")]
    public TerraformList<AwsSagemakerFeatureGroupOfflineStoreConfigBlockDataCatalogConfigBlock>? DataCatalogConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerFeatureGroupOfflineStoreConfigBlockDataCatalogConfigBlock>>("data_catalog_config");
        set => SetArgument("data_catalog_config", value);
    }

    /// <summary>
    /// S3StorageConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3StorageConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3StorageConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3StorageConfig block(s) allowed")]
    public required TerraformList<AwsSagemakerFeatureGroupOfflineStoreConfigBlockS3StorageConfigBlock> S3StorageConfig
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerFeatureGroupOfflineStoreConfigBlockS3StorageConfigBlock>>("s3_storage_config");
        set => SetArgument("s3_storage_config", value);
    }

}

/// <summary>
/// Block type for data_catalog_config in AwsSagemakerFeatureGroupOfflineStoreConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupOfflineStoreConfigBlockDataCatalogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_catalog_config";

    /// <summary>
    /// The catalog attribute.
    /// </summary>
    public TerraformValue<string> Catalog
    {
        get => GetArgument<TerraformValue<string>>("catalog") ?? AsReference("catalog");
        set => SetArgument("catalog", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    public TerraformValue<string> Database
    {
        get => GetArgument<TerraformValue<string>>("database") ?? AsReference("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformValue<string> TableName
    {
        get => GetArgument<TerraformValue<string>>("table_name") ?? AsReference("table_name");
        set => SetArgument("table_name", value);
    }

}

/// <summary>
/// Block type for s3_storage_config in AwsSagemakerFeatureGroupOfflineStoreConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupOfflineStoreConfigBlockS3StorageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_storage_config";

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The resolved_output_s3_uri attribute.
    /// </summary>
    public TerraformValue<string> ResolvedOutputS3Uri
    {
        get => GetArgument<TerraformValue<string>>("resolved_output_s3_uri") ?? AsReference("resolved_output_s3_uri");
        set => SetArgument("resolved_output_s3_uri", value);
    }

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformValue<string> S3Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_uri");
        set => SetArgument("s3_uri", value);
    }

}


/// <summary>
/// Block type for online_store_config in AwsSagemakerFeatureGroup.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupOnlineStoreConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "online_store_config";

    /// <summary>
    /// The enable_online_store attribute.
    /// </summary>
    public TerraformValue<bool>? EnableOnlineStore
    {
        get => GetArgument<TerraformValue<bool>>("enable_online_store");
        set => SetArgument("enable_online_store", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageType
    {
        get => GetArgument<TerraformValue<string>>("storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// SecurityConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityConfig block(s) allowed")]
    public TerraformList<AwsSagemakerFeatureGroupOnlineStoreConfigBlockSecurityConfigBlock>? SecurityConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerFeatureGroupOnlineStoreConfigBlockSecurityConfigBlock>>("security_config");
        set => SetArgument("security_config", value);
    }

    /// <summary>
    /// TtlDuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TtlDuration block(s) allowed")]
    public TerraformList<AwsSagemakerFeatureGroupOnlineStoreConfigBlockTtlDurationBlock>? TtlDuration
    {
        get => GetArgument<TerraformList<AwsSagemakerFeatureGroupOnlineStoreConfigBlockTtlDurationBlock>>("ttl_duration");
        set => SetArgument("ttl_duration", value);
    }

}

/// <summary>
/// Block type for security_config in AwsSagemakerFeatureGroupOnlineStoreConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupOnlineStoreConfigBlockSecurityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_config";

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

}

/// <summary>
/// Block type for ttl_duration in AwsSagemakerFeatureGroupOnlineStoreConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupOnlineStoreConfigBlockTtlDurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ttl_duration";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => GetArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<double>? Value
    {
        get => GetArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for throughput_config in AwsSagemakerFeatureGroup.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerFeatureGroupThroughputConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "throughput_config";

    /// <summary>
    /// The provisioned_read_capacity_units attribute.
    /// </summary>
    public TerraformValue<double>? ProvisionedReadCapacityUnits
    {
        get => GetArgument<TerraformValue<double>>("provisioned_read_capacity_units");
        set => SetArgument("provisioned_read_capacity_units", value);
    }

    /// <summary>
    /// The provisioned_write_capacity_units attribute.
    /// </summary>
    public TerraformValue<double>? ProvisionedWriteCapacityUnits
    {
        get => GetArgument<TerraformValue<double>>("provisioned_write_capacity_units");
        set => SetArgument("provisioned_write_capacity_units", value);
    }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformValue<string> ThroughputMode
    {
        get => GetArgument<TerraformValue<string>>("throughput_mode") ?? AsReference("throughput_mode");
        set => SetArgument("throughput_mode", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_feature_group Terraform resource.
/// Manages a aws_sagemaker_feature_group resource.
/// </summary>
public partial class AwsSagemakerFeatureGroup(string name) : TerraformResource("aws_sagemaker_feature_group", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The event_time_feature_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventTimeFeatureName is required")]
    public required TerraformValue<string> EventTimeFeatureName
    {
        get => GetRequiredArgument<TerraformValue<string>>("event_time_feature_name");
        set => SetArgument("event_time_feature_name", value);
    }

    /// <summary>
    /// The feature_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureGroupName is required")]
    public required TerraformValue<string> FeatureGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("feature_group_name");
        set => SetArgument("feature_group_name", value);
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
    /// The record_identifier_feature_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordIdentifierFeatureName is required")]
    public required TerraformValue<string> RecordIdentifierFeatureName
    {
        get => GetRequiredArgument<TerraformValue<string>>("record_identifier_feature_name");
        set => SetArgument("record_identifier_feature_name", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// FeatureDefinition block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FeatureDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2500, ErrorMessage = "Maximum 2500 FeatureDefinition block(s) allowed")]
    public required TerraformList<AwsSagemakerFeatureGroupFeatureDefinitionBlock> FeatureDefinition
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerFeatureGroupFeatureDefinitionBlock>>("feature_definition");
        set => SetArgument("feature_definition", value);
    }

    /// <summary>
    /// OfflineStoreConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OfflineStoreConfig block(s) allowed")]
    public TerraformList<AwsSagemakerFeatureGroupOfflineStoreConfigBlock>? OfflineStoreConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerFeatureGroupOfflineStoreConfigBlock>>("offline_store_config");
        set => SetArgument("offline_store_config", value);
    }

    /// <summary>
    /// OnlineStoreConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnlineStoreConfig block(s) allowed")]
    public TerraformList<AwsSagemakerFeatureGroupOnlineStoreConfigBlock>? OnlineStoreConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerFeatureGroupOnlineStoreConfigBlock>>("online_store_config");
        set => SetArgument("online_store_config", value);
    }

    /// <summary>
    /// ThroughputConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThroughputConfig block(s) allowed")]
    public TerraformList<AwsSagemakerFeatureGroupThroughputConfigBlock>? ThroughputConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerFeatureGroupThroughputConfigBlock>>("throughput_config");
        set => SetArgument("throughput_config", value);
    }

}
