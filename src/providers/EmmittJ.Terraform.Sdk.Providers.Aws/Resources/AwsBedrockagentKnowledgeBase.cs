using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for knowledge_base_configuration in AwsBedrockagentKnowledgeBase.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "knowledge_base_configuration";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// VectorKnowledgeBaseConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlock>? VectorKnowledgeBaseConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlock>>("vector_knowledge_base_configuration");
        set => SetArgument("vector_knowledge_base_configuration", value);
    }

}

/// <summary>
/// Block type for vector_knowledge_base_configuration in AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vector_knowledge_base_configuration";

    /// <summary>
    /// The embedding_model_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmbeddingModelArn is required")]
    public required TerraformValue<string> EmbeddingModelArn
    {
        get => new TerraformReference<string>(this, "embedding_model_arn");
        set => SetArgument("embedding_model_arn", value);
    }

    /// <summary>
    /// EmbeddingModelConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockEmbeddingModelConfigurationBlock>? EmbeddingModelConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockEmbeddingModelConfigurationBlock>>("embedding_model_configuration");
        set => SetArgument("embedding_model_configuration", value);
    }

    /// <summary>
    /// SupplementalDataStorageConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockSupplementalDataStorageConfigurationBlock>? SupplementalDataStorageConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockSupplementalDataStorageConfigurationBlock>>("supplemental_data_storage_configuration");
        set => SetArgument("supplemental_data_storage_configuration", value);
    }

}

/// <summary>
/// Block type for embedding_model_configuration in AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockEmbeddingModelConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "embedding_model_configuration";

    /// <summary>
    /// BedrockEmbeddingModelConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockEmbeddingModelConfigurationBlockBedrockEmbeddingModelConfigurationBlock>? BedrockEmbeddingModelConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockEmbeddingModelConfigurationBlockBedrockEmbeddingModelConfigurationBlock>>("bedrock_embedding_model_configuration");
        set => SetArgument("bedrock_embedding_model_configuration", value);
    }

}

/// <summary>
/// Block type for bedrock_embedding_model_configuration in AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockEmbeddingModelConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockEmbeddingModelConfigurationBlockBedrockEmbeddingModelConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bedrock_embedding_model_configuration";

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformValue<double>? Dimensions
    {
        get => new TerraformReference<double>(this, "dimensions");
        set => SetArgument("dimensions", value);
    }

    /// <summary>
    /// The embedding_data_type attribute.
    /// </summary>
    public TerraformValue<string>? EmbeddingDataType
    {
        get => new TerraformReference<string>(this, "embedding_data_type");
        set => SetArgument("embedding_data_type", value);
    }

}

/// <summary>
/// Block type for supplemental_data_storage_configuration in AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockSupplementalDataStorageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "supplemental_data_storage_configuration";

    /// <summary>
    /// StorageLocation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockSupplementalDataStorageConfigurationBlockStorageLocationBlock>? StorageLocation
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockSupplementalDataStorageConfigurationBlockStorageLocationBlock>>("storage_location");
        set => SetArgument("storage_location", value);
    }

}

/// <summary>
/// Block type for storage_location in AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockSupplementalDataStorageConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockSupplementalDataStorageConfigurationBlockStorageLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_location";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// S3Location block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockSupplementalDataStorageConfigurationBlockStorageLocationBlockS3LocationBlock>? S3Location
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockSupplementalDataStorageConfigurationBlockStorageLocationBlockS3LocationBlock>>("s3_location");
        set => SetArgument("s3_location", value);
    }

}

/// <summary>
/// Block type for s3_location in AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockSupplementalDataStorageConfigurationBlockStorageLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlockVectorKnowledgeBaseConfigurationBlockSupplementalDataStorageConfigurationBlockStorageLocationBlockS3LocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_location";

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for storage_configuration in AwsBedrockagentKnowledgeBase.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseStorageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_configuration";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// OpensearchServerlessConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockOpensearchServerlessConfigurationBlock>? OpensearchServerlessConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockOpensearchServerlessConfigurationBlock>>("opensearch_serverless_configuration");
        set => SetArgument("opensearch_serverless_configuration", value);
    }

    /// <summary>
    /// PineconeConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockPineconeConfigurationBlock>? PineconeConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockPineconeConfigurationBlock>>("pinecone_configuration");
        set => SetArgument("pinecone_configuration", value);
    }

    /// <summary>
    /// RdsConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRdsConfigurationBlock>? RdsConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRdsConfigurationBlock>>("rds_configuration");
        set => SetArgument("rds_configuration", value);
    }

    /// <summary>
    /// RedisEnterpriseCloudConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRedisEnterpriseCloudConfigurationBlock>? RedisEnterpriseCloudConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRedisEnterpriseCloudConfigurationBlock>>("redis_enterprise_cloud_configuration");
        set => SetArgument("redis_enterprise_cloud_configuration", value);
    }

}

