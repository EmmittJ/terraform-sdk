using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for biglake_configuration in GoogleBigqueryTable.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableBiglakeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "biglake_configuration";

    /// <summary>
    /// The connection specifying the credentials to be used to read and write to external storage, such as Cloud Storage. The connection_id can have the form &amp;quot;&amp;amp;lt;project\_id&amp;amp;gt;.&amp;amp;lt;location\_id&amp;amp;gt;.&amp;amp;lt;connection\_id&amp;amp;gt;&amp;quot; or &amp;quot;projects/&amp;amp;lt;project\_id&amp;amp;gt;/locations/&amp;amp;lt;location\_id&amp;amp;gt;/connections/&amp;amp;lt;connection\_id&amp;amp;gt;&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformValue<string> ConnectionId
    {
        get => new TerraformReference<string>(this, "connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// The file format the data is stored in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileFormat is required")]
    public required TerraformValue<string> FileFormat
    {
        get => new TerraformReference<string>(this, "file_format");
        set => SetArgument("file_format", value);
    }

    /// <summary>
    /// The fully qualified location prefix of the external folder where table data is stored. The &#39;*&#39; wildcard character is not allowed. The URI should be in the format &amp;quot;gs://bucket/path_to_table/&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageUri is required")]
    public required TerraformValue<string> StorageUri
    {
        get => new TerraformReference<string>(this, "storage_uri");
        set => SetArgument("storage_uri", value);
    }

    /// <summary>
    /// The table format the metadata only snapshots are stored in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableFormat is required")]
    public required TerraformValue<string> TableFormat
    {
        get => new TerraformReference<string>(this, "table_format");
        set => SetArgument("table_format", value);
    }

}


/// <summary>
/// Block type for encryption_configuration in GoogleBigqueryTable.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The self link or full name of a key which should be used to encrypt this table. Note that the default bigquery service account will need to have encrypt/decrypt permissions on this key - you may want to see the google_bigquery_default_service_account datasource and the google_kms_crypto_key_iam_binding resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// The self link or full name of the kms key version used to encrypt this table.
    /// </summary>
    public TerraformValue<string> KmsKeyVersion
    {
        get => new TerraformReference<string>(this, "kms_key_version");
    }

}


/// <summary>
/// Block type for external_catalog_table_options in GoogleBigqueryTable.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalCatalogTableOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_catalog_table_options";

    /// <summary>
    /// The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connection is needed to read the open source table from BigQuery Engine. The connection_id can have the form &amp;lt;project_id&amp;gt;.&amp;lt;location_id&amp;gt;.&amp;lt;connection_id&amp;gt; or projects/&amp;lt;project_id&amp;gt;/locations/&amp;lt;location_id&amp;gt;/connections/&amp;lt;connection_id&amp;gt;.
    /// </summary>
    public TerraformValue<string>? ConnectionId
    {
        get => new TerraformReference<string>(this, "connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// A map of key value pairs defining the parameters and properties of the open source table. Corresponds with hive meta store table parameters. Maximum size of 4Mib.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// StorageDescriptor block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageDescriptor block(s) allowed")]
    public TerraformList<GoogleBigqueryTableExternalCatalogTableOptionsBlockStorageDescriptorBlock>? StorageDescriptor
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalCatalogTableOptionsBlockStorageDescriptorBlock>>("storage_descriptor");
        set => SetArgument("storage_descriptor", value);
    }

}

/// <summary>
/// Block type for storage_descriptor in GoogleBigqueryTableExternalCatalogTableOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalCatalogTableOptionsBlockStorageDescriptorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_descriptor";

    /// <summary>
    /// Specifies the fully qualified class name of the InputFormat (e.g. &amp;quot;org.apache.hadoop.hive.ql.io.orc.OrcInputFormat&amp;quot;). The maximum length is 128 characters.
    /// </summary>
    public TerraformValue<string>? InputFormat
    {
        get => new TerraformReference<string>(this, "input_format");
        set => SetArgument("input_format", value);
    }

    /// <summary>
    /// The physical location of the table (e.g. &#39;gs://spark-dataproc-data/pangea-data/case_sensitive/&#39; or &#39;gs://spark-dataproc-data/pangea-data/*&#39;). The maximum length is 2056 bytes.
    /// </summary>
    public TerraformValue<string>? LocationUri
    {
        get => new TerraformReference<string>(this, "location_uri");
        set => SetArgument("location_uri", value);
    }

    /// <summary>
    /// Specifies the fully qualified class name of the OutputFormat (e.g. &amp;quot;org.apache.hadoop.hive.ql.io.orc.OrcOutputFormat&amp;quot;). The maximum length is 128 characters.
    /// </summary>
    public TerraformValue<string>? OutputFormat
    {
        get => new TerraformReference<string>(this, "output_format");
        set => SetArgument("output_format", value);
    }

    /// <summary>
    /// SerdeInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SerdeInfo block(s) allowed")]
    public TerraformList<GoogleBigqueryTableExternalCatalogTableOptionsBlockStorageDescriptorBlockSerdeInfoBlock>? SerdeInfo
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalCatalogTableOptionsBlockStorageDescriptorBlockSerdeInfoBlock>>("serde_info");
        set => SetArgument("serde_info", value);
    }

}

