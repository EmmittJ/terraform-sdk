using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for biglake_configuration in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryTableBiglakeConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection specifying the credentials to be used to read and write to external storage, such as Cloud Storage. The connection_id can have the form &amp;quot;&amp;amp;lt;project\_id&amp;amp;gt;.&amp;amp;lt;location\_id&amp;amp;gt;.&amp;amp;lt;connection\_id&amp;amp;gt;&amp;quot; or &amp;quot;projects/&amp;amp;lt;project\_id&amp;amp;gt;/locations/&amp;amp;lt;location\_id&amp;amp;gt;/connections/&amp;amp;lt;connection\_id&amp;amp;gt;&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformProperty("connection_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectionId { get; set; }

    /// <summary>
    /// The file format the data is stored in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileFormat is required")]
    [TerraformProperty("file_format")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FileFormat { get; set; }

    /// <summary>
    /// The fully qualified location prefix of the external folder where table data is stored. The &#39;*&#39; wildcard character is not allowed. The URI should be in the format &amp;quot;gs://bucket/path_to_table/&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    [TerraformProperty("storage_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageUri { get; set; }

    /// <summary>
    /// The table format the metadata only snapshots are stored in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableFormat is required")]
    [TerraformProperty("table_format")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TableFormat { get; set; }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryTableEncryptionConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The self link or full name of a key which should be used to encrypt this table. Note that the default bigquery service account will need to have encrypt/decrypt permissions on this key - you may want to see the google_bigquery_default_service_account datasource and the google_kms_crypto_key_iam_binding resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    [TerraformProperty("kms_key_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KmsKeyName { get; set; }


}

/// <summary>
/// Block type for external_catalog_table_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryTableExternalCatalogTableOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connection is needed to read the open source table from BigQuery Engine. The connection_id can have the form &amp;lt;project_id&amp;gt;.&amp;lt;location_id&amp;gt;.&amp;lt;connection_id&amp;gt; or projects/&amp;lt;project_id&amp;gt;/locations/&amp;lt;location_id&amp;gt;/connections/&amp;lt;connection_id&amp;gt;.
    /// </summary>
    [TerraformProperty("connection_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectionId { get; set; }

    /// <summary>
    /// A map of key value pairs defining the parameters and properties of the open source table. Corresponds with hive meta store table parameters. Maximum size of 4Mib.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Parameters { get; set; }

}

/// <summary>
/// Block type for external_data_configuration in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryTableExternalDataConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// Let BigQuery try to autodetect the schema and format of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Autodetect is required")]
    [TerraformProperty("autodetect")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Autodetect { get; set; }

    /// <summary>
    /// The compression type of the data source. Valid values are &amp;quot;NONE&amp;quot; or &amp;quot;GZIP&amp;quot;.
    /// </summary>
    [TerraformProperty("compression")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Compression { get; set; }

    /// <summary>
    /// The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connectionId can have the form &amp;quot;&amp;lt;project&amp;gt;.&amp;lt;location&amp;gt;.&amp;lt;connection_id&amp;gt;&amp;quot; or &amp;quot;projects/&amp;lt;project&amp;gt;/locations/&amp;lt;location&amp;gt;/connections/&amp;lt;connection_id&amp;gt;&amp;quot;.
    /// </summary>
    [TerraformProperty("connection_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectionId { get; set; }

    /// <summary>
    /// Specifies how source URIs are interpreted for constructing the file set to load.  By default source URIs are expanded against the underlying storage.  Other options include specifying manifest files. Only applicable to object storage systems.
    /// </summary>
    [TerraformProperty("file_set_spec_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FileSetSpecType { get; set; }

    /// <summary>
    /// Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false.
    /// </summary>
    [TerraformProperty("ignore_unknown_values")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IgnoreUnknownValues { get; set; }

    /// <summary>
    /// Load option to be used together with sourceFormat newline-delimited JSON to indicate that a variant of JSON is being loaded. To load newline-delimited GeoJSON, specify GEOJSON (and sourceFormat must be set to NEWLINE_DELIMITED_JSON).
    /// </summary>
    [TerraformProperty("json_extension")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? JsonExtension { get; set; }

    /// <summary>
    /// The maximum number of bad records that BigQuery can ignore when reading data.
    /// </summary>
    [TerraformProperty("max_bad_records")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxBadRecords { get; set; }

    /// <summary>
    /// Metadata Cache Mode for the table. Set this to enable caching of metadata from external data source.
    /// </summary>
    [TerraformProperty("metadata_cache_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MetadataCacheMode { get; set; }

    /// <summary>
    /// Object Metadata is used to create Object Tables. Object Tables contain a listing of objects (with their metadata) found at the sourceUris. If ObjectMetadata is set, sourceFormat should be omitted.
    /// </summary>
    [TerraformProperty("object_metadata")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ObjectMetadata { get; set; }

    /// <summary>
    /// When creating an external table, the user can provide a reference file with the table schema. This is enabled for the following formats: AVRO, PARQUET, ORC.
    /// </summary>
    [TerraformProperty("reference_file_schema_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ReferenceFileSchemaUri { get; set; }

    /// <summary>
    /// A JSON schema for the external table. Schema is required for CSV and JSON formats and is disallowed for Google Cloud Bigtable, Cloud Datastore backups, and Avro formats when using external tables.
    /// </summary>
    [TerraformProperty("schema")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Schema { get; set; }

    /// <summary>
    /// Please see sourceFormat under ExternalDataConfiguration in Bigquery&#39;s public API documentation (https://cloud.google.com/bigquery/docs/reference/rest/v2/tables#externaldataconfiguration) for supported formats. To use &amp;quot;GOOGLE_SHEETS&amp;quot; the scopes must include &amp;quot;googleapis.com/auth/drive.readonly&amp;quot;.
    /// </summary>
    [TerraformProperty("source_format")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceFormat { get; set; }

    /// <summary>
    /// A list of the fully-qualified URIs that point to your data in Google Cloud.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUris is required")]
    [TerraformProperty("source_uris")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? SourceUris { get; set; }

}

/// <summary>
/// Block type for materialized_view in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryTableMaterializedViewBlock : TerraformBlockBase
{
    /// <summary>
    /// Allow non incremental materialized view definition. The default value is false.
    /// </summary>
    [TerraformProperty("allow_non_incremental_definition")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowNonIncrementalDefinition { get; set; }

    /// <summary>
    /// Specifies if BigQuery should automatically refresh materialized view when the base table is updated. The default is true.
    /// </summary>
    [TerraformProperty("enable_refresh")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableRefresh { get; set; }

    /// <summary>
    /// A query whose result is persisted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformProperty("query")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Query { get; set; }

    /// <summary>
    /// Specifies maximum frequency at which this materialized view will be refreshed. The default is 1800000.
    /// </summary>
    [TerraformProperty("refresh_interval_ms")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RefreshIntervalMs { get; set; }

}

/// <summary>
/// Block type for range_partitioning in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryTableRangePartitioningBlock : TerraformBlockBase
{
    /// <summary>
    /// The field used to determine how to create a range-based partition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    [TerraformProperty("field")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Field { get; set; }

}

/// <summary>
/// Block type for schema_foreign_type_info in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryTableSchemaForeignTypeInfoBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies the system which defines the foreign data type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeSystem is required")]
    [TerraformProperty("type_system")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TypeSystem { get; set; }

}

/// <summary>
/// Block type for table_constraints in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryTableTableConstraintsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for table_replication_info in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryTableTableReplicationInfoBlock : TerraformBlockBase
{
    /// <summary>
    /// The interval at which the source materialized view is polled for updates. The default is 300000.
    /// </summary>
    [TerraformProperty("replication_interval_ms")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ReplicationIntervalMs { get; set; }

    /// <summary>
    /// The ID of the source dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDatasetId is required")]
    [TerraformProperty("source_dataset_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceDatasetId { get; set; }

    /// <summary>
    /// The ID of the source project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceProjectId is required")]
    [TerraformProperty("source_project_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceProjectId { get; set; }

    /// <summary>
    /// The ID of the source materialized view.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceTableId is required")]
    [TerraformProperty("source_table_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceTableId { get; set; }

}

/// <summary>
/// Block type for time_partitioning in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryTableTimePartitioningBlock : TerraformBlockBase
{
    /// <summary>
    /// Number of milliseconds for which to keep the storage for a partition.
    /// </summary>
    [TerraformProperty("expiration_ms")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ExpirationMs { get; set; }

    /// <summary>
    /// The field used to determine how to create a time-based partition. If time-based partitioning is enabled without this value, the table is partitioned based on the load time.
    /// </summary>
    [TerraformProperty("field")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Field { get; set; }

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("require_partition_filter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequirePartitionFilter { get; set; }

    /// <summary>
    /// The supported types are DAY, HOUR, MONTH, and YEAR, which will generate one partition per day, hour, month, and year, respectively.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for view in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryTableViewBlock : TerraformBlockBase
{
    /// <summary>
    /// A query that BigQuery executes when the view is referenced.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformProperty("query")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Query { get; set; }

    /// <summary>
    /// Specifies whether to use BigQuery&#39;s legacy SQL for this view. If set to false, the view will use BigQuery&#39;s standard SQL
    /// </summary>
    [TerraformProperty("use_legacy_sql")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> UseLegacySql { get; set; }

}

/// <summary>
/// Manages a google_bigquery_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigqueryTable : TerraformResource
{
    public GoogleBigqueryTable(string name) : base("google_bigquery_table", name)
    {
    }

    /// <summary>
    /// Specifies column names to use for data clustering. Up to four top-level columns are allowed, and should be specified in descending priority order.
    /// </summary>
    [TerraformProperty("clustering")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Clustering { get; set; }

    /// <summary>
    /// The dataset ID to create the table in. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformProperty("dataset_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatasetId { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance. When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the table will fail. When the field is set to false, deleting the table is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The field description.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.
    /// </summary>
    [TerraformProperty("expiration_time")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ExpirationTime { get; set; }

    /// <summary>
    /// A descriptive name for the table.
    /// </summary>
    [TerraformProperty("friendly_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FriendlyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Whether Terraform will prevent implicitly added columns in schema from showing diff.
    /// </summary>
    [TerraformProperty("ignore_auto_generated_schema")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IgnoreAutoGeneratedSchema { get; set; }

    /// <summary>
    /// Mention which fields in schema are to be ignored
    /// </summary>
    [TerraformProperty("ignore_schema_changes")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? IgnoreSchemaChanges { get; set; }

    /// <summary>
    /// A mapping of labels to assign to the resource.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of [SQL IntervalValue type](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-types#interval_type).
    /// </summary>
    [TerraformProperty("max_staleness")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MaxStaleness { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    [TerraformProperty("require_partition_filter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequirePartitionFilter { get; set; }

    /// <summary>
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example &amp;quot;Production&amp;quot;.
    /// </summary>
    [TerraformProperty("resource_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ResourceTags { get; set; }

    /// <summary>
    /// A JSON schema for the table.
    /// </summary>
    [TerraformProperty("schema")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Schema { get; set; }

    /// <summary>
    /// A unique ID for the resource. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    [TerraformProperty("table_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TableId { get; set; }

    /// <summary>
    /// View sets the optional parameter &amp;quot;view&amp;quot;: Specifies the view that determines which table information is returned. By default, basic table information and storage statistics (STORAGE_STATS) are returned. Possible values: TABLE_METADATA_VIEW_UNSPECIFIED, BASIC, STORAGE_STATS, FULL
    /// </summary>
    [TerraformProperty("table_metadata_view")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TableMetadataView { get; set; }

    /// <summary>
    /// Block for biglake_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BiglakeConfiguration block(s) allowed")]
    [TerraformProperty("biglake_configuration")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableBiglakeConfigurationBlock>>? BiglakeConfiguration { get; set; }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformProperty("encryption_configuration")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for external_catalog_table_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalCatalogTableOptions block(s) allowed")]
    [TerraformProperty("external_catalog_table_options")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableExternalCatalogTableOptionsBlock>>? ExternalCatalogTableOptions { get; set; }

    /// <summary>
    /// Block for external_data_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalDataConfiguration block(s) allowed")]
    [TerraformProperty("external_data_configuration")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableExternalDataConfigurationBlock>>? ExternalDataConfiguration { get; set; }

    /// <summary>
    /// Block for materialized_view.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaterializedView block(s) allowed")]
    [TerraformProperty("materialized_view")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableMaterializedViewBlock>>? MaterializedView { get; set; }

    /// <summary>
    /// Block for range_partitioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RangePartitioning block(s) allowed")]
    [TerraformProperty("range_partitioning")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableRangePartitioningBlock>>? RangePartitioning { get; set; }

    /// <summary>
    /// Block for schema_foreign_type_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaForeignTypeInfo block(s) allowed")]
    [TerraformProperty("schema_foreign_type_info")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableSchemaForeignTypeInfoBlock>>? SchemaForeignTypeInfo { get; set; }

    /// <summary>
    /// Block for table_constraints.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableConstraints block(s) allowed")]
    [TerraformProperty("table_constraints")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableTableConstraintsBlock>>? TableConstraints { get; set; }

    /// <summary>
    /// Block for table_replication_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableReplicationInfo block(s) allowed")]
    [TerraformProperty("table_replication_info")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableTableReplicationInfoBlock>>? TableReplicationInfo { get; set; }

    /// <summary>
    /// Block for time_partitioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePartitioning block(s) allowed")]
    [TerraformProperty("time_partitioning")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableTimePartitioningBlock>>? TimePartitioning { get; set; }

    /// <summary>
    /// Block for view.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 View block(s) allowed")]
    [TerraformProperty("view")]
    public TerraformList<TerraformBlock<GoogleBigqueryTableViewBlock>>? View { get; set; }

    /// <summary>
    /// The time when this table was created, in milliseconds since the epoch.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> CreationTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// (Output-only) A list of autogenerated schema fields.
    /// </summary>
    [TerraformProperty("generated_schema_columns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GeneratedSchemaColumns { get; }

    /// <summary>
    /// The time when this table was last modified, in milliseconds since the epoch.
    /// </summary>
    [TerraformProperty("last_modified_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> LastModifiedTime { get; }

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    [TerraformProperty("num_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NumBytes { get; }

    /// <summary>
    /// The number of bytes in the table that are considered &amp;quot;long-term storage&amp;quot;.
    /// </summary>
    [TerraformProperty("num_long_term_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NumLongTermBytes { get; }

    /// <summary>
    /// The number of rows of data in this table, excluding any data in the streaming buffer.
    /// </summary>
    [TerraformProperty("num_rows")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NumRows { get; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Describes the table type.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

}
