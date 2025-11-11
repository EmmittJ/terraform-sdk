using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for biglake_configuration in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableBiglakeConfigurationBlock
{
    /// <summary>
    /// The connection specifying the credentials to be used to read and write to external storage, such as Cloud Storage. The connection_id can have the form &amp;quot;&amp;amp;lt;project\_id&amp;amp;gt;.&amp;amp;lt;location\_id&amp;amp;gt;.&amp;amp;lt;connection\_id&amp;amp;gt;&amp;quot; or &amp;quot;projects/&amp;amp;lt;project\_id&amp;amp;gt;/locations/&amp;amp;lt;location\_id&amp;amp;gt;/connections/&amp;amp;lt;connection\_id&amp;amp;gt;&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformPropertyName("connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectionId { get; set; }

    /// <summary>
    /// The file format the data is stored in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileFormat is required")]
    [TerraformPropertyName("file_format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FileFormat { get; set; }

    /// <summary>
    /// The fully qualified location prefix of the external folder where table data is stored. The &#39;*&#39; wildcard character is not allowed. The URI should be in the format &amp;quot;gs://bucket/path_to_table/&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    [TerraformPropertyName("storage_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageUri { get; set; }

    /// <summary>
    /// The table format the metadata only snapshots are stored in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableFormat is required")]
    [TerraformPropertyName("table_format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TableFormat { get; set; }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableEncryptionConfigurationBlock
{
    /// <summary>
    /// The self link or full name of a key which should be used to encrypt this table. Note that the default bigquery service account will need to have encrypt/decrypt permissions on this key - you may want to see the google_bigquery_default_service_account datasource and the google_kms_crypto_key_iam_binding resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    [TerraformPropertyName("kms_key_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KmsKeyName { get; set; }


}

/// <summary>
/// Block type for external_catalog_table_options in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalCatalogTableOptionsBlock
{
    /// <summary>
    /// The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connection is needed to read the open source table from BigQuery Engine. The connection_id can have the form &amp;lt;project_id&amp;gt;.&amp;lt;location_id&amp;gt;.&amp;lt;connection_id&amp;gt; or projects/&amp;lt;project_id&amp;gt;/locations/&amp;lt;location_id&amp;gt;/connections/&amp;lt;connection_id&amp;gt;.
    /// </summary>
    [TerraformPropertyName("connection_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionId { get; set; }

    /// <summary>
    /// A map of key value pairs defining the parameters and properties of the open source table. Corresponds with hive meta store table parameters. Maximum size of 4Mib.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Parameters { get; set; }

}

/// <summary>
/// Block type for external_data_configuration in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalDataConfigurationBlock
{
    /// <summary>
    /// Let BigQuery try to autodetect the schema and format of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Autodetect is required")]
    [TerraformPropertyName("autodetect")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Autodetect { get; set; }

    /// <summary>
    /// The compression type of the data source. Valid values are &amp;quot;NONE&amp;quot; or &amp;quot;GZIP&amp;quot;.
    /// </summary>
    [TerraformPropertyName("compression")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Compression { get; set; }

    /// <summary>
    /// The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connectionId can have the form &amp;quot;&amp;lt;project&amp;gt;.&amp;lt;location&amp;gt;.&amp;lt;connection_id&amp;gt;&amp;quot; or &amp;quot;projects/&amp;lt;project&amp;gt;/locations/&amp;lt;location&amp;gt;/connections/&amp;lt;connection_id&amp;gt;&amp;quot;.
    /// </summary>
    [TerraformPropertyName("connection_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionId { get; set; }

    /// <summary>
    /// Specifies how source URIs are interpreted for constructing the file set to load.  By default source URIs are expanded against the underlying storage.  Other options include specifying manifest files. Only applicable to object storage systems.
    /// </summary>
    [TerraformPropertyName("file_set_spec_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FileSetSpecType { get; set; }

    /// <summary>
    /// Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false.
    /// </summary>
    [TerraformPropertyName("ignore_unknown_values")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreUnknownValues { get; set; }

    /// <summary>
    /// Load option to be used together with sourceFormat newline-delimited JSON to indicate that a variant of JSON is being loaded. To load newline-delimited GeoJSON, specify GEOJSON (and sourceFormat must be set to NEWLINE_DELIMITED_JSON).
    /// </summary>
    [TerraformPropertyName("json_extension")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? JsonExtension { get; set; }

    /// <summary>
    /// The maximum number of bad records that BigQuery can ignore when reading data.
    /// </summary>
    [TerraformPropertyName("max_bad_records")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxBadRecords { get; set; }

    /// <summary>
    /// Metadata Cache Mode for the table. Set this to enable caching of metadata from external data source.
    /// </summary>
    [TerraformPropertyName("metadata_cache_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MetadataCacheMode { get; set; }

    /// <summary>
    /// Object Metadata is used to create Object Tables. Object Tables contain a listing of objects (with their metadata) found at the sourceUris. If ObjectMetadata is set, sourceFormat should be omitted.
    /// </summary>
    [TerraformPropertyName("object_metadata")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ObjectMetadata { get; set; }

    /// <summary>
    /// When creating an external table, the user can provide a reference file with the table schema. This is enabled for the following formats: AVRO, PARQUET, ORC.
    /// </summary>
    [TerraformPropertyName("reference_file_schema_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReferenceFileSchemaUri { get; set; }

    /// <summary>
    /// A JSON schema for the external table. Schema is required for CSV and JSON formats and is disallowed for Google Cloud Bigtable, Cloud Datastore backups, and Avro formats when using external tables.
    /// </summary>
    [TerraformPropertyName("schema")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Schema { get; set; } = default!;

    /// <summary>
    /// Please see sourceFormat under ExternalDataConfiguration in Bigquery&#39;s public API documentation (https://cloud.google.com/bigquery/docs/reference/rest/v2/tables#externaldataconfiguration) for supported formats. To use &amp;quot;GOOGLE_SHEETS&amp;quot; the scopes must include &amp;quot;googleapis.com/auth/drive.readonly&amp;quot;.
    /// </summary>
    [TerraformPropertyName("source_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceFormat { get; set; }

    /// <summary>
    /// A list of the fully-qualified URIs that point to your data in Google Cloud.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUris is required")]
    [TerraformPropertyName("source_uris")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? SourceUris { get; set; }

}

/// <summary>
/// Block type for materialized_view in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableMaterializedViewBlock
{
    /// <summary>
    /// Allow non incremental materialized view definition. The default value is false.
    /// </summary>
    [TerraformPropertyName("allow_non_incremental_definition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowNonIncrementalDefinition { get; set; }

    /// <summary>
    /// Specifies if BigQuery should automatically refresh materialized view when the base table is updated. The default is true.
    /// </summary>
    [TerraformPropertyName("enable_refresh")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableRefresh { get; set; }

    /// <summary>
    /// A query whose result is persisted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformPropertyName("query")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Query { get; set; }

    /// <summary>
    /// Specifies maximum frequency at which this materialized view will be refreshed. The default is 1800000.
    /// </summary>
    [TerraformPropertyName("refresh_interval_ms")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RefreshIntervalMs { get; set; }

}

/// <summary>
/// Block type for range_partitioning in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableRangePartitioningBlock
{
    /// <summary>
    /// The field used to determine how to create a range-based partition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    [TerraformPropertyName("field")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Field { get; set; }

}

/// <summary>
/// Block type for schema_foreign_type_info in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableSchemaForeignTypeInfoBlock
{
    /// <summary>
    /// Specifies the system which defines the foreign data type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeSystem is required")]
    [TerraformPropertyName("type_system")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TypeSystem { get; set; }

}

/// <summary>
/// Block type for table_constraints in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTableConstraintsBlock
{
}

/// <summary>
/// Block type for table_replication_info in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTableReplicationInfoBlock
{
    /// <summary>
    /// The interval at which the source materialized view is polled for updates. The default is 300000.
    /// </summary>
    [TerraformPropertyName("replication_interval_ms")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ReplicationIntervalMs { get; set; }

    /// <summary>
    /// The ID of the source dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDatasetId is required")]
    [TerraformPropertyName("source_dataset_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceDatasetId { get; set; }

    /// <summary>
    /// The ID of the source project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceProjectId is required")]
    [TerraformPropertyName("source_project_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceProjectId { get; set; }

    /// <summary>
    /// The ID of the source materialized view.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceTableId is required")]
    [TerraformPropertyName("source_table_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceTableId { get; set; }

}

/// <summary>
/// Block type for time_partitioning in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTimePartitioningBlock
{
    /// <summary>
    /// Number of milliseconds for which to keep the storage for a partition.
    /// </summary>
    [TerraformPropertyName("expiration_ms")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ExpirationMs { get; set; } = default!;

    /// <summary>
    /// The field used to determine how to create a time-based partition. If time-based partitioning is enabled without this value, the table is partitioned based on the load time.
    /// </summary>
    [TerraformPropertyName("field")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Field { get; set; }

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("require_partition_filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequirePartitionFilter { get; set; }

    /// <summary>
    /// The supported types are DAY, HOUR, MONTH, and YEAR, which will generate one partition per day, hour, month, and year, respectively.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for view in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableViewBlock
{
    /// <summary>
    /// A query that BigQuery executes when the view is referenced.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformPropertyName("query")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Query { get; set; }

    /// <summary>
    /// Specifies whether to use BigQuery&#39;s legacy SQL for this view. If set to false, the view will use BigQuery&#39;s standard SQL
    /// </summary>
    [TerraformPropertyName("use_legacy_sql")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> UseLegacySql { get; set; } = default!;

}

/// <summary>
/// Manages a google_bigquery_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryTable : TerraformResource
{
    public GoogleBigqueryTable(string name) : base("google_bigquery_table", name)
    {
    }

    /// <summary>
    /// Specifies column names to use for data clustering. Up to four top-level columns are allowed, and should be specified in descending priority order.
    /// </summary>
    [TerraformPropertyName("clustering")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Clustering { get; set; }

    /// <summary>
    /// The dataset ID to create the table in. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformPropertyName("dataset_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DatasetId { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance. When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the table will fail. When the field is set to false, deleting the table is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The field description.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.
    /// </summary>
    [TerraformPropertyName("expiration_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ExpirationTime { get; set; } = default!;

    /// <summary>
    /// A descriptive name for the table.
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FriendlyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Whether Terraform will prevent implicitly added columns in schema from showing diff.
    /// </summary>
    [TerraformPropertyName("ignore_auto_generated_schema")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreAutoGeneratedSchema { get; set; }

    /// <summary>
    /// Mention which fields in schema are to be ignored
    /// </summary>
    [TerraformPropertyName("ignore_schema_changes")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? IgnoreSchemaChanges { get; set; }

    /// <summary>
    /// A mapping of labels to assign to the resource.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of [SQL IntervalValue type](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-types#interval_type).
    /// </summary>
    [TerraformPropertyName("max_staleness")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaxStaleness { get; set; } = default!;

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    [TerraformPropertyName("require_partition_filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequirePartitionFilter { get; set; }

    /// <summary>
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example &amp;quot;Production&amp;quot;.
    /// </summary>
    [TerraformPropertyName("resource_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceTags { get; set; }

    /// <summary>
    /// A JSON schema for the table.
    /// </summary>
    [TerraformPropertyName("schema")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Schema { get; set; } = default!;

    /// <summary>
    /// A unique ID for the resource. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    [TerraformPropertyName("table_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TableId { get; set; }

    /// <summary>
    /// View sets the optional parameter &amp;quot;view&amp;quot;: Specifies the view that determines which table information is returned. By default, basic table information and storage statistics (STORAGE_STATS) are returned. Possible values: TABLE_METADATA_VIEW_UNSPECIFIED, BASIC, STORAGE_STATS, FULL
    /// </summary>
    [TerraformPropertyName("table_metadata_view")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TableMetadataView { get; set; }

    /// <summary>
    /// Block for biglake_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BiglakeConfiguration block(s) allowed")]
    [TerraformPropertyName("biglake_configuration")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableBiglakeConfigurationBlock>>? BiglakeConfiguration { get; set; }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformPropertyName("encryption_configuration")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for external_catalog_table_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalCatalogTableOptions block(s) allowed")]
    [TerraformPropertyName("external_catalog_table_options")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableExternalCatalogTableOptionsBlock>>? ExternalCatalogTableOptions { get; set; }

    /// <summary>
    /// Block for external_data_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalDataConfiguration block(s) allowed")]
    [TerraformPropertyName("external_data_configuration")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableExternalDataConfigurationBlock>>? ExternalDataConfiguration { get; set; }

    /// <summary>
    /// Block for materialized_view.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaterializedView block(s) allowed")]
    [TerraformPropertyName("materialized_view")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableMaterializedViewBlock>>? MaterializedView { get; set; }

    /// <summary>
    /// Block for range_partitioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RangePartitioning block(s) allowed")]
    [TerraformPropertyName("range_partitioning")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableRangePartitioningBlock>>? RangePartitioning { get; set; }

    /// <summary>
    /// Block for schema_foreign_type_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaForeignTypeInfo block(s) allowed")]
    [TerraformPropertyName("schema_foreign_type_info")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableSchemaForeignTypeInfoBlock>>? SchemaForeignTypeInfo { get; set; }

    /// <summary>
    /// Block for table_constraints.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableConstraints block(s) allowed")]
    [TerraformPropertyName("table_constraints")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableTableConstraintsBlock>>? TableConstraints { get; set; }

    /// <summary>
    /// Block for table_replication_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableReplicationInfo block(s) allowed")]
    [TerraformPropertyName("table_replication_info")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableTableReplicationInfoBlock>>? TableReplicationInfo { get; set; }

    /// <summary>
    /// Block for time_partitioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePartitioning block(s) allowed")]
    [TerraformPropertyName("time_partitioning")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableTimePartitioningBlock>>? TimePartitioning { get; set; }

    /// <summary>
    /// Block for view.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 View block(s) allowed")]
    [TerraformPropertyName("view")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableViewBlock>>? View { get; set; }

    /// <summary>
    /// The time when this table was created, in milliseconds since the epoch.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CreationTime => new TerraformReference(this, "creation_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// (Output-only) A list of autogenerated schema fields.
    /// </summary>
    [TerraformPropertyName("generated_schema_columns")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GeneratedSchemaColumns => new TerraformReference(this, "generated_schema_columns");

    /// <summary>
    /// The time when this table was last modified, in milliseconds since the epoch.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> LastModifiedTime => new TerraformReference(this, "last_modified_time");

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    [TerraformPropertyName("num_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumBytes => new TerraformReference(this, "num_bytes");

    /// <summary>
    /// The number of bytes in the table that are considered &amp;quot;long-term storage&amp;quot;.
    /// </summary>
    [TerraformPropertyName("num_long_term_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumLongTermBytes => new TerraformReference(this, "num_long_term_bytes");

    /// <summary>
    /// The number of rows of data in this table, excluding any data in the streaming buffer.
    /// </summary>
    [TerraformPropertyName("num_rows")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumRows => new TerraformReference(this, "num_rows");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Describes the table type.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

}