/// <summary>
/// Block type for serde_info in GoogleBigqueryTableExternalCatalogTableOptionsBlockStorageDescriptorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalCatalogTableOptionsBlockStorageDescriptorBlockSerdeInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "serde_info";

    /// <summary>
    /// Name of the SerDe. The maximum length is 256 characters.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Key-value pairs that define the initialization parameters for the serialization library. Maximum size 10 Kib.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Specifies a fully-qualified class name of the serialization library that is responsible for the translation of data between table representation and the underlying low-level input and output format structures. The maximum length is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SerializationLibrary is required")]
    public required TerraformValue<string> SerializationLibrary
    {
        get => new TerraformReference<string>(this, "serialization_library");
        set => SetArgument("serialization_library", value);
    }

}


/// <summary>
/// Block type for external_data_configuration in GoogleBigqueryTable.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalDataConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_data_configuration";

    /// <summary>
    /// Let BigQuery try to autodetect the schema and format of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Autodetect is required")]
    public required TerraformValue<bool> Autodetect
    {
        get => new TerraformReference<bool>(this, "autodetect");
        set => SetArgument("autodetect", value);
    }

    /// <summary>
    /// The compression type of the data source. Valid values are &amp;quot;NONE&amp;quot; or &amp;quot;GZIP&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Compression
    {
        get => new TerraformReference<string>(this, "compression");
        set => SetArgument("compression", value);
    }

    /// <summary>
    /// The connection specifying the credentials to be used to read external storage, such as Azure Blob, Cloud Storage, or S3. The connectionId can have the form &amp;quot;&amp;lt;project&amp;gt;.&amp;lt;location&amp;gt;.&amp;lt;connection_id&amp;gt;&amp;quot; or &amp;quot;projects/&amp;lt;project&amp;gt;/locations/&amp;lt;location&amp;gt;/connections/&amp;lt;connection_id&amp;gt;&amp;quot;.
    /// </summary>
    public TerraformValue<string>? ConnectionId
    {
        get => new TerraformReference<string>(this, "connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// Specifies how source URIs are interpreted for constructing the file set to load.  By default source URIs are expanded against the underlying storage.  Other options include specifying manifest files. Only applicable to object storage systems.
    /// </summary>
    public TerraformValue<string>? FileSetSpecType
    {
        get => new TerraformReference<string>(this, "file_set_spec_type");
        set => SetArgument("file_set_spec_type", value);
    }

    /// <summary>
    /// Indicates if BigQuery should allow extra values that are not represented in the table schema. If true, the extra values are ignored. If false, records with extra columns are treated as bad records, and if there are too many bad records, an invalid error is returned in the job result. The default value is false.
    /// </summary>
    public TerraformValue<bool>? IgnoreUnknownValues
    {
        get => new TerraformReference<bool>(this, "ignore_unknown_values");
        set => SetArgument("ignore_unknown_values", value);
    }

    /// <summary>
    /// Load option to be used together with sourceFormat newline-delimited JSON to indicate that a variant of JSON is being loaded. To load newline-delimited GeoJSON, specify GEOJSON (and sourceFormat must be set to NEWLINE_DELIMITED_JSON).
    /// </summary>
    public TerraformValue<string>? JsonExtension
    {
        get => new TerraformReference<string>(this, "json_extension");
        set => SetArgument("json_extension", value);
    }

    /// <summary>
    /// The maximum number of bad records that BigQuery can ignore when reading data.
    /// </summary>
    public TerraformValue<double>? MaxBadRecords
    {
        get => new TerraformReference<double>(this, "max_bad_records");
        set => SetArgument("max_bad_records", value);
    }

    /// <summary>
    /// Metadata Cache Mode for the table. Set this to enable caching of metadata from external data source.
    /// </summary>
    public TerraformValue<string>? MetadataCacheMode
    {
        get => new TerraformReference<string>(this, "metadata_cache_mode");
        set => SetArgument("metadata_cache_mode", value);
    }

    /// <summary>
    /// Object Metadata is used to create Object Tables. Object Tables contain a listing of objects (with their metadata) found at the sourceUris. If ObjectMetadata is set, sourceFormat should be omitted.
    /// </summary>
    public TerraformValue<string>? ObjectMetadata
    {
        get => new TerraformReference<string>(this, "object_metadata");
        set => SetArgument("object_metadata", value);
    }

    /// <summary>
    /// When creating an external table, the user can provide a reference file with the table schema. This is enabled for the following formats: AVRO, PARQUET, ORC.
    /// </summary>
    public TerraformValue<string>? ReferenceFileSchemaUri
    {
        get => new TerraformReference<string>(this, "reference_file_schema_uri");
        set => SetArgument("reference_file_schema_uri", value);
    }

    /// <summary>
    /// A JSON schema for the external table. Schema is required for CSV and JSON formats and is disallowed for Google Cloud Bigtable, Cloud Datastore backups, and Avro formats when using external tables.
    /// </summary>
    public TerraformValue<string> Schema
    {
        get => new TerraformReference<string>(this, "schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// Please see sourceFormat under ExternalDataConfiguration in Bigquery&#39;s public API documentation (https://cloud.google.com/bigquery/docs/reference/rest/v2/tables#externaldataconfiguration) for supported formats. To use &amp;quot;GOOGLE_SHEETS&amp;quot; the scopes must include &amp;quot;googleapis.com/auth/drive.readonly&amp;quot;.
    /// </summary>
    public TerraformValue<string>? SourceFormat
    {
        get => new TerraformReference<string>(this, "source_format");
        set => SetArgument("source_format", value);
    }

    /// <summary>
    /// A list of the fully-qualified URIs that point to your data in Google Cloud.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUris is required")]
    public TerraformList<string>? SourceUris
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "source_uris").ResolveNodes(ctx));
        set => SetArgument("source_uris", value);
    }

    /// <summary>
    /// AvroOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvroOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockAvroOptionsBlock>? AvroOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockAvroOptionsBlock>>("avro_options");
        set => SetArgument("avro_options", value);
    }

    /// <summary>
    /// BigtableOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigtableOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockBigtableOptionsBlock>? BigtableOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockBigtableOptionsBlock>>("bigtable_options");
        set => SetArgument("bigtable_options", value);
    }

    /// <summary>
    /// CsvOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockCsvOptionsBlock>? CsvOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockCsvOptionsBlock>>("csv_options");
        set => SetArgument("csv_options", value);
    }

    /// <summary>
    /// GoogleSheetsOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleSheetsOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockGoogleSheetsOptionsBlock>? GoogleSheetsOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockGoogleSheetsOptionsBlock>>("google_sheets_options");
        set => SetArgument("google_sheets_options", value);
    }

    /// <summary>
    /// HivePartitioningOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HivePartitioningOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockHivePartitioningOptionsBlock>? HivePartitioningOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockHivePartitioningOptionsBlock>>("hive_partitioning_options");
        set => SetArgument("hive_partitioning_options", value);
    }

    /// <summary>
    /// JsonOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockJsonOptionsBlock>? JsonOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockJsonOptionsBlock>>("json_options");
        set => SetArgument("json_options", value);
    }

    /// <summary>
    /// ParquetOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParquetOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockParquetOptionsBlock>? ParquetOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockParquetOptionsBlock>>("parquet_options");
        set => SetArgument("parquet_options", value);
    }

}

