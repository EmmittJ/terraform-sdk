using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for catalog_target in AwsGlueCrawler.
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerCatalogTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "catalog_target";

    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionName
    {
        get => GetArgument<TerraformValue<string>>("connection_name");
        set => SetArgument("connection_name", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The dlq_event_queue_arn attribute.
    /// </summary>
    public TerraformValue<string>? DlqEventQueueArn
    {
        get => GetArgument<TerraformValue<string>>("dlq_event_queue_arn");
        set => SetArgument("dlq_event_queue_arn", value);
    }

    /// <summary>
    /// The event_queue_arn attribute.
    /// </summary>
    public TerraformValue<string>? EventQueueArn
    {
        get => GetArgument<TerraformValue<string>>("event_queue_arn");
        set => SetArgument("event_queue_arn", value);
    }

    /// <summary>
    /// The tables attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tables is required")]
    public TerraformList<string>? Tables
    {
        get => GetArgument<TerraformList<string>>("tables");
        set => SetArgument("tables", value);
    }

}


/// <summary>
/// Block type for delta_target in AwsGlueCrawler.
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerDeltaTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delta_target";

    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionName
    {
        get => GetArgument<TerraformValue<string>>("connection_name");
        set => SetArgument("connection_name", value);
    }

    /// <summary>
    /// The create_native_delta_table attribute.
    /// </summary>
    public TerraformValue<bool>? CreateNativeDeltaTable
    {
        get => GetArgument<TerraformValue<bool>>("create_native_delta_table");
        set => SetArgument("create_native_delta_table", value);
    }

    /// <summary>
    /// The delta_tables attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeltaTables is required")]
    public required TerraformSet<string> DeltaTables
    {
        get => GetArgument<TerraformSet<string>>("delta_tables");
        set => SetArgument("delta_tables", value);
    }

    /// <summary>
    /// The write_manifest attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WriteManifest is required")]
    public required TerraformValue<bool> WriteManifest
    {
        get => GetArgument<TerraformValue<bool>>("write_manifest");
        set => SetArgument("write_manifest", value);
    }

}


/// <summary>
/// Block type for dynamodb_target in AwsGlueCrawler.
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerDynamodbTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamodb_target";

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The scan_all attribute.
    /// </summary>
    public TerraformValue<bool>? ScanAll
    {
        get => GetArgument<TerraformValue<bool>>("scan_all");
        set => SetArgument("scan_all", value);
    }

    /// <summary>
    /// The scan_rate attribute.
    /// </summary>
    public TerraformValue<double>? ScanRate
    {
        get => GetArgument<TerraformValue<double>>("scan_rate");
        set => SetArgument("scan_rate", value);
    }

}


/// <summary>
/// Block type for hudi_target in AwsGlueCrawler.
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerHudiTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hudi_target";

    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionName
    {
        get => GetArgument<TerraformValue<string>>("connection_name");
        set => SetArgument("connection_name", value);
    }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    public TerraformList<string>? Exclusions
    {
        get => GetArgument<TerraformList<string>>("exclusions");
        set => SetArgument("exclusions", value);
    }

    /// <summary>
    /// The maximum_traversal_depth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumTraversalDepth is required")]
    public required TerraformValue<double> MaximumTraversalDepth
    {
        get => GetArgument<TerraformValue<double>>("maximum_traversal_depth");
        set => SetArgument("maximum_traversal_depth", value);
    }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    public required TerraformSet<string> Paths
    {
        get => GetArgument<TerraformSet<string>>("paths");
        set => SetArgument("paths", value);
    }

}


/// <summary>
/// Block type for iceberg_target in AwsGlueCrawler.
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerIcebergTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iceberg_target";

    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionName
    {
        get => GetArgument<TerraformValue<string>>("connection_name");
        set => SetArgument("connection_name", value);
    }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    public TerraformList<string>? Exclusions
    {
        get => GetArgument<TerraformList<string>>("exclusions");
        set => SetArgument("exclusions", value);
    }

    /// <summary>
    /// The maximum_traversal_depth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumTraversalDepth is required")]
    public required TerraformValue<double> MaximumTraversalDepth
    {
        get => GetArgument<TerraformValue<double>>("maximum_traversal_depth");
        set => SetArgument("maximum_traversal_depth", value);
    }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    public required TerraformSet<string> Paths
    {
        get => GetArgument<TerraformSet<string>>("paths");
        set => SetArgument("paths", value);
    }

}