/// <summary>
/// Block type for opensearch_serverless_configuration in AwsBedrockagentKnowledgeBaseStorageConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseStorageConfigurationBlockOpensearchServerlessConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "opensearch_serverless_configuration";

    /// <summary>
    /// The collection_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionArn is required")]
    public required TerraformValue<string> CollectionArn
    {
        get => new TerraformReference<string>(this, "collection_arn");
        set => SetArgument("collection_arn", value);
    }

    /// <summary>
    /// The vector_index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VectorIndexName is required")]
    public required TerraformValue<string> VectorIndexName
    {
        get => new TerraformReference<string>(this, "vector_index_name");
        set => SetArgument("vector_index_name", value);
    }

    /// <summary>
    /// FieldMapping block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockOpensearchServerlessConfigurationBlockFieldMappingBlock>? FieldMapping
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockOpensearchServerlessConfigurationBlockFieldMappingBlock>>("field_mapping");
        set => SetArgument("field_mapping", value);
    }

}

/// <summary>
/// Block type for field_mapping in AwsBedrockagentKnowledgeBaseStorageConfigurationBlockOpensearchServerlessConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseStorageConfigurationBlockOpensearchServerlessConfigurationBlockFieldMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_mapping";

    /// <summary>
    /// The metadata_field attribute.
    /// </summary>
    public TerraformValue<string>? MetadataField
    {
        get => new TerraformReference<string>(this, "metadata_field");
        set => SetArgument("metadata_field", value);
    }

    /// <summary>
    /// The text_field attribute.
    /// </summary>
    public TerraformValue<string>? TextField
    {
        get => new TerraformReference<string>(this, "text_field");
        set => SetArgument("text_field", value);
    }

    /// <summary>
    /// The vector_field attribute.
    /// </summary>
    public TerraformValue<string>? VectorField
    {
        get => new TerraformReference<string>(this, "vector_field");
        set => SetArgument("vector_field", value);
    }

}

/// <summary>
/// Block type for pinecone_configuration in AwsBedrockagentKnowledgeBaseStorageConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseStorageConfigurationBlockPineconeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pinecone_configuration";

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformValue<string> ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The credentials_secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialsSecretArn is required")]
    public required TerraformValue<string> CredentialsSecretArn
    {
        get => new TerraformReference<string>(this, "credentials_secret_arn");
        set => SetArgument("credentials_secret_arn", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// FieldMapping block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockPineconeConfigurationBlockFieldMappingBlock>? FieldMapping
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockPineconeConfigurationBlockFieldMappingBlock>>("field_mapping");
        set => SetArgument("field_mapping", value);
    }

}

/// <summary>
/// Block type for field_mapping in AwsBedrockagentKnowledgeBaseStorageConfigurationBlockPineconeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseStorageConfigurationBlockPineconeConfigurationBlockFieldMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_mapping";

    /// <summary>
    /// The metadata_field attribute.
    /// </summary>
    public TerraformValue<string>? MetadataField
    {
        get => new TerraformReference<string>(this, "metadata_field");
        set => SetArgument("metadata_field", value);
    }

    /// <summary>
    /// The text_field attribute.
    /// </summary>
    public TerraformValue<string>? TextField
    {
        get => new TerraformReference<string>(this, "text_field");
        set => SetArgument("text_field", value);
    }

}

/// <summary>
/// Block type for rds_configuration in AwsBedrockagentKnowledgeBaseStorageConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRdsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rds_configuration";

    /// <summary>
    /// The credentials_secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialsSecretArn is required")]
    public required TerraformValue<string> CredentialsSecretArn
    {
        get => new TerraformReference<string>(this, "credentials_secret_arn");
        set => SetArgument("credentials_secret_arn", value);
    }

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
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
        set => SetArgument("resource_arn", value);
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
    /// FieldMapping block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRdsConfigurationBlockFieldMappingBlock>? FieldMapping
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRdsConfigurationBlockFieldMappingBlock>>("field_mapping");
        set => SetArgument("field_mapping", value);
    }

}

