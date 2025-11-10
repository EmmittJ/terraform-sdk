using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for catalog_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerCatalogTargetBlock : TerraformBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionName
    {
        get => GetProperty<TerraformProperty<string>>("connection_name");
        set => WithProperty("connection_name", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database_name");
        set => WithProperty("database_name", value);
    }

    /// <summary>
    /// The dlq_event_queue_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DlqEventQueueArn
    {
        get => GetProperty<TerraformProperty<string>>("dlq_event_queue_arn");
        set => WithProperty("dlq_event_queue_arn", value);
    }

    /// <summary>
    /// The event_queue_arn attribute.
    /// </summary>
    public TerraformProperty<string>? EventQueueArn
    {
        get => GetProperty<TerraformProperty<string>>("event_queue_arn");
        set => WithProperty("event_queue_arn", value);
    }

    /// <summary>
    /// The tables attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tables is required")]
    public List<TerraformProperty<string>>? Tables
    {
        get => GetProperty<List<TerraformProperty<string>>>("tables");
        set => WithProperty("tables", value);
    }

}

/// <summary>
/// Block type for delta_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerDeltaTargetBlock : TerraformBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionName
    {
        get => GetProperty<TerraformProperty<string>>("connection_name");
        set => WithProperty("connection_name", value);
    }

    /// <summary>
    /// The create_native_delta_table attribute.
    /// </summary>
    public TerraformProperty<bool>? CreateNativeDeltaTable
    {
        get => GetProperty<TerraformProperty<bool>>("create_native_delta_table");
        set => WithProperty("create_native_delta_table", value);
    }

    /// <summary>
    /// The delta_tables attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeltaTables is required")]
    public HashSet<TerraformProperty<string>>? DeltaTables
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("delta_tables");
        set => WithProperty("delta_tables", value);
    }

    /// <summary>
    /// The write_manifest attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WriteManifest is required")]
    public required TerraformProperty<bool> WriteManifest
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("write_manifest");
        set => WithProperty("write_manifest", value);
    }

}

/// <summary>
/// Block type for dynamodb_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerDynamodbTargetBlock : TerraformBlock
{
    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetRequiredProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The scan_all attribute.
    /// </summary>
    public TerraformProperty<bool>? ScanAll
    {
        get => GetProperty<TerraformProperty<bool>>("scan_all");
        set => WithProperty("scan_all", value);
    }

    /// <summary>
    /// The scan_rate attribute.
    /// </summary>
    public TerraformProperty<double>? ScanRate
    {
        get => GetProperty<TerraformProperty<double>>("scan_rate");
        set => WithProperty("scan_rate", value);
    }

}

/// <summary>
/// Block type for hudi_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerHudiTargetBlock : TerraformBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionName
    {
        get => GetProperty<TerraformProperty<string>>("connection_name");
        set => WithProperty("connection_name", value);
    }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Exclusions
    {
        get => GetProperty<List<TerraformProperty<string>>>("exclusions");
        set => WithProperty("exclusions", value);
    }

    /// <summary>
    /// The maximum_traversal_depth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumTraversalDepth is required")]
    public required TerraformProperty<double> MaximumTraversalDepth
    {
        get => GetRequiredProperty<TerraformProperty<double>>("maximum_traversal_depth");
        set => WithProperty("maximum_traversal_depth", value);
    }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    public HashSet<TerraformProperty<string>>? Paths
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("paths");
        set => WithProperty("paths", value);
    }

}

/// <summary>
/// Block type for iceberg_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerIcebergTargetBlock : TerraformBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionName
    {
        get => GetProperty<TerraformProperty<string>>("connection_name");
        set => WithProperty("connection_name", value);
    }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Exclusions
    {
        get => GetProperty<List<TerraformProperty<string>>>("exclusions");
        set => WithProperty("exclusions", value);
    }

    /// <summary>
    /// The maximum_traversal_depth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumTraversalDepth is required")]
    public required TerraformProperty<double> MaximumTraversalDepth
    {
        get => GetRequiredProperty<TerraformProperty<double>>("maximum_traversal_depth");
        set => WithProperty("maximum_traversal_depth", value);
    }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    public HashSet<TerraformProperty<string>>? Paths
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("paths");
        set => WithProperty("paths", value);
    }

}