/// <summary>
/// Block type for jdbc_target in AwsGlueCrawler.
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerJdbcTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jdbc_target";

    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionName is required")]
    public required TerraformValue<string> ConnectionName
    {
        get => GetArgument<TerraformValue<string>>("connection_name");
        set => SetArgument("connection_name", value);
    }

    /// <summary>
    /// The enable_additional_metadata attribute.
    /// </summary>
    public TerraformList<string>? EnableAdditionalMetadata
    {
        get => GetArgument<TerraformList<string>>("enable_additional_metadata");
        set => SetArgument("enable_additional_metadata", value);
    }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    public TerraformList<string>? Exclusions
    {
        get => GetArgument<TerraformList<string>>("exclusions");
        set => SetArgument("exclusions", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for lake_formation_configuration in AwsGlueCrawler.
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerLakeFormationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lake_formation_configuration";

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The use_lake_formation_credentials attribute.
    /// </summary>
    public TerraformValue<bool>? UseLakeFormationCredentials
    {
        get => GetArgument<TerraformValue<bool>>("use_lake_formation_credentials");
        set => SetArgument("use_lake_formation_credentials", value);
    }

}


/// <summary>
/// Block type for lineage_configuration in AwsGlueCrawler.
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerLineageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lineage_configuration";

    /// <summary>
    /// The crawler_lineage_settings attribute.
    /// </summary>
    public TerraformValue<string>? CrawlerLineageSettings
    {
        get => GetArgument<TerraformValue<string>>("crawler_lineage_settings");
        set => SetArgument("crawler_lineage_settings", value);
    }

}


/// <summary>
/// Block type for mongodb_target in AwsGlueCrawler.
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerMongodbTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mongodb_target";

    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionName is required")]
    public required TerraformValue<string> ConnectionName
    {
        get => GetArgument<TerraformValue<string>>("connection_name");
        set => SetArgument("connection_name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The scan_all attribute.
    /// </summary>
    public TerraformValue<bool>? ScanAll
    {
        get => GetArgument<TerraformValue<bool>>("scan_all");
        set => SetArgument("scan_all", value);
    }

}


/// <summary>
/// Block type for recrawl_policy in AwsGlueCrawler.
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerRecrawlPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recrawl_policy";

    /// <summary>
    /// The recrawl_behavior attribute.
    /// </summary>
    public TerraformValue<string>? RecrawlBehavior
    {
        get => GetArgument<TerraformValue<string>>("recrawl_behavior");
        set => SetArgument("recrawl_behavior", value);
    }

}


/// <summary>
/// Block type for s3_target in AwsGlueCrawler.
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerS3TargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_target";

    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionName
    {
        get => GetArgument<TerraformValue<string>>("connection_name");
        set => SetArgument("connection_name", value);
    }

    /// <summary>
    /// The dlq_event_queue_arn attribute.
    /// </summary>
    public TerraformValue<string>? DlqEventQueueArn
    {
        get => GetArgument<TerraformValue<string>>("dlq_event_queue_arn");
        set => SetArgument("dlq_event_queue_arn", value);
    }

    /// <summary>
    /// The event_queue_arn attribute.
    /// </summary>
    public TerraformValue<string>? EventQueueArn
    {
        get => GetArgument<TerraformValue<string>>("event_queue_arn");
        set => SetArgument("event_queue_arn", value);
    }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    public TerraformList<string>? Exclusions
    {
        get => GetArgument<TerraformList<string>>("exclusions");
        set => SetArgument("exclusions", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    public TerraformValue<double>? SampleSize
    {
        get => GetArgument<TerraformValue<double>>("sample_size");
        set => SetArgument("sample_size", value);
    }

}


/// <summary>
/// Block type for schema_change_policy in AwsGlueCrawler.
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerSchemaChangePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_change_policy";

    /// <summary>
    /// The delete_behavior attribute.
    /// </summary>
    public TerraformValue<string>? DeleteBehavior
    {
        get => GetArgument<TerraformValue<string>>("delete_behavior");
        set => SetArgument("delete_behavior", value);
    }

    /// <summary>
    /// The update_behavior attribute.
    /// </summary>
    public TerraformValue<string>? UpdateBehavior
    {
        get => GetArgument<TerraformValue<string>>("update_behavior");
        set => SetArgument("update_behavior", value);
    }

}