/// <summary>
/// Block type for avro_options in GoogleBigqueryTableExternalDataConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalDataConfigurationBlockAvroOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "avro_options";

    /// <summary>
    /// If sourceFormat is set to &amp;quot;AVRO&amp;quot;, indicates whether to interpret logical types as the corresponding BigQuery data type (for example, TIMESTAMP), instead of using the raw type (for example, INTEGER).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UseAvroLogicalTypes is required")]
    public required TerraformValue<bool> UseAvroLogicalTypes
    {
        get => new TerraformReference<bool>(this, "use_avro_logical_types");
        set => SetArgument("use_avro_logical_types", value);
    }

}

/// <summary>
/// Block type for bigtable_options in GoogleBigqueryTableExternalDataConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalDataConfigurationBlockBigtableOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigtable_options";

    /// <summary>
    /// If field is true, then the column families that are not specified in columnFamilies list are not exposed in the table schema. Otherwise, they are read with BYTES type values. The default value is false.
    /// </summary>
    public TerraformValue<bool>? IgnoreUnspecifiedColumnFamilies
    {
        get => new TerraformReference<bool>(this, "ignore_unspecified_column_families");
        set => SetArgument("ignore_unspecified_column_families", value);
    }

    /// <summary>
    /// If field is true, then each column family will be read as a single JSON column. Otherwise they are read as a repeated cell structure containing timestamp/value tuples. The default value is false.
    /// </summary>
    public TerraformValue<bool>? OutputColumnFamiliesAsJson
    {
        get => new TerraformReference<bool>(this, "output_column_families_as_json");
        set => SetArgument("output_column_families_as_json", value);
    }

    /// <summary>
    /// If field is true, then the rowkey column families will be read and converted to string. Otherwise they are read with BYTES type values and users need to manually cast them with CAST if necessary. The default value is false.
    /// </summary>
    public TerraformValue<bool>? ReadRowkeyAsString
    {
        get => new TerraformReference<bool>(this, "read_rowkey_as_string");
        set => SetArgument("read_rowkey_as_string", value);
    }

    /// <summary>
    /// ColumnFamily block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockBigtableOptionsBlockColumnFamilyBlock>? ColumnFamily
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockBigtableOptionsBlockColumnFamilyBlock>>("column_family");
        set => SetArgument("column_family", value);
    }

}

