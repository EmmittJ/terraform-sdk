using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for biglake_configuration in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableBiglakeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The connection specifying the credentials to be used to read and write to external storage, such as Cloud Storage. The connection_id can have the form &amp;quot;&amp;amp;lt;project\_id&amp;amp;gt;.&amp;amp;lt;location\_id&amp;amp;gt;.&amp;amp;lt;connection\_id&amp;amp;gt;&amp;quot; or &amp;quot;projects/&amp;amp;lt;project\_id&amp;amp;gt;/locations/&amp;amp;lt;location\_id&amp;amp;gt;/connections/&amp;amp;lt;connection\_id&amp;amp;gt;&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformProperty<string> ConnectionId
    {
        set => SetProperty("connection_id", value);
    }

    /// <summary>
    /// The file format the data is stored in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileFormat is required")]
    public required TerraformProperty<string> FileFormat
    {
        set => SetProperty("file_format", value);
    }

    /// <summary>
    /// The fully qualified location prefix of the external folder where table data is stored. The &#39;*&#39; wildcard character is not allowed. The URI should be in the format &amp;quot;gs://bucket/path_to_table/&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    public required TerraformProperty<string> StorageUri
    {
        set => SetProperty("storage_uri", value);
    }

    /// <summary>
    /// The table format the metadata only snapshots are stored in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableFormat is required")]
    public required TerraformProperty<string> TableFormat
    {
        set => SetProperty("table_format", value);
    }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The self link or full name of a key which should be used to encrypt this table. Note that the default bigquery service account will need to have encrypt/decrypt permissions on this key - you may want to see the google_bigquery_default_service_account datasource and the google_kms_crypto_key_iam_binding resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformProperty<string> KmsKeyName
    {
        set => SetProperty("kms_key_name", value);
    }

    /// <summary>
    /// The self link or full name of the kms key version used to encrypt this table.
    /// </summary>
    public TerraformProperty<string>? KmsKeyVersion
    {
        set => SetProperty("kms_key_version", value);
    }

}

/// <summary>
/// Block type for external_catalog_table_options in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalCatalogTableOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connection is needed to read the open source table from BigQuery Engine. The connection_id can have the form &amp;lt;project_id&amp;gt;.&amp;lt;location_id&amp;gt;.&amp;lt;connection_id&amp;gt; or projects/&amp;lt;project_id&amp;gt;/locations/&amp;lt;location_id&amp;gt;/connections/&amp;lt;connection_id&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? ConnectionId
    {
        set => SetProperty("connection_id", value);
    }

    /// <summary>
    /// A map of key value pairs defining the parameters and properties of the open source table. Corresponds with hive meta store table parameters. Maximum size of 4Mib.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        set => SetProperty("parameters", value);
    }

}

