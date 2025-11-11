using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for catalog_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerCatalogTargetBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [TerraformPropertyName("connection_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionName { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The dlq_event_queue_arn attribute.
    /// </summary>
    [TerraformPropertyName("dlq_event_queue_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DlqEventQueueArn { get; set; }

    /// <summary>
    /// The event_queue_arn attribute.
    /// </summary>
    [TerraformPropertyName("event_queue_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventQueueArn { get; set; }

    /// <summary>
    /// The tables attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tables is required")]
    [TerraformPropertyName("tables")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Tables { get; set; }

}

/// <summary>
/// Block type for delta_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerDeltaTargetBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [TerraformPropertyName("connection_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionName { get; set; }

    /// <summary>
    /// The create_native_delta_table attribute.
    /// </summary>
    [TerraformPropertyName("create_native_delta_table")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CreateNativeDeltaTable { get; set; }

    /// <summary>
    /// The delta_tables attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeltaTables is required")]
    [TerraformPropertyName("delta_tables")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> DeltaTables { get; set; }

    /// <summary>
    /// The write_manifest attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WriteManifest is required")]
    [TerraformPropertyName("write_manifest")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> WriteManifest { get; set; }

}

/// <summary>
/// Block type for dynamodb_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerDynamodbTargetBlock
{
    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The scan_all attribute.
    /// </summary>
    [TerraformPropertyName("scan_all")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ScanAll { get; set; }

    /// <summary>
    /// The scan_rate attribute.
    /// </summary>
    [TerraformPropertyName("scan_rate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ScanRate { get; set; }

}

/// <summary>
/// Block type for hudi_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerHudiTargetBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [TerraformPropertyName("connection_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionName { get; set; }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    [TerraformPropertyName("exclusions")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Exclusions { get; set; }

    /// <summary>
    /// The maximum_traversal_depth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumTraversalDepth is required")]
    [TerraformPropertyName("maximum_traversal_depth")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaximumTraversalDepth { get; set; }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    [TerraformPropertyName("paths")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Paths { get; set; }

}

/// <summary>
/// Block type for iceberg_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerIcebergTargetBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [TerraformPropertyName("connection_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionName { get; set; }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    [TerraformPropertyName("exclusions")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Exclusions { get; set; }

    /// <summary>
    /// The maximum_traversal_depth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumTraversalDepth is required")]
    [TerraformPropertyName("maximum_traversal_depth")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaximumTraversalDepth { get; set; }

    /// <summary>
    /// The paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Paths is required")]
    [TerraformPropertyName("paths")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Paths { get; set; }

}

/// <summary>
/// Block type for jdbc_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerJdbcTargetBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionName is required")]
    [TerraformPropertyName("connection_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectionName { get; set; }

    /// <summary>
    /// The enable_additional_metadata attribute.
    /// </summary>
    [TerraformPropertyName("enable_additional_metadata")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? EnableAdditionalMetadata { get; set; }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    [TerraformPropertyName("exclusions")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Exclusions { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Path { get; set; }

}

/// <summary>
/// Block type for lake_formation_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerLakeFormationConfigurationBlock
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccountId { get; set; } = default!;

    /// <summary>
    /// The use_lake_formation_credentials attribute.
    /// </summary>
    [TerraformPropertyName("use_lake_formation_credentials")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseLakeFormationCredentials { get; set; }

}

/// <summary>
/// Block type for lineage_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerLineageConfigurationBlock
{
    /// <summary>
    /// The crawler_lineage_settings attribute.
    /// </summary>
    [TerraformPropertyName("crawler_lineage_settings")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CrawlerLineageSettings { get; set; }

}

/// <summary>
/// Block type for mongodb_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerMongodbTargetBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionName is required")]
    [TerraformPropertyName("connection_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectionName { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The scan_all attribute.
    /// </summary>
    [TerraformPropertyName("scan_all")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ScanAll { get; set; }

}

/// <summary>
/// Block type for recrawl_policy in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerRecrawlPolicyBlock
{
    /// <summary>
    /// The recrawl_behavior attribute.
    /// </summary>
    [TerraformPropertyName("recrawl_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RecrawlBehavior { get; set; }

}

/// <summary>
/// Block type for s3_target in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerS3TargetBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    [TerraformPropertyName("connection_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionName { get; set; }

    /// <summary>
    /// The dlq_event_queue_arn attribute.
    /// </summary>
    [TerraformPropertyName("dlq_event_queue_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DlqEventQueueArn { get; set; }

    /// <summary>
    /// The event_queue_arn attribute.
    /// </summary>
    [TerraformPropertyName("event_queue_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventQueueArn { get; set; }

    /// <summary>
    /// The exclusions attribute.
    /// </summary>
    [TerraformPropertyName("exclusions")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Exclusions { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    [TerraformPropertyName("sample_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SampleSize { get; set; }

}

/// <summary>
/// Block type for schema_change_policy in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCrawlerSchemaChangePolicyBlock
{
    /// <summary>
    /// The delete_behavior attribute.
    /// </summary>
    [TerraformPropertyName("delete_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeleteBehavior { get; set; }

    /// <summary>
    /// The update_behavior attribute.
    /// </summary>
    [TerraformPropertyName("update_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UpdateBehavior { get; set; }

}

/// <summary>
/// Manages a aws_glue_crawler resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueCrawler : TerraformResource
{
    public AwsGlueCrawler(string name) : base("aws_glue_crawler", name)
    {
    }

    /// <summary>
    /// The classifiers attribute.
    /// </summary>
    [TerraformPropertyName("classifiers")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Classifiers { get; set; }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [TerraformPropertyName("configuration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Configuration { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformPropertyName("role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Role { get; set; }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [TerraformPropertyName("schedule")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Schedule { get; set; }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    [TerraformPropertyName("security_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecurityConfiguration { get; set; }

    /// <summary>
    /// The table_prefix attribute.
    /// </summary>
    [TerraformPropertyName("table_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TablePrefix { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for catalog_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("catalog_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerCatalogTargetBlock>>? CatalogTarget { get; set; }

    /// <summary>
    /// Block for delta_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("delta_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerDeltaTargetBlock>>? DeltaTarget { get; set; }

    /// <summary>
    /// Block for dynamodb_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("dynamodb_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerDynamodbTargetBlock>>? DynamodbTarget { get; set; }

    /// <summary>
    /// Block for hudi_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("hudi_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerHudiTargetBlock>>? HudiTarget { get; set; }

    /// <summary>
    /// Block for iceberg_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("iceberg_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerIcebergTargetBlock>>? IcebergTarget { get; set; }

    /// <summary>
    /// Block for jdbc_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("jdbc_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerJdbcTargetBlock>>? JdbcTarget { get; set; }

    /// <summary>
    /// Block for lake_formation_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LakeFormationConfiguration block(s) allowed")]
    [TerraformPropertyName("lake_formation_configuration")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerLakeFormationConfigurationBlock>>? LakeFormationConfiguration { get; set; }

    /// <summary>
    /// Block for lineage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LineageConfiguration block(s) allowed")]
    [TerraformPropertyName("lineage_configuration")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerLineageConfigurationBlock>>? LineageConfiguration { get; set; }

    /// <summary>
    /// Block for mongodb_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("mongodb_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerMongodbTargetBlock>>? MongodbTarget { get; set; }

    /// <summary>
    /// Block for recrawl_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecrawlPolicy block(s) allowed")]
    [TerraformPropertyName("recrawl_policy")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerRecrawlPolicyBlock>>? RecrawlPolicy { get; set; }

    /// <summary>
    /// Block for s3_target.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("s3_target")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerS3TargetBlock>>? S3Target { get; set; }

    /// <summary>
    /// Block for schema_change_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaChangePolicy block(s) allowed")]
    [TerraformPropertyName("schema_change_policy")]
    public TerraformList<TerraformBlock<AwsGlueCrawlerSchemaChangePolicyBlock>>? SchemaChangePolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