/// <summary>
/// Block type for column_family in GoogleBigqueryTableExternalDataConfigurationBlockBigtableOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalDataConfigurationBlockBigtableOptionsBlockColumnFamilyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "column_family";

    /// <summary>
    /// The encoding of the values when the type is not STRING. Acceptable encoding values are: TEXT - indicates values are alphanumeric text strings. BINARY - indicates values are encoded using HBase Bytes.toBytes family of functions. This can be overridden for a specific column by listing that column in &#39;columns&#39; and specifying an encoding for it.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// Identifier of the column family.
    /// </summary>
    public TerraformValue<string>? FamilyId
    {
        get => new TerraformReference<string>(this, "family_id");
        set => SetArgument("family_id", value);
    }

    /// <summary>
    /// If this is set only the latest version of value are exposed for all columns in this column family. This can be overridden for a specific column by listing that column in &#39;columns&#39; and specifying a different setting for that column.
    /// </summary>
    public TerraformValue<bool>? OnlyReadLatest
    {
        get => new TerraformReference<bool>(this, "only_read_latest");
        set => SetArgument("only_read_latest", value);
    }

    /// <summary>
    /// The type to convert the value in cells of this column family. The values are expected to be encoded using HBase Bytes.toBytes function when using the BINARY encoding value. Following BigQuery types are allowed (case-sensitive): &amp;quot;BYTES&amp;quot;, &amp;quot;STRING&amp;quot;, &amp;quot;INTEGER&amp;quot;, &amp;quot;FLOAT&amp;quot;, &amp;quot;BOOLEAN&amp;quot;, &amp;quot;JSON&amp;quot;. Default type is BYTES. This can be overridden for a specific column by listing that column in &#39;columns&#39; and specifying a type for it.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Column block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockBigtableOptionsBlockColumnFamilyBlockColumnBlock>? Column
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalDataConfigurationBlockBigtableOptionsBlockColumnFamilyBlockColumnBlock>>("column");
        set => SetArgument("column", value);
    }

}

/// <summary>
/// Block type for column in GoogleBigqueryTableExternalDataConfigurationBlockBigtableOptionsBlockColumnFamilyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalDataConfigurationBlockBigtableOptionsBlockColumnFamilyBlockColumnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "column";

    /// <summary>
    /// The encoding of the values when the type is not STRING. Acceptable encoding values are: TEXT - indicates values are alphanumeric text strings. BINARY - indicates values are encoded using HBase Bytes.toBytes family of functions. &#39;encoding&#39; can also be set at the column family level. However, the setting at this level takes precedence if &#39;encoding&#39; is set at both levels.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// If the qualifier is not a valid BigQuery field identifier i.e. does not match [a-zA-Z][a-zA-Z0-9_]*, a valid identifier must be provided as the column field name and is used as field name in queries.
    /// </summary>
    public TerraformValue<string>? FieldName
    {
        get => new TerraformReference<string>(this, "field_name");
        set => SetArgument("field_name", value);
    }

    /// <summary>
    /// If this is set, only the latest version of value in this column are exposed. &#39;onlyReadLatest&#39; can also be set at the column family level. However, the setting at this level takes precedence if &#39;onlyReadLatest&#39; is set at both levels.
    /// </summary>
    public TerraformValue<bool>? OnlyReadLatest
    {
        get => new TerraformReference<bool>(this, "only_read_latest");
        set => SetArgument("only_read_latest", value);
    }

    /// <summary>
    /// Qualifier of the column. Columns in the parent column family that has this exact qualifier are exposed as . field. If the qualifier is valid UTF-8 string, it can be specified in the qualifierString field. Otherwise, a base-64 encoded value must be set to qualifierEncoded. The column field name is the same as the column qualifier. However, if the qualifier is not a valid BigQuery field identifier i.e. does not match [a-zA-Z][a-zA-Z0-9_]*, a valid identifier must be provided as fieldName.
    /// </summary>
    public TerraformValue<string>? QualifierEncoded
    {
        get => new TerraformReference<string>(this, "qualifier_encoded");
        set => SetArgument("qualifier_encoded", value);
    }

    /// <summary>
    /// Qualifier string.
    /// </summary>
    public TerraformValue<string>? QualifierString
    {
        get => new TerraformReference<string>(this, "qualifier_string");
        set => SetArgument("qualifier_string", value);
    }

    /// <summary>
    /// The type to convert the value in cells of this column. The values are expected to be encoded using HBase Bytes.toBytes function when using the BINARY encoding value. Following BigQuery types are allowed (case-sensitive): &amp;quot;BYTES&amp;quot;, &amp;quot;STRING&amp;quot;, &amp;quot;INTEGER&amp;quot;, &amp;quot;FLOAT&amp;quot;, &amp;quot;BOOLEAN&amp;quot;, &amp;quot;JSON&amp;quot;, Default type is &amp;quot;BYTES&amp;quot;. &#39;type&#39; can also be set at the column family level. However, the setting at this level takes precedence if &#39;type&#39; is set at both levels.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for csv_options in GoogleBigqueryTableExternalDataConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalDataConfigurationBlockCsvOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csv_options";

    /// <summary>
    /// Indicates if BigQuery should accept rows that are missing trailing optional columns.
    /// </summary>
    public TerraformValue<bool>? AllowJaggedRows
    {
        get => new TerraformReference<bool>(this, "allow_jagged_rows");
        set => SetArgument("allow_jagged_rows", value);
    }

    /// <summary>
    /// Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file. The default value is false.
    /// </summary>
    public TerraformValue<bool>? AllowQuotedNewlines
    {
        get => new TerraformReference<bool>(this, "allow_quoted_newlines");
        set => SetArgument("allow_quoted_newlines", value);
    }

    /// <summary>
    /// The character encoding of the data. The supported values are UTF-8 or ISO-8859-1.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The separator for fields in a CSV file.
    /// </summary>
    public TerraformValue<string>? FieldDelimiter
    {
        get => new TerraformReference<string>(this, "field_delimiter");
        set => SetArgument("field_delimiter", value);
    }

    /// <summary>
    /// The value that is used to quote data sections in a CSV file. If your data does not contain quoted sections, set the property value to an empty string. If your data contains quoted newline characters, you must also set the allow_quoted_newlines property to true. The API-side default is &amp;quot;, specified in Terraform escaped as \&amp;quot;. Due to limitations with Terraform default values, this value is required to be explicitly set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Quote is required")]
    public required TerraformValue<string> Quote
    {
        get => new TerraformReference<string>(this, "quote");
        set => SetArgument("quote", value);
    }

    /// <summary>
    /// The number of rows at the top of a CSV file that BigQuery will skip when reading the data.
    /// </summary>
    public TerraformValue<double>? SkipLeadingRows
    {
        get => new TerraformReference<double>(this, "skip_leading_rows");
        set => SetArgument("skip_leading_rows", value);
    }

}

