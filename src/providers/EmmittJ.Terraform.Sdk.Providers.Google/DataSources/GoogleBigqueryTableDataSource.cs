using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_bigquery_table Terraform data source.
/// Retrieves information about a google_bigquery_table.
/// </summary>
public partial class GoogleBigqueryTableDataSource(string name) : TerraformDataSource("google_bigquery_table", name)
{
    /// <summary>
    /// The dataset ID to create the table in. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => new TerraformReference<string>(this, "dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// A unique ID for the resource. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => new TerraformReference<string>(this, "table_id");
        set => SetArgument("table_id", value);
    }

    /// <summary>
    /// Specifies the configuration of a BigLake managed table.
    /// </summary>
    public TerraformList<TerraformMap<object>> BiglakeConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "biglake_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// Specifies column names to use for data clustering. Up to four top-level columns are allowed, and should be specified in descending priority order.
    /// </summary>
    public TerraformList<string> Clustering
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "clustering").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time when this table was created, in milliseconds since the epoch.
    /// </summary>
    public TerraformValue<double> CreationTime
    {
        get => new TerraformReference<double>(this, "creation_time");
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance. When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the table will fail. When the field is set to false, deleting the table is allowed.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
    }

    /// <summary>
    /// The field description.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Specifies how the table should be encrypted. If left blank, the table will be encrypted with a Google-managed key; that process is transparent to the user.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.
    /// </summary>
    public TerraformValue<double> ExpirationTime
    {
        get => new TerraformReference<double>(this, "expiration_time");
    }

    /// <summary>
    /// Options defining open source compatible table.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExternalCatalogTableOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "external_catalog_table_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExternalDataConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "external_data_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// A descriptive name for the table.
    /// </summary>
    public TerraformValue<string> FriendlyName
    {
        get => new TerraformReference<string>(this, "friendly_name");
    }

    /// <summary>
    /// (Output-only) A list of autogenerated schema fields.
    /// </summary>
    public TerraformValue<string> GeneratedSchemaColumns
    {
        get => new TerraformReference<string>(this, "generated_schema_columns");
    }

    /// <summary>
    /// Whether Terraform will prevent implicitly added columns in schema from showing diff.
    /// </summary>
    public TerraformValue<bool> IgnoreAutoGeneratedSchema
    {
        get => new TerraformReference<bool>(this, "ignore_auto_generated_schema");
    }

    /// <summary>
    /// Mention which fields in schema are to be ignored
    /// </summary>
    public TerraformList<string> IgnoreSchemaChanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ignore_schema_changes").ResolveNodes(ctx));
    }

    /// <summary>
    /// A mapping of labels to assign to the resource.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time when this table was last modified, in milliseconds since the epoch.
    /// </summary>
    public TerraformValue<double> LastModifiedTime
    {
        get => new TerraformReference<double>(this, "last_modified_time");
    }

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// If specified, configures this table as a materialized view.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaterializedView
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "materialized_view").ResolveNodes(ctx));
    }

    /// <summary>
    /// The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of [SQL IntervalValue type](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-types#interval_type).
    /// </summary>
    public TerraformValue<string> MaxStaleness
    {
        get => new TerraformReference<string>(this, "max_staleness");
    }

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    public TerraformValue<double> NumBytes
    {
        get => new TerraformReference<double>(this, "num_bytes");
    }

    /// <summary>
    /// The number of bytes in the table that are considered &amp;quot;long-term storage&amp;quot;.
    /// </summary>
    public TerraformValue<double> NumLongTermBytes
    {
        get => new TerraformReference<double>(this, "num_long_term_bytes");
    }

    /// <summary>
    /// The number of rows of data in this table, excluding any data in the streaming buffer.
    /// </summary>
    public TerraformValue<double> NumRows
    {
        get => new TerraformReference<double>(this, "num_rows");
    }

    /// <summary>
    /// If specified, configures range-based partitioning for this table.
    /// </summary>
    public TerraformList<TerraformMap<object>> RangePartitioning
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "range_partitioning").ResolveNodes(ctx));
    }

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    public TerraformValue<bool> RequirePartitionFilter
    {
        get => new TerraformReference<bool>(this, "require_partition_filter");
    }

    /// <summary>
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example &amp;quot;Production&amp;quot;.
    /// </summary>
    public TerraformMap<string> ResourceTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// A JSON schema for the table.
    /// </summary>
    public TerraformValue<string> Schema
    {
        get => new TerraformReference<string>(this, "schema");
    }

    /// <summary>
    /// Specifies metadata of the foreign data type definition in field schema.
    /// </summary>
    public TerraformList<TerraformMap<object>> SchemaForeignTypeInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "schema_foreign_type_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Defines the primary key and foreign keys.
    /// </summary>
    public TerraformList<TerraformMap<object>> TableConstraints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "table_constraints").ResolveNodes(ctx));
    }

    /// <summary>
    /// View sets the optional parameter &amp;quot;view&amp;quot;: Specifies the view that determines which table information is returned. By default, basic table information and storage statistics (STORAGE_STATS) are returned. Possible values: TABLE_METADATA_VIEW_UNSPECIFIED, BASIC, STORAGE_STATS, FULL
    /// </summary>
    public TerraformValue<string> TableMetadataView
    {
        get => new TerraformReference<string>(this, "table_metadata_view");
    }

    /// <summary>
    /// Replication info of a table created using &amp;quot;AS REPLICA&amp;quot; DDL like: &amp;quot;CREATE MATERIALIZED VIEW mv1 AS REPLICA OF src_mv&amp;quot;.
    /// </summary>
    public TerraformList<TerraformMap<object>> TableReplicationInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "table_replication_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// If specified, configures time-based partitioning for this table.
    /// </summary>
    public TerraformList<TerraformMap<object>> TimePartitioning
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "time_partitioning").ResolveNodes(ctx));
    }

    /// <summary>
    /// Describes the table type.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// If specified, configures this table as a view.
    /// </summary>
    public TerraformList<TerraformMap<object>> View
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "view").ResolveNodes(ctx));
    }

}