/// <summary>
/// Block type for external_data_configuration in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalDataConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Let BigQuery try to autodetect the schema and format of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Autodetect is required")]
    public required TerraformProperty<bool> Autodetect
    {
        set => SetProperty("autodetect", value);
    }

    /// <summary>
    /// The compression type of the data source. Valid values are &amp;quot;NONE&amp;quot; or &amp;quot;GZIP&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Compression
    {
        set => SetProperty("compression", value);
    }

    /// <summary>
    /// The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connectionId can have the form &amp;quot;&amp;lt;project&amp;gt;.&amp;lt;location&amp;gt;.&amp;lt;connection_id&amp;gt;&amp;quot; or &amp;quot;projects/&amp;lt;project&amp;gt;/locations/&amp;lt;location&amp;gt;/connections/&amp;lt;connection_id&amp;gt;&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? ConnectionId
    {
        set => SetProperty("connection_id", value);
    }

    /// <summary>
    /// Specifies how source URIs are interpreted for constructing the file set to load.  By default source URIs are expanded against the underlying storage.  Other options include specifying manifest files. Only applicable to object storage systems.
    /// </summary>
    public TerraformProperty<string>? FileSetSpecType
    {
        set => SetProperty("file_set_spec_type", value);
    }

    /// <summary>
    /// Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false.
    /// </summary>
    public TerraformProperty<bool>? IgnoreUnknownValues
    {
        set => SetProperty("ignore_unknown_values", value);
    }

    /// <summary>
    /// Load option to be used together with sourceFormat newline-delimited JSON to indicate that a variant of JSON is being loaded. To load newline-delimited GeoJSON, specify GEOJSON (and sourceFormat must be set to NEWLINE_DELIMITED_JSON).
    /// </summary>
    public TerraformProperty<string>? JsonExtension
    {
        set => SetProperty("json_extension", value);
    }

    /// <summary>
    /// The maximum number of bad records that BigQuery can ignore when reading data.
    /// </summary>
    public TerraformProperty<double>? MaxBadRecords
    {
        set => SetProperty("max_bad_records", value);
    }

    /// <summary>
    /// Metadata Cache Mode for the table. Set this to enable caching of metadata from external data source.
    /// </summary>
    public TerraformProperty<string>? MetadataCacheMode
    {
        set => SetProperty("metadata_cache_mode", value);
    }

    /// <summary>
    /// Object Metadata is used to create Object Tables. Object Tables contain a listing of objects (with their metadata) found at the sourceUris. If ObjectMetadata is set, sourceFormat should be omitted.
    /// </summary>
    public TerraformProperty<string>? ObjectMetadata
    {
        set => SetProperty("object_metadata", value);
    }

    /// <summary>
    /// When creating an external table, the user can provide a reference file with the table schema. This is enabled for the following formats: AVRO, PARQUET, ORC.
    /// </summary>
    public TerraformProperty<string>? ReferenceFileSchemaUri
    {
        set => SetProperty("reference_file_schema_uri", value);
    }

    /// <summary>
    /// A JSON schema for the external table. Schema is required for CSV and JSON formats and is disallowed for Google Cloud Bigtable, Cloud Datastore backups, and Avro formats when using external tables.
    /// </summary>
    public TerraformProperty<string>? Schema
    {
        set => SetProperty("schema", value);
    }

    /// <summary>
    /// Please see sourceFormat under ExternalDataConfiguration in Bigquery&#39;s public API documentation (https://cloud.google.com/bigquery/docs/reference/rest/v2/tables#externaldataconfiguration) for supported formats. To use &amp;quot;GOOGLE_SHEETS&amp;quot; the scopes must include &amp;quot;googleapis.com/auth/drive.readonly&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? SourceFormat
    {
        set => SetProperty("source_format", value);
    }

    /// <summary>
    /// A list of the fully-qualified URIs that point to your data in Google Cloud.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUris is required")]
    public List<TerraformProperty<string>>? SourceUris
    {
        set => SetProperty("source_uris", value);
    }

}

/// <summary>
/// Block type for materialized_view in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableMaterializedViewBlock : TerraformBlock
{
    /// <summary>
    /// Allow non incremental materialized view definition. The default value is false.
    /// </summary>
    public TerraformProperty<bool>? AllowNonIncrementalDefinition
    {
        set => SetProperty("allow_non_incremental_definition", value);
    }

    /// <summary>
    /// Specifies if BigQuery should automatically refresh materialized view when the base table is updated. The default is true.
    /// </summary>
    public TerraformProperty<bool>? EnableRefresh
    {
        set => SetProperty("enable_refresh", value);
    }

    /// <summary>
    /// A query whose result is persisted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformProperty<string> Query
    {
        set => SetProperty("query", value);
    }

    /// <summary>
    /// Specifies maximum frequency at which this materialized view will be refreshed. The default is 1800000.
    /// </summary>
    public TerraformProperty<double>? RefreshIntervalMs
    {
        set => SetProperty("refresh_interval_ms", value);
    }

}

/// <summary>
/// Block type for range_partitioning in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableRangePartitioningBlock : TerraformBlock
{
    /// <summary>
    /// The field used to determine how to create a range-based partition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    public required TerraformProperty<string> Field
    {
        set => SetProperty("field", value);
    }

}

/// <summary>
/// Block type for schema_foreign_type_info in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableSchemaForeignTypeInfoBlock : TerraformBlock
{
    /// <summary>
    /// Specifies the system which defines the foreign data type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeSystem is required")]
    public required TerraformProperty<string> TypeSystem
    {
        set => SetProperty("type_system", value);
    }

}

/// <summary>
/// Block type for table_constraints in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTableConstraintsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for table_replication_info in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTableReplicationInfoBlock : TerraformBlock
{
    /// <summary>
    /// The interval at which the source materialized view is polled for updates. The default is 300000.
    /// </summary>
    public TerraformProperty<double>? ReplicationIntervalMs
    {
        set => SetProperty("replication_interval_ms", value);
    }

    /// <summary>
    /// The ID of the source dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDatasetId is required")]
    public required TerraformProperty<string> SourceDatasetId
    {
        set => SetProperty("source_dataset_id", value);
    }

    /// <summary>
    /// The ID of the source project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceProjectId is required")]
    public required TerraformProperty<string> SourceProjectId
    {
        set => SetProperty("source_project_id", value);
    }

    /// <summary>
    /// The ID of the source materialized view.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceTableId is required")]
    public required TerraformProperty<string> SourceTableId
    {
        set => SetProperty("source_table_id", value);
    }

}

