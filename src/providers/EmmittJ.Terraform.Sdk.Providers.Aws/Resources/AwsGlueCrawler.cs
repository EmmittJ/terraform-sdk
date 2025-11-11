using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for catalog_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCrawlerCatalogTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [TerraformProperty("connection_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectionName { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The dlq_event_queue_arn attribute.
    /// </summary>
    [TerraformProperty("dlq_event_queue_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DlqEventQueueArn { get; set; }

    /// <summary>
    /// The event_queue_arn attribute.
    /// </summary>
    [TerraformProperty("event_queue_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EventQueueArn { get; set; }

    /// <summary>
    /// The tables attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tables is required")]
    [TerraformProperty("tables")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? Tables { get; set; }

}

/// <summary>
/// Block type for delta_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCrawlerDeltaTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [TerraformProperty("connection_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectionName { get; set; }

    /// <summary>
    /// The create_native_delta_table attribute.
    /// </summary>
    [TerraformProperty("create_native_delta_table")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CreateNativeDeltaTable { get; set; }

    /// <summary>
    /// The delta_tables attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeltaTables is required")]
    [TerraformProperty("delta_tables")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> DeltaTables { get; set; }

    /// <summary>
    /// The write_manifest attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WriteManifest is required")]
    [TerraformProperty("write_manifest")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> WriteManifest { get; set; }

}

/// <summary>
/// Block type for dynamodb_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCrawlerDynamodbTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The scan_all attribute.
    /// </summary>
    [TerraformProperty("scan_all")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ScanAll { get; set; }

    /// <summary>
    /// The scan_rate attribute.
    /// </summary>
    [TerraformProperty("scan_rate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ScanRate { get; set; }

}

/// <summary>
/// Block type for hudi_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCrawlerHudiTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [TerraformProperty("connection_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectionName { get; set; }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    [TerraformProperty("exclusions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Exclusions { get; set; }

    /// <summary>
    /// The maximum_traversal_depth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumTraversalDepth is required")]
    [TerraformProperty("maximum_traversal_depth")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaximumTraversalDepth { get; set; }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    [TerraformProperty("paths")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Paths { get; set; }

}

/// <summary>
/// Block type for iceberg_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCrawlerIcebergTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [TerraformProperty("connection_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectionName { get; set; }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    [TerraformProperty("exclusions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Exclusions { get; set; }

    /// <summary>
    /// The maximum_traversal_depth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumTraversalDepth is required")]
    [TerraformProperty("maximum_traversal_depth")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaximumTraversalDepth { get; set; }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    [TerraformProperty("paths")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Paths { get; set; }

}

/// <summary>
/// Block type for jdbc_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCrawlerJdbcTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionName is required")]
    [TerraformProperty("connection_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectionName { get; set; }

    /// <summary>
    /// The enable_additional_metadata attribute.
    /// </summary>
    [TerraformProperty("enable_additional_metadata")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? EnableAdditionalMetadata { get; set; }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    [TerraformProperty("exclusions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Exclusions { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

}

/// <summary>
/// Block type for lake_formation_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCrawlerLakeFormationConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The use_lake_formation_credentials attribute.
    /// </summary>
    [TerraformProperty("use_lake_formation_credentials")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseLakeFormationCredentials { get; set; }

}

/// <summary>
/// Block type for lineage_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCrawlerLineageConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The crawler_lineage_settings attribute.
    /// </summary>
    [TerraformProperty("crawler_lineage_settings")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CrawlerLineageSettings { get; set; }

}

/// <summary>
/// Block type for mongodb_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCrawlerMongodbTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionName is required")]
    [TerraformProperty("connection_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectionName { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The scan_all attribute.
    /// </summary>
    [TerraformProperty("scan_all")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ScanAll { get; set; }

}

/// <summary>
/// Block type for recrawl_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCrawlerRecrawlPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The recrawl_behavior attribute.
    /// </summary>
    [TerraformProperty("recrawl_behavior")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RecrawlBehavior { get; set; }

}

/// <summary>
/// Block type for s3_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCrawlerS3TargetBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [TerraformProperty("connection_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectionName { get; set; }

    /// <summary>
    /// The dlq_event_queue_arn attribute.
    /// </summary>
    [TerraformProperty("dlq_event_queue_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DlqEventQueueArn { get; set; }

    /// <summary>
    /// The event_queue_arn attribute.
    /// </summary>
    [TerraformProperty("event_queue_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EventQueueArn { get; set; }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    [TerraformProperty("exclusions")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Exclusions { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    [TerraformProperty("sample_size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SampleSize { get; set; }

}

/// <summary>
/// Block type for schema_change_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueCrawlerSchemaChangePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The delete_behavior attribute.
    /// </summary>
    [TerraformProperty("delete_behavior")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeleteBehavior { get; set; }

    /// <summary>
    /// The update_behavior attribute.
    /// </summary>
    [TerraformProperty("update_behavior")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UpdateBehavior { get; set; }

}

/// <summary>
/// Manages a aws_glue_crawler resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlueCrawler : TerraformResource
{
    public AwsGlueCrawler(string name) : base("aws_glue_crawler", name)
    {
    }

    /// <summary>
    /// The classifiers attribute.
    /// </summary>
    [TerraformProperty("classifiers")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Classifiers { get; set; }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [TerraformProperty("configuration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Configuration { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Role { get; set; }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [TerraformProperty("schedule")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Schedule { get; set; }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    [TerraformProperty("security_configuration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecurityConfiguration { get; set; }

    /// <summary>
    /// The table_prefix attribute.
    /// </summary>
    [TerraformProperty("table_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TablePrefix { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for catalog_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("catalog_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerCatalogTargetBlock>>? CatalogTarget { get; set; }

    /// <summary>
    /// Block for delta_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("delta_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerDeltaTargetBlock>>? DeltaTarget { get; set; }

    /// <summary>
    /// Block for dynamodb_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("dynamodb_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerDynamodbTargetBlock>>? DynamodbTarget { get; set; }

    /// <summary>
    /// Block for hudi_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("hudi_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerHudiTargetBlock>>? HudiTarget { get; set; }

    /// <summary>
    /// Block for iceberg_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("iceberg_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerIcebergTargetBlock>>? IcebergTarget { get; set; }

    /// <summary>
    /// Block for jdbc_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("jdbc_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerJdbcTargetBlock>>? JdbcTarget { get; set; }

    /// <summary>
    /// Block for lake_formation_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LakeFormationConfiguration block(s) allowed")]
    [TerraformProperty("lake_formation_configuration")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerLakeFormationConfigurationBlock>>? LakeFormationConfiguration { get; set; }

    /// <summary>
    /// Block for lineage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LineageConfiguration block(s) allowed")]
    [TerraformProperty("lineage_configuration")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerLineageConfigurationBlock>>? LineageConfiguration { get; set; }

    /// <summary>
    /// Block for mongodb_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("mongodb_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerMongodbTargetBlock>>? MongodbTarget { get; set; }

    /// <summary>
    /// Block for recrawl_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecrawlPolicy block(s) allowed")]
    [TerraformProperty("recrawl_policy")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerRecrawlPolicyBlock>>? RecrawlPolicy { get; set; }

    /// <summary>
    /// Block for s3_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("s3_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerS3TargetBlock>>? S3Target { get; set; }

    /// <summary>
    /// Block for schema_change_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaChangePolicy block(s) allowed")]
    [TerraformProperty("schema_change_policy")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerSchemaChangePolicyBlock>>? SchemaChangePolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