/// <summary>
/// Block type for jdbc_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerJdbcTargetBlock : TerraformBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionName is required")]
    public required TerraformProperty<string> ConnectionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connection_name");
        set => WithProperty("connection_name", value);
    }

    /// <summary>
    /// The enable_additional_metadata attribute.
    /// </summary>
    public List<TerraformProperty<string>>? EnableAdditionalMetadata
    {
        get => GetProperty<List<TerraformProperty<string>>>("enable_additional_metadata");
        set => WithProperty("enable_additional_metadata", value);
    }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Exclusions
    {
        get => GetProperty<List<TerraformProperty<string>>>("exclusions");
        set => WithProperty("exclusions", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetRequiredProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

}

/// <summary>
/// Block type for lake_formation_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerLakeFormationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => WithProperty("account_id", value);
    }

    /// <summary>
    /// The use_lake_formation_credentials attribute.
    /// </summary>
    public TerraformProperty<bool>? UseLakeFormationCredentials
    {
        get => GetProperty<TerraformProperty<bool>>("use_lake_formation_credentials");
        set => WithProperty("use_lake_formation_credentials", value);
    }

}

/// <summary>
/// Block type for lineage_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerLineageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The crawler_lineage_settings attribute.
    /// </summary>
    public TerraformProperty<string>? CrawlerLineageSettings
    {
        get => GetProperty<TerraformProperty<string>>("crawler_lineage_settings");
        set => WithProperty("crawler_lineage_settings", value);
    }

}

/// <summary>
/// Block type for mongodb_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerMongodbTargetBlock : TerraformBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionName is required")]
    public required TerraformProperty<string> ConnectionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connection_name");
        set => WithProperty("connection_name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetRequiredProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The scan_all attribute.
    /// </summary>
    public TerraformProperty<bool>? ScanAll
    {
        get => GetProperty<TerraformProperty<bool>>("scan_all");
        set => WithProperty("scan_all", value);
    }

}

/// <summary>
/// Block type for recrawl_policy in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerRecrawlPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The recrawl_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? RecrawlBehavior
    {
        get => GetProperty<TerraformProperty<string>>("recrawl_behavior");
        set => WithProperty("recrawl_behavior", value);
    }

}

/// <summary>
/// Block type for s3_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerS3TargetBlock : TerraformBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionName
    {
        get => GetProperty<TerraformProperty<string>>("connection_name");
        set => WithProperty("connection_name", value);
    }

    /// <summary>
    /// The dlq_event_queue_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DlqEventQueueArn
    {
        get => GetProperty<TerraformProperty<string>>("dlq_event_queue_arn");
        set => WithProperty("dlq_event_queue_arn", value);
    }

    /// <summary>
    /// The event_queue_arn attribute.
    /// </summary>
    public TerraformProperty<string>? EventQueueArn
    {
        get => GetProperty<TerraformProperty<string>>("event_queue_arn");
        set => WithProperty("event_queue_arn", value);
    }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Exclusions
    {
        get => GetProperty<List<TerraformProperty<string>>>("exclusions");
        set => WithProperty("exclusions", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetRequiredProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    public TerraformProperty<double>? SampleSize
    {
        get => GetProperty<TerraformProperty<double>>("sample_size");
        set => WithProperty("sample_size", value);
    }

}

/// <summary>
/// Block type for schema_change_policy in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerSchemaChangePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The delete_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? DeleteBehavior
    {
        get => GetProperty<TerraformProperty<string>>("delete_behavior");
        set => WithProperty("delete_behavior", value);
    }

    /// <summary>
    /// The update_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? UpdateBehavior
    {
        get => GetProperty<TerraformProperty<string>>("update_behavior");
        set => WithProperty("update_behavior", value);
    }

}