/// <summary>
/// Block type for time_partitioning in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTimePartitioningBlock : TerraformBlock
{
    /// <summary>
    /// Number of milliseconds for which to keep the storage for a partition.
    /// </summary>
    public TerraformProperty<double>? ExpirationMs
    {
        set => SetProperty("expiration_ms", value);
    }

    /// <summary>
    /// The field used to determine how to create a time-based partition. If time-based partitioning is enabled without this value, the table is partitioned based on the load time.
    /// </summary>
    public TerraformProperty<string>? Field
    {
        set => SetProperty("field", value);
    }

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? RequirePartitionFilter
    {
        set => SetProperty("require_partition_filter", value);
    }

    /// <summary>
    /// The supported types are DAY, HOUR, MONTH, and YEAR, which will generate one partition per day, hour, month, and year, respectively.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for view in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableViewBlock : TerraformBlock
{
    /// <summary>
    /// A query that BigQuery executes when the view is referenced.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformProperty<string> Query
    {
        set => SetProperty("query", value);
    }

    /// <summary>
    /// Specifies whether to use BigQuery&#39;s legacy SQL for this view. If set to false, the view will use BigQuery&#39;s standard SQL
    /// </summary>
    public TerraformProperty<bool>? UseLegacySql
    {
        set => SetProperty("use_legacy_sql", value);
    }

}

/// <summary>
/// Manages a google_bigquery_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryTable : TerraformResource
{
    public GoogleBigqueryTable(string name) : base("google_bigquery_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creation_time");
        SetOutput("effective_labels");
        SetOutput("etag");
        SetOutput("generated_schema_columns");
        SetOutput("last_modified_time");
        SetOutput("location");
        SetOutput("num_bytes");
        SetOutput("num_long_term_bytes");
        SetOutput("num_rows");
        SetOutput("self_link");
        SetOutput("terraform_labels");
        SetOutput("type");
        SetOutput("clustering");
        SetOutput("dataset_id");
        SetOutput("deletion_protection");
        SetOutput("description");
        SetOutput("expiration_time");
        SetOutput("friendly_name");
        SetOutput("id");
        SetOutput("ignore_auto_generated_schema");
        SetOutput("ignore_schema_changes");
        SetOutput("labels");
        SetOutput("max_staleness");
        SetOutput("project");
        SetOutput("require_partition_filter");
        SetOutput("resource_tags");
        SetOutput("schema");
        SetOutput("table_id");
        SetOutput("table_metadata_view");
    }

    /// <summary>
    /// Specifies column names to use for data clustering. Up to four top-level columns are allowed, and should be specified in descending priority order.
    /// </summary>
    public List<TerraformProperty<string>> Clustering
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("clustering");
        set => SetProperty("clustering", value);
    }

    /// <summary>
    /// The dataset ID to create the table in. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformProperty<string> DatasetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataset_id");
        set => SetProperty("dataset_id", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance. When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the table will fail. When the field is set to false, deleting the table is allowed.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// The field description.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.
    /// </summary>
    public TerraformProperty<double> ExpirationTime
    {
        get => GetRequiredOutput<TerraformProperty<double>>("expiration_time");
        set => SetProperty("expiration_time", value);
    }

    /// <summary>
    /// A descriptive name for the table.
    /// </summary>
    public TerraformProperty<string> FriendlyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("friendly_name");
        set => SetProperty("friendly_name", value);
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
    /// Whether Terraform will prevent implicitly added columns in schema from showing diff.
    /// </summary>
    public TerraformProperty<bool> IgnoreAutoGeneratedSchema
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_auto_generated_schema");
        set => SetProperty("ignore_auto_generated_schema", value);
    }

    /// <summary>
    /// Mention which fields in schema are to be ignored
    /// </summary>
    public List<TerraformProperty<string>> IgnoreSchemaChanges
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("ignore_schema_changes");
        set => SetProperty("ignore_schema_changes", value);
    }

    /// <summary>
    /// A mapping of labels to assign to the resource.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of [SQL IntervalValue type](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-types#interval_type).
    /// </summary>
    public TerraformProperty<string> MaxStaleness
    {
        get => GetRequiredOutput<TerraformProperty<string>>("max_staleness");
        set => SetProperty("max_staleness", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    public TerraformProperty<bool> RequirePartitionFilter
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_partition_filter");
        set => SetProperty("require_partition_filter", value);
    }

    /// <summary>
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example &amp;quot;Production&amp;quot;.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ResourceTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("resource_tags");
        set => SetProperty("resource_tags", value);
    }

    /// <summary>
    /// A JSON schema for the table.
    /// </summary>
    public TerraformProperty<string> Schema
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schema");
        set => SetProperty("schema", value);
    }

    /// <summary>
    /// A unique ID for the resource. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformProperty<string> TableId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_id");
        set => SetProperty("table_id", value);
    }

    /// <summary>
    /// View sets the optional parameter &amp;quot;view&amp;quot;: Specifies the view that determines which table information is returned. By default, basic table information and storage statistics (STORAGE_STATS) are returned. Possible values: TABLE_METADATA_VIEW_UNSPECIFIED, BASIC, STORAGE_STATS, FULL
    /// </summary>
    public TerraformProperty<string> TableMetadataView
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_metadata_view");
        set => SetProperty("table_metadata_view", value);
    }

    /// <summary>
    /// Block for biglake_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BiglakeConfiguration block(s) allowed")]
    public List<GoogleBigqueryTableBiglakeConfigurationBlock>? BiglakeConfiguration
    {
        set => SetProperty("biglake_configuration", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public List<GoogleBigqueryTableEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        set => SetProperty("encryption_configuration", value);
    }

    /// <summary>
    /// Block for external_catalog_table_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalCatalogTableOptions block(s) allowed")]
    public List<GoogleBigqueryTableExternalCatalogTableOptionsBlock>? ExternalCatalogTableOptions
    {
        set => SetProperty("external_catalog_table_options", value);
    }

    /// <summary>
    /// Block for external_data_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalDataConfiguration block(s) allowed")]
    public List<GoogleBigqueryTableExternalDataConfigurationBlock>? ExternalDataConfiguration
    {
        set => SetProperty("external_data_configuration", value);
    }

    /// <summary>
    /// Block for materialized_view.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaterializedView block(s) allowed")]
    public List<GoogleBigqueryTableMaterializedViewBlock>? MaterializedView
    {
        set => SetProperty("materialized_view", value);
    }

    /// <summary>
    /// Block for range_partitioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RangePartitioning block(s) allowed")]
    public List<GoogleBigqueryTableRangePartitioningBlock>? RangePartitioning
    {
        set => SetProperty("range_partitioning", value);
    }

    /// <summary>
    /// Block for schema_foreign_type_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaForeignTypeInfo block(s) allowed")]
    public List<GoogleBigqueryTableSchemaForeignTypeInfoBlock>? SchemaForeignTypeInfo
    {
        set => SetProperty("schema_foreign_type_info", value);
    }

    /// <summary>
    /// Block for table_constraints.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableConstraints block(s) allowed")]
    public List<GoogleBigqueryTableTableConstraintsBlock>? TableConstraints
    {
        set => SetProperty("table_constraints", value);
    }

    /// <summary>
    /// Block for table_replication_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableReplicationInfo block(s) allowed")]
    public List<GoogleBigqueryTableTableReplicationInfoBlock>? TableReplicationInfo
    {
        set => SetProperty("table_replication_info", value);
    }

    /// <summary>
    /// Block for time_partitioning.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePartitioning block(s) allowed")]
    public List<GoogleBigqueryTableTimePartitioningBlock>? TimePartitioning
    {
        set => SetProperty("time_partitioning", value);
    }

    /// <summary>
    /// Block for view.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 View block(s) allowed")]
    public List<GoogleBigqueryTableViewBlock>? View
    {
        set => SetProperty("view", value);
    }

    /// <summary>
    /// The time when this table was created, in milliseconds since the epoch.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// (Output-only) A list of autogenerated schema fields.
    /// </summary>
    public TerraformExpression GeneratedSchemaColumns => this["generated_schema_columns"];

    /// <summary>
    /// The time when this table was last modified, in milliseconds since the epoch.
    /// </summary>
    public TerraformExpression LastModifiedTime => this["last_modified_time"];

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    public TerraformExpression NumBytes => this["num_bytes"];

    /// <summary>
    /// The number of bytes in the table that are considered &amp;quot;long-term storage&amp;quot;.
    /// </summary>
    public TerraformExpression NumLongTermBytes => this["num_long_term_bytes"];

    /// <summary>
    /// The number of rows of data in this table, excluding any data in the streaming buffer.
    /// </summary>
    public TerraformExpression NumRows => this["num_rows"];

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Describes the table type.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