/// <summary>
/// Block type for google_sheets_options in GoogleBigqueryTableExternalDataConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalDataConfigurationBlockGoogleSheetsOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google_sheets_options";

    /// <summary>
    /// Range of a sheet to query from. Only used when non-empty. At least one of range or skip_leading_rows must be set. Typical format: &amp;quot;sheet_name!top_left_cell_id:bottom_right_cell_id&amp;quot; For example: &amp;quot;sheet1!A1:B20
    /// </summary>
    public TerraformValue<string>? Range
    {
        get => new TerraformReference<string>(this, "range");
        set => SetArgument("range", value);
    }

    /// <summary>
    /// The number of rows at the top of the sheet that BigQuery will skip when reading the data. At least one of range or skip_leading_rows must be set.
    /// </summary>
    public TerraformValue<double>? SkipLeadingRows
    {
        get => new TerraformReference<double>(this, "skip_leading_rows");
        set => SetArgument("skip_leading_rows", value);
    }

}

/// <summary>
/// Block type for hive_partitioning_options in GoogleBigqueryTableExternalDataConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalDataConfigurationBlockHivePartitioningOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hive_partitioning_options";

    /// <summary>
    /// When set, what mode of hive partitioning to use when reading data.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    public TerraformValue<bool>? RequirePartitionFilter
    {
        get => new TerraformReference<bool>(this, "require_partition_filter");
        set => SetArgument("require_partition_filter", value);
    }

    /// <summary>
    /// When hive partition detection is requested, a common for all source uris must be required. The prefix must end immediately before the partition key encoding begins.
    /// </summary>
    public TerraformValue<string>? SourceUriPrefix
    {
        get => new TerraformReference<string>(this, "source_uri_prefix");
        set => SetArgument("source_uri_prefix", value);
    }

}

/// <summary>
/// Block type for json_options in GoogleBigqueryTableExternalDataConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalDataConfigurationBlockJsonOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json_options";

    /// <summary>
    /// The character encoding of the data. The supported values are UTF-8, UTF-16BE, UTF-16LE, UTF-32BE, and UTF-32LE. The default value is UTF-8.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

}

/// <summary>
/// Block type for parquet_options in GoogleBigqueryTableExternalDataConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableExternalDataConfigurationBlockParquetOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parquet_options";

    /// <summary>
    /// Indicates whether to use schema inference specifically for Parquet LIST logical type.
    /// </summary>
    public TerraformValue<bool>? EnableListInference
    {
        get => new TerraformReference<bool>(this, "enable_list_inference");
        set => SetArgument("enable_list_inference", value);
    }

    /// <summary>
    /// Indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.
    /// </summary>
    public TerraformValue<bool>? EnumAsString
    {
        get => new TerraformReference<bool>(this, "enum_as_string");
        set => SetArgument("enum_as_string", value);
    }

}


