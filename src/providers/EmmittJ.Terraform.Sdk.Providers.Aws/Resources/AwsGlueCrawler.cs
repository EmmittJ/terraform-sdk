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
        set => SetProperty("connection_name", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The dlq_event_queue_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DlqEventQueueArn
    {
        set => SetProperty("dlq_event_queue_arn", value);
    }

    /// <summary>
    /// The event_queue_arn attribute.
    /// </summary>
    public TerraformProperty<string>? EventQueueArn
    {
        set => SetProperty("event_queue_arn", value);
    }

    /// <summary>
    /// The tables attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tables is required")]
    public List<TerraformProperty<string>>? Tables
    {
        set => SetProperty("tables", value);
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
        set => SetProperty("connection_name", value);
    }

    /// <summary>
    /// The create_native_delta_table attribute.
    /// </summary>
    public TerraformProperty<bool>? CreateNativeDeltaTable
    {
        set => SetProperty("create_native_delta_table", value);
    }

    /// <summary>
    /// The delta_tables attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeltaTables is required")]
    public HashSet<TerraformProperty<string>>? DeltaTables
    {
        set => SetProperty("delta_tables", value);
    }

    /// <summary>
    /// The write_manifest attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WriteManifest is required")]
    public required TerraformProperty<bool> WriteManifest
    {
        set => SetProperty("write_manifest", value);
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
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The scan_all attribute.
    /// </summary>
    public TerraformProperty<bool>? ScanAll
    {
        set => SetProperty("scan_all", value);
    }

    /// <summary>
    /// The scan_rate attribute.
    /// </summary>
    public TerraformProperty<double>? ScanRate
    {
        set => SetProperty("scan_rate", value);
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
        set => SetProperty("connection_name", value);
    }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Exclusions
    {
        set => SetProperty("exclusions", value);
    }

    /// <summary>
    /// The maximum_traversal_depth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumTraversalDepth is required")]
    public required TerraformProperty<double> MaximumTraversalDepth
    {
        set => SetProperty("maximum_traversal_depth", value);
    }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    public HashSet<TerraformProperty<string>>? Paths
    {
        set => SetProperty("paths", value);
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
        set => SetProperty("connection_name", value);
    }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Exclusions
    {
        set => SetProperty("exclusions", value);
    }

    /// <summary>
    /// The maximum_traversal_depth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumTraversalDepth is required")]
    public required TerraformProperty<double> MaximumTraversalDepth
    {
        set => SetProperty("maximum_traversal_depth", value);
    }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    public HashSet<TerraformProperty<string>>? Paths
    {
        set => SetProperty("paths", value);
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
        set => SetProperty("connection_name", value);
    }

    /// <summary>
    /// The enable_additional_metadata attribute.
    /// </summary>
    public List<TerraformProperty<string>>? EnableAdditionalMetadata
    {
        set => SetProperty("enable_additional_metadata", value);
    }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Exclusions
    {
        set => SetProperty("exclusions", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        set => SetProperty("path", value);
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
        set => SetProperty("account_id", value);
    }

    /// <summary>
    /// The use_lake_formation_credentials attribute.
    /// </summary>
    public TerraformProperty<bool>? UseLakeFormationCredentials
    {
        set => SetProperty("use_lake_formation_credentials", value);
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
        set => SetProperty("crawler_lineage_settings", value);
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
        set => SetProperty("connection_name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The scan_all attribute.
    /// </summary>
    public TerraformProperty<bool>? ScanAll
    {
        set => SetProperty("scan_all", value);
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
        set => SetProperty("recrawl_behavior", value);
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
        set => SetProperty("connection_name", value);
    }

    /// <summary>
    /// The dlq_event_queue_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DlqEventQueueArn
    {
        set => SetProperty("dlq_event_queue_arn", value);
    }

    /// <summary>
    /// The event_queue_arn attribute.
    /// </summary>
    public TerraformProperty<string>? EventQueueArn
    {
        set => SetProperty("event_queue_arn", value);
    }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Exclusions
    {
        set => SetProperty("exclusions", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    public TerraformProperty<double>? SampleSize
    {
        set => SetProperty("sample_size", value);
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
        set => SetProperty("delete_behavior", value);
    }

    /// <summary>
    /// The update_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? UpdateBehavior
    {
        set => SetProperty("update_behavior", value);
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
        SetOutput("arn");
        SetOutput("classifiers");
        SetOutput("configuration");
        SetOutput("database_name");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("role");
        SetOutput("schedule");
        SetOutput("security_configuration");
        SetOutput("table_prefix");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The classifiers attribute.
    /// </summary>
    public List<TerraformProperty<string>> Classifiers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("classifiers");
        set => SetProperty("classifiers", value);
    }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    public TerraformProperty<string> Configuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration");
        set => SetProperty("configuration", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role");
        set => SetProperty("role", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformProperty<string> Schedule
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule");
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformProperty<string> SecurityConfiguration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_configuration");
        set => SetProperty("security_configuration", value);
    }

    /// <summary>
    /// The table_prefix attribute.
    /// </summary>
    public TerraformProperty<string> TablePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_prefix");
        set => SetProperty("table_prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for catalog_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerCatalogTargetBlock>? CatalogTarget
    {
        set => SetProperty("catalog_target", value);
    }

    /// <summary>
    /// Block for delta_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerDeltaTargetBlock>? DeltaTarget
    {
        set => SetProperty("delta_target", value);
    }

    /// <summary>
    /// Block for dynamodb_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerDynamodbTargetBlock>? DynamodbTarget
    {
        set => SetProperty("dynamodb_target", value);
    }

    /// <summary>
    /// Block for hudi_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerHudiTargetBlock>? HudiTarget
    {
        set => SetProperty("hudi_target", value);
    }

    /// <summary>
    /// Block for iceberg_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerIcebergTargetBlock>? IcebergTarget
    {
        set => SetProperty("iceberg_target", value);
    }

    /// <summary>
    /// Block for jdbc_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerJdbcTargetBlock>? JdbcTarget
    {
        set => SetProperty("jdbc_target", value);
    }

    /// <summary>
    /// Block for lake_formation_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LakeFormationConfiguration block(s) allowed")]
    public List<AwsGlueCrawlerLakeFormationConfigurationBlock>? LakeFormationConfiguration
    {
        set => SetProperty("lake_formation_configuration", value);
    }

    /// <summary>
    /// Block for lineage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LineageConfiguration block(s) allowed")]
    public List<AwsGlueCrawlerLineageConfigurationBlock>? LineageConfiguration
    {
        set => SetProperty("lineage_configuration", value);
    }

    /// <summary>
    /// Block for mongodb_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerMongodbTargetBlock>? MongodbTarget
    {
        set => SetProperty("mongodb_target", value);
    }

    /// <summary>
    /// Block for recrawl_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecrawlPolicy block(s) allowed")]
    public List<AwsGlueCrawlerRecrawlPolicyBlock>? RecrawlPolicy
    {
        set => SetProperty("recrawl_policy", value);
    }

    /// <summary>
    /// Block for s3_target.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCrawlerS3TargetBlock>? S3Target
    {
        set => SetProperty("s3_target", value);
    }

    /// <summary>
    /// Block for schema_change_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaChangePolicy block(s) allowed")]
    public List<AwsGlueCrawlerSchemaChangePolicyBlock>? SchemaChangePolicy
    {
        set => SetProperty("schema_change_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