/// <summary>
/// Represents a aws_glue_crawler Terraform resource.
/// Manages a aws_glue_crawler resource.
/// </summary>
public partial class AwsGlueCrawler(string name) : TerraformResource("aws_glue_crawler", name)
{
    /// <summary>
    /// The classifiers attribute.
    /// </summary>
    public TerraformList<string>? Classifiers
    {
        get => GetArgument<TerraformList<string>>("classifiers");
        set => SetArgument("classifiers", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformValue<string>? Configuration
    {
        get => GetArgument<TerraformValue<string>>("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => GetArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformValue<string>? Schedule
    {
        get => GetArgument<TerraformValue<string>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformValue<string>? SecurityConfiguration
    {
        get => GetArgument<TerraformValue<string>>("security_configuration");
        set => SetArgument("security_configuration", value);
    }

    /// <summary>
    /// The table_prefix attribute.
    /// </summary>
    public TerraformValue<string>? TablePrefix
    {
        get => GetArgument<TerraformValue<string>>("table_prefix");
        set => SetArgument("table_prefix", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// CatalogTarget block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCrawlerCatalogTargetBlock>? CatalogTarget
    {
        get => GetArgument<TerraformList<AwsGlueCrawlerCatalogTargetBlock>>("catalog_target");
        set => SetArgument("catalog_target", value);
    }

    /// <summary>
    /// DeltaTarget block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCrawlerDeltaTargetBlock>? DeltaTarget
    {
        get => GetArgument<TerraformList<AwsGlueCrawlerDeltaTargetBlock>>("delta_target");
        set => SetArgument("delta_target", value);
    }

    /// <summary>
    /// DynamodbTarget block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCrawlerDynamodbTargetBlock>? DynamodbTarget
    {
        get => GetArgument<TerraformList<AwsGlueCrawlerDynamodbTargetBlock>>("dynamodb_target");
        set => SetArgument("dynamodb_target", value);
    }

    /// <summary>
    /// HudiTarget block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCrawlerHudiTargetBlock>? HudiTarget
    {
        get => GetArgument<TerraformList<AwsGlueCrawlerHudiTargetBlock>>("hudi_target");
        set => SetArgument("hudi_target", value);
    }

    /// <summary>
    /// IcebergTarget block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCrawlerIcebergTargetBlock>? IcebergTarget
    {
        get => GetArgument<TerraformList<AwsGlueCrawlerIcebergTargetBlock>>("iceberg_target");
        set => SetArgument("iceberg_target", value);
    }

    /// <summary>
    /// JdbcTarget block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCrawlerJdbcTargetBlock>? JdbcTarget
    {
        get => GetArgument<TerraformList<AwsGlueCrawlerJdbcTargetBlock>>("jdbc_target");
        set => SetArgument("jdbc_target", value);
    }

    /// <summary>
    /// LakeFormationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LakeFormationConfiguration block(s) allowed")]
    public TerraformList<AwsGlueCrawlerLakeFormationConfigurationBlock>? LakeFormationConfiguration
    {
        get => GetArgument<TerraformList<AwsGlueCrawlerLakeFormationConfigurationBlock>>("lake_formation_configuration");
        set => SetArgument("lake_formation_configuration", value);
    }

    /// <summary>
    /// LineageConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LineageConfiguration block(s) allowed")]
    public TerraformList<AwsGlueCrawlerLineageConfigurationBlock>? LineageConfiguration
    {
        get => GetArgument<TerraformList<AwsGlueCrawlerLineageConfigurationBlock>>("lineage_configuration");
        set => SetArgument("lineage_configuration", value);
    }

    /// <summary>
    /// MongodbTarget block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCrawlerMongodbTargetBlock>? MongodbTarget
    {
        get => GetArgument<TerraformList<AwsGlueCrawlerMongodbTargetBlock>>("mongodb_target");
        set => SetArgument("mongodb_target", value);
    }

    /// <summary>
    /// RecrawlPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecrawlPolicy block(s) allowed")]
    public TerraformList<AwsGlueCrawlerRecrawlPolicyBlock>? RecrawlPolicy
    {
        get => GetArgument<TerraformList<AwsGlueCrawlerRecrawlPolicyBlock>>("recrawl_policy");
        set => SetArgument("recrawl_policy", value);
    }

    /// <summary>
    /// S3Target block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCrawlerS3TargetBlock>? S3Target
    {
        get => GetArgument<TerraformList<AwsGlueCrawlerS3TargetBlock>>("s3_target");
        set => SetArgument("s3_target", value);
    }

    /// <summary>
    /// SchemaChangePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaChangePolicy block(s) allowed")]
    public TerraformList<AwsGlueCrawlerSchemaChangePolicyBlock>? SchemaChangePolicy
    {
        get => GetArgument<TerraformList<AwsGlueCrawlerSchemaChangePolicyBlock>>("schema_change_policy");
        set => SetArgument("schema_change_policy", value);
    }

}