/// <summary>
/// Block type for materialized_view in GoogleBigqueryTable.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableMaterializedViewBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "materialized_view";

    /// <summary>
    /// Allow non incremental materialized view definition. The default value is false.
    /// </summary>
    public TerraformValue<bool>? AllowNonIncrementalDefinition
    {
        get => new TerraformReference<bool>(this, "allow_non_incremental_definition");
        set => SetArgument("allow_non_incremental_definition", value);
    }

    /// <summary>
    /// Specifies if BigQuery should automatically refresh materialized view when the base table is updated. The default is true.
    /// </summary>
    public TerraformValue<bool>? EnableRefresh
    {
        get => new TerraformReference<bool>(this, "enable_refresh");
        set => SetArgument("enable_refresh", value);
    }

    /// <summary>
    /// A query whose result is persisted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => new TerraformReference<string>(this, "query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// Specifies maximum frequency at which this materialized view will be refreshed. The default is 1800000.
    /// </summary>
    public TerraformValue<double>? RefreshIntervalMs
    {
        get => new TerraformReference<double>(this, "refresh_interval_ms");
        set => SetArgument("refresh_interval_ms", value);
    }

}


/// <summary>
/// Block type for range_partitioning in GoogleBigqueryTable.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableRangePartitioningBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range_partitioning";

    /// <summary>
    /// The field used to determine how to create a range-based partition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    public required TerraformValue<string> Field
    {
        get => new TerraformReference<string>(this, "field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// Range block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Range is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Range block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Range block(s) allowed")]
    public required TerraformList<GoogleBigqueryTableRangePartitioningBlockRangeBlock> Range
    {
        get => GetRequiredArgument<TerraformList<GoogleBigqueryTableRangePartitioningBlockRangeBlock>>("range");
        set => SetArgument("range", value);
    }

}

/// <summary>
/// Block type for range in GoogleBigqueryTableRangePartitioningBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableRangePartitioningBlockRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range";

    /// <summary>
    /// End of the range partitioning, exclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    public required TerraformValue<double> End
    {
        get => new TerraformReference<double>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The width of each range within the partition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// Start of the range partitioning, inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<double> Start
    {
        get => new TerraformReference<double>(this, "start");
        set => SetArgument("start", value);
    }

}


/// <summary>
/// Block type for schema_foreign_type_info in GoogleBigqueryTable.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableSchemaForeignTypeInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_foreign_type_info";

    /// <summary>
    /// Specifies the system which defines the foreign data type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeSystem is required")]
    public required TerraformValue<string> TypeSystem
    {
        get => new TerraformReference<string>(this, "type_system");
        set => SetArgument("type_system", value);
    }

}


/// <summary>
/// Block type for table_constraints in GoogleBigqueryTable.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTableConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table_constraints";

    /// <summary>
    /// ForeignKeys block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBigqueryTableTableConstraintsBlockForeignKeysBlock>? ForeignKeys
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableTableConstraintsBlockForeignKeysBlock>>("foreign_keys");
        set => SetArgument("foreign_keys", value);
    }

    /// <summary>
    /// PrimaryKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryKey block(s) allowed")]
    public TerraformList<GoogleBigqueryTableTableConstraintsBlockPrimaryKeyBlock>? PrimaryKey
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableTableConstraintsBlockPrimaryKeyBlock>>("primary_key");
        set => SetArgument("primary_key", value);
    }

}

/// <summary>
/// Block type for foreign_keys in GoogleBigqueryTableTableConstraintsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTableConstraintsBlockForeignKeysBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "foreign_keys";

    /// <summary>
    /// Set only if the foreign key constraint is named.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// ColumnReferences block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnReferences is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ColumnReferences block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ColumnReferences block(s) allowed")]
    public required TerraformList<GoogleBigqueryTableTableConstraintsBlockForeignKeysBlockColumnReferencesBlock> ColumnReferences
    {
        get => GetRequiredArgument<TerraformList<GoogleBigqueryTableTableConstraintsBlockForeignKeysBlockColumnReferencesBlock>>("column_references");
        set => SetArgument("column_references", value);
    }

    /// <summary>
    /// ReferencedTable block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferencedTable is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReferencedTable block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReferencedTable block(s) allowed")]
    public required TerraformList<GoogleBigqueryTableTableConstraintsBlockForeignKeysBlockReferencedTableBlock> ReferencedTable
    {
        get => GetRequiredArgument<TerraformList<GoogleBigqueryTableTableConstraintsBlockForeignKeysBlockReferencedTableBlock>>("referenced_table");
        set => SetArgument("referenced_table", value);
    }

}

/// <summary>
/// Block type for column_references in GoogleBigqueryTableTableConstraintsBlockForeignKeysBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTableConstraintsBlockForeignKeysBlockColumnReferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "column_references";

    /// <summary>
    /// The column in the primary key that are referenced by the referencingColumn.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferencedColumn is required")]
    public required TerraformValue<string> ReferencedColumn
    {
        get => new TerraformReference<string>(this, "referenced_column");
        set => SetArgument("referenced_column", value);
    }

    /// <summary>
    /// The column that composes the foreign key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferencingColumn is required")]
    public required TerraformValue<string> ReferencingColumn
    {
        get => new TerraformReference<string>(this, "referencing_column");
        set => SetArgument("referencing_column", value);
    }

}