/// <summary>
/// Block type for field_mapping in AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRdsConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRdsConfigurationBlockFieldMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_mapping";

    /// <summary>
    /// The metadata_field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetadataField is required")]
    public required TerraformValue<string> MetadataField
    {
        get => new TerraformReference<string>(this, "metadata_field");
        set => SetArgument("metadata_field", value);
    }

    /// <summary>
    /// The primary_key_field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryKeyField is required")]
    public required TerraformValue<string> PrimaryKeyField
    {
        get => new TerraformReference<string>(this, "primary_key_field");
        set => SetArgument("primary_key_field", value);
    }

    /// <summary>
    /// The text_field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextField is required")]
    public required TerraformValue<string> TextField
    {
        get => new TerraformReference<string>(this, "text_field");
        set => SetArgument("text_field", value);
    }

    /// <summary>
    /// The vector_field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VectorField is required")]
    public required TerraformValue<string> VectorField
    {
        get => new TerraformReference<string>(this, "vector_field");
        set => SetArgument("vector_field", value);
    }

}

/// <summary>
/// Block type for redis_enterprise_cloud_configuration in AwsBedrockagentKnowledgeBaseStorageConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRedisEnterpriseCloudConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redis_enterprise_cloud_configuration";

    /// <summary>
    /// The credentials_secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialsSecretArn is required")]
    public required TerraformValue<string> CredentialsSecretArn
    {
        get => new TerraformReference<string>(this, "credentials_secret_arn");
        set => SetArgument("credentials_secret_arn", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The vector_index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VectorIndexName is required")]
    public required TerraformValue<string> VectorIndexName
    {
        get => new TerraformReference<string>(this, "vector_index_name");
        set => SetArgument("vector_index_name", value);
    }

    /// <summary>
    /// FieldMapping block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRedisEnterpriseCloudConfigurationBlockFieldMappingBlock>? FieldMapping
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRedisEnterpriseCloudConfigurationBlockFieldMappingBlock>>("field_mapping");
        set => SetArgument("field_mapping", value);
    }

}

/// <summary>
/// Block type for field_mapping in AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRedisEnterpriseCloudConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentKnowledgeBaseStorageConfigurationBlockRedisEnterpriseCloudConfigurationBlockFieldMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_mapping";

    /// <summary>
    /// The metadata_field attribute.
    /// </summary>
    public TerraformValue<string>? MetadataField
    {
        get => new TerraformReference<string>(this, "metadata_field");
        set => SetArgument("metadata_field", value);
    }

    /// <summary>
    /// The text_field attribute.
    /// </summary>
    public TerraformValue<string>? TextField
    {
        get => new TerraformReference<string>(this, "text_field");
        set => SetArgument("text_field", value);
    }

    /// <summary>
    /// The vector_field attribute.
    /// </summary>
    public TerraformValue<string>? VectorField
    {
        get => new TerraformReference<string>(this, "vector_field");
        set => SetArgument("vector_field", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBedrockagentKnowledgeBase.
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentKnowledgeBaseTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_bedrockagent_knowledge_base Terraform resource.
/// Manages a aws_bedrockagent_knowledge_base resource.
/// </summary>
public partial class AwsBedrockagentKnowledgeBase(string name) : TerraformResource("aws_bedrockagent_knowledge_base", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The failure_reasons attribute.
    /// </summary>
    public TerraformList<string> FailureReasons
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "failure_reasons").ResolveNodes(ctx));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
    {
        get => new TerraformReference<string>(this, "updated_at");
    }

    /// <summary>
    /// KnowledgeBaseConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlock>? KnowledgeBaseConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseKnowledgeBaseConfigurationBlock>>("knowledge_base_configuration");
        set => SetArgument("knowledge_base_configuration", value);
    }

    /// <summary>
    /// StorageConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlock>? StorageConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentKnowledgeBaseStorageConfigurationBlock>>("storage_configuration");
        set => SetArgument("storage_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockagentKnowledgeBaseTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockagentKnowledgeBaseTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
