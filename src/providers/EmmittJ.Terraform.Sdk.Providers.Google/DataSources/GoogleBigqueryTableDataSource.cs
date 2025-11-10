using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_table.
/// </summary>
public class GoogleBigqueryTableDataSource : TerraformDataSource
{
    public GoogleBigqueryTableDataSource(string name) : base("google_bigquery_table", name)
    {
    }

    /// <summary>
    /// The dataset ID to create the table in. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformPropertyName("dataset_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatasetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// A unique ID for the resource. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    [TerraformPropertyName("table_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TableId { get; set; }

    /// <summary>
    /// Specifies the configuration of a BigLake managed table.
    /// </summary>
    [TerraformPropertyName("biglake_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BiglakeConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "biglake_configuration");

    /// <summary>
    /// Specifies column names to use for data clustering. Up to four top-level columns are allowed, and should be specified in descending priority order.
    /// </summary>
    [TerraformPropertyName("clustering")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Clustering => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "clustering");

    /// <summary>
    /// The time when this table was created, in milliseconds since the epoch.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CreationTime => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "creation_time");

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance. When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the table will fail. When the field is set to false, deleting the table is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeletionProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection");

    /// <summary>
    /// The field description.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Specifies how the table should be encrypted. If left blank, the table will be encrypted with a Google-managed key; that process is transparent to the user.
    /// </summary>
    [TerraformPropertyName("encryption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EncryptionConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption_configuration");

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.
    /// </summary>
    [TerraformPropertyName("expiration_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ExpirationTime => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "expiration_time");

    /// <summary>
    /// Options defining open source compatible table.
    /// </summary>
    [TerraformPropertyName("external_catalog_table_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ExternalCatalogTableOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "external_catalog_table_options");

    /// <summary>
    /// Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table.
    /// </summary>
    [TerraformPropertyName("external_data_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ExternalDataConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "external_data_configuration");

    /// <summary>
    /// A descriptive name for the table.
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FriendlyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "friendly_name");

    /// <summary>
    /// (Output-only) A list of autogenerated schema fields.
    /// </summary>
    [TerraformPropertyName("generated_schema_columns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GeneratedSchemaColumns => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "generated_schema_columns");

    /// <summary>
    /// Whether Terraform will prevent implicitly added columns in schema from showing diff.
    /// </summary>
    [TerraformPropertyName("ignore_auto_generated_schema")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IgnoreAutoGeneratedSchema => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ignore_auto_generated_schema");

    /// <summary>
    /// Mention which fields in schema are to be ignored
    /// </summary>
    [TerraformPropertyName("ignore_schema_changes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> IgnoreSchemaChanges => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "ignore_schema_changes");

    /// <summary>
    /// A mapping of labels to assign to the resource.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The time when this table was last modified, in milliseconds since the epoch.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LastModifiedTime => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "last_modified_time");

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// If specified, configures this table as a materialized view.
    /// </summary>
    [TerraformPropertyName("materialized_view")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaterializedView => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "materialized_view");

    /// <summary>
    /// The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of [SQL IntervalValue type](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-types#interval_type).
    /// </summary>
    [TerraformPropertyName("max_staleness")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MaxStaleness => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "max_staleness");

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    [TerraformPropertyName("num_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "num_bytes");

    /// <summary>
    /// The number of bytes in the table that are considered &amp;quot;long-term storage&amp;quot;.
    /// </summary>
    [TerraformPropertyName("num_long_term_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumLongTermBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "num_long_term_bytes");

    /// <summary>
    /// The number of rows of data in this table, excluding any data in the streaming buffer.
    /// </summary>
    [TerraformPropertyName("num_rows")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumRows => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "num_rows");

    /// <summary>
    /// If specified, configures range-based partitioning for this table.
    /// </summary>
    [TerraformPropertyName("range_partitioning")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RangePartitioning => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "range_partitioning");

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    [TerraformPropertyName("require_partition_filter")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RequirePartitionFilter => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "require_partition_filter");

    /// <summary>
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example &amp;quot;Production&amp;quot;.
    /// </summary>
    [TerraformPropertyName("resource_tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ResourceTags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "resource_tags");

    /// <summary>
    /// A JSON schema for the table.
    /// </summary>
    [TerraformPropertyName("schema")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Schema => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "schema");

    /// <summary>
    /// Specifies metadata of the foreign data type definition in field schema.
    /// </summary>
    [TerraformPropertyName("schema_foreign_type_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SchemaForeignTypeInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "schema_foreign_type_info");

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// Defines the primary key and foreign keys.
    /// </summary>
    [TerraformPropertyName("table_constraints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TableConstraints => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "table_constraints");

    /// <summary>
    /// View sets the optional parameter &amp;quot;view&amp;quot;: Specifies the view that determines which table information is returned. By default, basic table information and storage statistics (STORAGE_STATS) are returned. Possible values: TABLE_METADATA_VIEW_UNSPECIFIED, BASIC, STORAGE_STATS, FULL
    /// </summary>
    [TerraformPropertyName("table_metadata_view")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TableMetadataView => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "table_metadata_view");

    /// <summary>
    /// Replication info of a table created using &amp;quot;AS REPLICA&amp;quot; DDL like: &amp;quot;CREATE MATERIALIZED VIEW mv1 AS REPLICA OF src_mv&amp;quot;.
    /// </summary>
    [TerraformPropertyName("table_replication_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TableReplicationInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "table_replication_info");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// If specified, configures time-based partitioning for this table.
    /// </summary>
    [TerraformPropertyName("time_partitioning")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TimePartitioning => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "time_partitioning");

    /// <summary>
    /// Describes the table type.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// If specified, configures this table as a view.
    /// </summary>
    [TerraformPropertyName("view")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> View => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "view");

}