/// <summary>
/// Block type for referenced_table in GoogleBigqueryTableTableConstraintsBlockForeignKeysBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTableConstraintsBlockForeignKeysBlockReferencedTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "referenced_table";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => new TerraformReference<string>(this, "dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => new TerraformReference<string>(this, "project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 1,024 characters. Certain operations allow suffixing of the table ID with a partition decorator, such as sample_table$20190123.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => new TerraformReference<string>(this, "table_id");
        set => SetArgument("table_id", value);
    }

}

/// <summary>
/// Block type for primary_key in GoogleBigqueryTableTableConstraintsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTableConstraintsBlockPrimaryKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primary_key";

    /// <summary>
    /// The columns that are composed of the primary key constraint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Columns is required")]
    public TerraformList<string>? Columns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "columns").ResolveNodes(ctx));
        set => SetArgument("columns", value);
    }

}


/// <summary>
/// Block type for table_replication_info in GoogleBigqueryTable.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTableReplicationInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table_replication_info";

    /// <summary>
    /// The interval at which the source materialized view is polled for updates. The default is 300000.
    /// </summary>
    public TerraformValue<double>? ReplicationIntervalMs
    {
        get => new TerraformReference<double>(this, "replication_interval_ms");
        set => SetArgument("replication_interval_ms", value);
    }

    /// <summary>
    /// The ID of the source dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDatasetId is required")]
    public required TerraformValue<string> SourceDatasetId
    {
        get => new TerraformReference<string>(this, "source_dataset_id");
        set => SetArgument("source_dataset_id", value);
    }

    /// <summary>
    /// The ID of the source project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceProjectId is required")]
    public required TerraformValue<string> SourceProjectId
    {
        get => new TerraformReference<string>(this, "source_project_id");
        set => SetArgument("source_project_id", value);
    }

    /// <summary>
    /// The ID of the source materialized view.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceTableId is required")]
    public required TerraformValue<string> SourceTableId
    {
        get => new TerraformReference<string>(this, "source_table_id");
        set => SetArgument("source_table_id", value);
    }

}