/// <summary>
/// Manages a aws_glue_crawler resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueCrawler : TerraformResource
{
    public AwsGlueCrawler(string name) : base("aws_glue_crawler", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The classifiers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Classifiers
    {
        get => GetProperty<List<TerraformProperty<string>>>("classifiers");
        set => this.WithProperty("classifiers", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformProperty<string>? Configuration
    {
        get => GetProperty<TerraformProperty<string>>("configuration");
        set => this.WithProperty("configuration", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformProperty<string>? Schedule
    {
        get => GetProperty<TerraformProperty<string>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityConfiguration
    {
        get => GetProperty<TerraformProperty<string>>("security_configuration");
        set => this.WithProperty("security_configuration", value);
    }

    /// <summary>
    /// The table_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? TablePrefix
    {
        get => GetProperty<TerraformProperty<string>>("table_prefix");
        set => this.WithProperty("table_prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for catalog_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerCatalogTargetBlock>? CatalogTarget
    {
        get => GetProperty<List<AwsGlueCrawlerCatalogTargetBlock>>("catalog_target");
        set => this.WithProperty("catalog_target", value);
    }

    /// <summary>
    /// Block for delta_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerDeltaTargetBlock>? DeltaTarget
    {
        get => GetProperty<List<AwsGlueCrawlerDeltaTargetBlock>>("delta_target");
        set => this.WithProperty("delta_target", value);
    }

    /// <summary>
    /// Block for dynamodb_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerDynamodbTargetBlock>? DynamodbTarget
    {
        get => GetProperty<List<AwsGlueCrawlerDynamodbTargetBlock>>("dynamodb_target");
        set => this.WithProperty("dynamodb_target", value);
    }

    /// <summary>
    /// Block for hudi_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerHudiTargetBlock>? HudiTarget
    {
        get => GetProperty<List<AwsGlueCrawlerHudiTargetBlock>>("hudi_target");
        set => this.WithProperty("hudi_target", value);
    }

    /// <summary>
    /// Block for iceberg_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerIcebergTargetBlock>? IcebergTarget
    {
        get => GetProperty<List<AwsGlueCrawlerIcebergTargetBlock>>("iceberg_target");
        set => this.WithProperty("iceberg_target", value);
    }

    /// <summary>
    /// Block for jdbc_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerJdbcTargetBlock>? JdbcTarget
    {
        get => GetProperty<List<AwsGlueCrawlerJdbcTargetBlock>>("jdbc_target");
        set => this.WithProperty("jdbc_target", value);
    }

    /// <summary>
    /// Block for lake_formation_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LakeFormationConfiguration block(s) allowed")]
    public List<AwsGlueCrawlerLakeFormationConfigurationBlock>? LakeFormationConfiguration
    {
        get => GetProperty<List<AwsGlueCrawlerLakeFormationConfigurationBlock>>("lake_formation_configuration");
        set => this.WithProperty("lake_formation_configuration", value);
    }

    /// <summary>
    /// Block for lineage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LineageConfiguration block(s) allowed")]
    public List<AwsGlueCrawlerLineageConfigurationBlock>? LineageConfiguration
    {
        get => GetProperty<List<AwsGlueCrawlerLineageConfigurationBlock>>("lineage_configuration");
        set => this.WithProperty("lineage_configuration", value);
    }

    /// <summary>
    /// Block for mongodb_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerMongodbTargetBlock>? MongodbTarget
    {
        get => GetProperty<List<AwsGlueCrawlerMongodbTargetBlock>>("mongodb_target");
        set => this.WithProperty("mongodb_target", value);
    }

    /// <summary>
    /// Block for recrawl_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecrawlPolicy block(s) allowed")]
    public List<AwsGlueCrawlerRecrawlPolicyBlock>? RecrawlPolicy
    {
        get => GetProperty<List<AwsGlueCrawlerRecrawlPolicyBlock>>("recrawl_policy");
        set => this.WithProperty("recrawl_policy", value);
    }

    /// <summary>
    /// Block for s3_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerS3TargetBlock>? S3Target
    {
        get => GetProperty<List<AwsGlueCrawlerS3TargetBlock>>("s3_target");
        set => this.WithProperty("s3_target", value);
    }

    /// <summary>
    /// Block for schema_change_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaChangePolicy block(s) allowed")]
    public List<AwsGlueCrawlerSchemaChangePolicyBlock>? SchemaChangePolicy
    {
        get => GetProperty<List<AwsGlueCrawlerSchemaChangePolicyBlock>>("schema_change_policy");
        set => this.WithProperty("schema_change_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