/// <summary>
/// Block type for time_partitioning in GoogleBigqueryTable.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableTimePartitioningBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_partitioning";

    /// <summary>
    /// Number of milliseconds for which to keep the storage for a partition.
    /// </summary>
    public TerraformValue<double> ExpirationMs
    {
        get => new TerraformReference<double>(this, "expiration_ms");
        set => SetArgument("expiration_ms", value);
    }

    /// <summary>
    /// The field used to determine how to create a time-based partition. If time-based partitioning is enabled without this value, the table is partitioned based on the load time.
    /// </summary>
    public TerraformValue<string>? Field
    {
        get => new TerraformReference<string>(this, "field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? RequirePartitionFilter
    {
        get => new TerraformReference<bool>(this, "require_partition_filter");
        set => SetArgument("require_partition_filter", value);
    }

    /// <summary>
    /// The supported types are DAY, HOUR, MONTH, and YEAR, which will generate one partition per day, hour, month, and year, respectively.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for view in GoogleBigqueryTable.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryTableViewBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "view";

    /// <summary>
    /// A query that BigQuery executes when the view is referenced.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => new TerraformReference<string>(this, "query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// Specifies whether to use BigQuery&#39;s legacy SQL for this view. If set to false, the view will use BigQuery&#39;s standard SQL
    /// </summary>
    public TerraformValue<bool> UseLegacySql
    {
        get => new TerraformReference<bool>(this, "use_legacy_sql");
        set => SetArgument("use_legacy_sql", value);
    }

}


/// <summary>
/// Represents a google_bigquery_table Terraform resource.
/// Manages a google_bigquery_table resource.
/// </summary>
public partial class GoogleBigqueryTable(string name) : TerraformResource("google_bigquery_table", name)
{
    /// <summary>
    /// Specifies column names to use for data clustering. Up to four top-level columns are allowed, and should be specified in descending priority order.
    /// </summary>
    public TerraformList<string>? Clustering
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "clustering").ResolveNodes(ctx));
        set => SetArgument("clustering", value);
    }

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
    /// Whether Terraform will be prevented from destroying the instance. When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the table will fail. When the field is set to false, deleting the table is allowed.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The field description.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.
    /// </summary>
    public TerraformValue<double> ExpirationTime
    {
        get => new TerraformReference<double>(this, "expiration_time");
        set => SetArgument("expiration_time", value);
    }

    /// <summary>
    /// A descriptive name for the table.
    /// </summary>
    public TerraformValue<string>? FriendlyName
    {
        get => new TerraformReference<string>(this, "friendly_name");
        set => SetArgument("friendly_name", value);
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
    /// Whether Terraform will prevent implicitly added columns in schema from showing diff.
    /// </summary>
    public TerraformValue<bool>? IgnoreAutoGeneratedSchema
    {
        get => new TerraformReference<bool>(this, "ignore_auto_generated_schema");
        set => SetArgument("ignore_auto_generated_schema", value);
    }

    /// <summary>
    /// Mention which fields in schema are to be ignored
    /// </summary>
    public TerraformList<string>? IgnoreSchemaChanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ignore_schema_changes").ResolveNodes(ctx));
        set => SetArgument("ignore_schema_changes", value);
    }

    /// <summary>
    /// A mapping of labels to assign to the resource.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of [SQL IntervalValue type](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-types#interval_type).
    /// </summary>
    public TerraformValue<string> MaxStaleness
    {
        get => new TerraformReference<string>(this, "max_staleness");
        set => SetArgument("max_staleness", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    public TerraformValue<bool>? RequirePartitionFilter
    {
        get => new TerraformReference<bool>(this, "require_partition_filter");
        set => SetArgument("require_partition_filter", value);
    }

    /// <summary>
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example &amp;quot;Production&amp;quot;.
    /// </summary>
    public TerraformMap<string>? ResourceTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_tags").ResolveNodes(ctx));
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// A JSON schema for the table.
    /// </summary>
    public TerraformValue<string> Schema
    {
        get => new TerraformReference<string>(this, "schema");
        set => SetArgument("schema", value);
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
    /// View sets the optional parameter &amp;quot;view&amp;quot;: Specifies the view that determines which table information is returned. By default, basic table information and storage statistics (STORAGE_STATS) are returned. Possible values: TABLE_METADATA_VIEW_UNSPECIFIED, BASIC, STORAGE_STATS, FULL
    /// </summary>
    public TerraformValue<string>? TableMetadataView
    {
        get => new TerraformReference<string>(this, "table_metadata_view");
        set => SetArgument("table_metadata_view", value);
    }

    /// <summary>
    /// The time when this table was created, in milliseconds since the epoch.
    /// </summary>
    public TerraformValue<double> CreationTime
    {
        get => new TerraformReference<double>(this, "creation_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// (Output-only) A list of autogenerated schema fields.
    /// </summary>
    public TerraformValue<string> GeneratedSchemaColumns
    {
        get => new TerraformReference<string>(this, "generated_schema_columns");
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
    /// The URI of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Describes the table type.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// BiglakeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BiglakeConfiguration block(s) allowed")]
    public TerraformList<GoogleBigqueryTableBiglakeConfigurationBlock>? BiglakeConfiguration
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableBiglakeConfigurationBlock>>("biglake_configuration");
        set => SetArgument("biglake_configuration", value);
    }

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public TerraformList<GoogleBigqueryTableEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// ExternalCatalogTableOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalCatalogTableOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryTableExternalCatalogTableOptionsBlock>? ExternalCatalogTableOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalCatalogTableOptionsBlock>>("external_catalog_table_options");
        set => SetArgument("external_catalog_table_options", value);
    }

    /// <summary>
    /// ExternalDataConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalDataConfiguration block(s) allowed")]
    public TerraformList<GoogleBigqueryTableExternalDataConfigurationBlock>? ExternalDataConfiguration
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableExternalDataConfigurationBlock>>("external_data_configuration");
        set => SetArgument("external_data_configuration", value);
    }

    /// <summary>
    /// MaterializedView block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaterializedView block(s) allowed")]
    public TerraformList<GoogleBigqueryTableMaterializedViewBlock>? MaterializedView
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableMaterializedViewBlock>>("materialized_view");
        set => SetArgument("materialized_view", value);
    }

    /// <summary>
    /// RangePartitioning block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RangePartitioning block(s) allowed")]
    public TerraformList<GoogleBigqueryTableRangePartitioningBlock>? RangePartitioning
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableRangePartitioningBlock>>("range_partitioning");
        set => SetArgument("range_partitioning", value);
    }

    /// <summary>
    /// SchemaForeignTypeInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaForeignTypeInfo block(s) allowed")]
    public TerraformList<GoogleBigqueryTableSchemaForeignTypeInfoBlock>? SchemaForeignTypeInfo
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableSchemaForeignTypeInfoBlock>>("schema_foreign_type_info");
        set => SetArgument("schema_foreign_type_info", value);
    }

    /// <summary>
    /// TableConstraints block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableConstraints block(s) allowed")]
    public TerraformList<GoogleBigqueryTableTableConstraintsBlock>? TableConstraints
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableTableConstraintsBlock>>("table_constraints");
        set => SetArgument("table_constraints", value);
    }

    /// <summary>
    /// TableReplicationInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableReplicationInfo block(s) allowed")]
    public TerraformList<GoogleBigqueryTableTableReplicationInfoBlock>? TableReplicationInfo
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableTableReplicationInfoBlock>>("table_replication_info");
        set => SetArgument("table_replication_info", value);
    }

    /// <summary>
    /// TimePartitioning block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePartitioning block(s) allowed")]
    public TerraformList<GoogleBigqueryTableTimePartitioningBlock>? TimePartitioning
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableTimePartitioningBlock>>("time_partitioning");
        set => SetArgument("time_partitioning", value);
    }

    /// <summary>
    /// View block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 View block(s) allowed")]
    public TerraformList<GoogleBigqueryTableViewBlock>? View
    {
        get => GetArgument<TerraformList<GoogleBigqueryTableViewBlock>>("view");
        set => SetArgument("view", value);
    }

}
