using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for copy in GoogleBigqueryJob.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobCopyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "copy";

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &#39;notFound&#39; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion Default value: &amp;quot;CREATE_IF_NEEDED&amp;quot; Possible values: [&amp;quot;CREATE_IF_NEEDED&amp;quot;, &amp;quot;CREATE_NEVER&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CreateDisposition
    {
        get => GetArgument<TerraformValue<string>>("create_disposition");
        set => SetArgument("create_disposition", value);
    }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &#39;duplicate&#39; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion. Default value: &amp;quot;WRITE_EMPTY&amp;quot; Possible values: [&amp;quot;WRITE_TRUNCATE&amp;quot;, &amp;quot;WRITE_APPEND&amp;quot;, &amp;quot;WRITE_EMPTY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? WriteDisposition
    {
        get => GetArgument<TerraformValue<string>>("write_disposition");
        set => SetArgument("write_disposition", value);
    }

    /// <summary>
    /// DestinationEncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationEncryptionConfiguration block(s) allowed")]
    public TerraformList<GoogleBigqueryJobCopyBlockDestinationEncryptionConfigurationBlock>? DestinationEncryptionConfiguration
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobCopyBlockDestinationEncryptionConfigurationBlock>>("destination_encryption_configuration");
        set => SetArgument("destination_encryption_configuration", value);
    }

    /// <summary>
    /// DestinationTable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationTable block(s) allowed")]
    public TerraformList<GoogleBigqueryJobCopyBlockDestinationTableBlock>? DestinationTable
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobCopyBlockDestinationTableBlock>>("destination_table");
        set => SetArgument("destination_table", value);
    }

    /// <summary>
    /// SourceTables block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceTables is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceTables block(s) required")]
    public required TerraformList<GoogleBigqueryJobCopyBlockSourceTablesBlock> SourceTables
    {
        get => GetRequiredArgument<TerraformList<GoogleBigqueryJobCopyBlockSourceTablesBlock>>("source_tables");
        set => SetArgument("source_tables", value);
    }

}

/// <summary>
/// Block type for destination_encryption_configuration in GoogleBigqueryJobCopyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobCopyBlockDestinationEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_encryption_configuration";

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
    /// The BigQuery Service Account associated with your project requires access to this encryption key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Describes the Cloud KMS encryption key version used to protect destination BigQuery table.
    /// </summary>
    public TerraformValue<string> KmsKeyVersion
        => CreateReference("kms_key_version");

}

/// <summary>
/// Block type for destination_table in GoogleBigqueryJobCopyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobCopyBlockDestinationTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_table";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    public TerraformValue<string> DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id") ?? CreateReference("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    public TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id") ?? CreateReference("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The table. Can be specified &#39;{{table_id}}&#39; if &#39;project_id&#39; and &#39;dataset_id&#39; are also set,
    /// or of the form &#39;projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}}&#39; if not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}

/// <summary>
/// Block type for source_tables in GoogleBigqueryJobCopyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobCopyBlockSourceTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_tables";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    public TerraformValue<string> DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id") ?? CreateReference("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    public TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id") ?? CreateReference("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The table. Can be specified &#39;{{table_id}}&#39; if &#39;project_id&#39; and &#39;dataset_id&#39; are also set,
    /// or of the form &#39;projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}}&#39; if not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}


/// <summary>
/// Block type for extract in GoogleBigqueryJob.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobExtractBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extract";

    /// <summary>
    /// The compression type to use for exported files. Possible values include GZIP, DEFLATE, SNAPPY, and NONE.
    /// The default value is NONE. DEFLATE and SNAPPY are only supported for Avro.
    /// </summary>
    public TerraformValue<string>? Compression
    {
        get => GetArgument<TerraformValue<string>>("compression");
        set => SetArgument("compression", value);
    }

    /// <summary>
    /// The exported file format. Possible values include CSV, NEWLINE_DELIMITED_JSON and AVRO for tables and SAVED_MODEL for models.
    /// The default value for tables is CSV. Tables with nested or repeated fields cannot be exported as CSV.
    /// The default value for models is SAVED_MODEL.
    /// </summary>
    public TerraformValue<string> DestinationFormat
    {
        get => GetArgument<TerraformValue<string>>("destination_format") ?? CreateReference("destination_format");
        set => SetArgument("destination_format", value);
    }

    /// <summary>
    /// A list of fully-qualified Google Cloud Storage URIs where the extracted table should be written.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationUris is required")]
    public TerraformList<string>? DestinationUris
    {
        get => GetArgument<TerraformList<string>>("destination_uris");
        set => SetArgument("destination_uris", value);
    }

    /// <summary>
    /// When extracting data in CSV format, this defines the delimiter to use between fields in the exported data.
    /// Default is &#39;,&#39;
    /// </summary>
    public TerraformValue<string> FieldDelimiter
    {
        get => GetArgument<TerraformValue<string>>("field_delimiter") ?? CreateReference("field_delimiter");
        set => SetArgument("field_delimiter", value);
    }

    /// <summary>
    /// Whether to print out a header row in the results. Default is true.
    /// </summary>
    public TerraformValue<bool>? PrintHeader
    {
        get => GetArgument<TerraformValue<bool>>("print_header");
        set => SetArgument("print_header", value);
    }

    /// <summary>
    /// Whether to use logical types when extracting to AVRO format.
    /// </summary>
    public TerraformValue<bool>? UseAvroLogicalTypes
    {
        get => GetArgument<TerraformValue<bool>>("use_avro_logical_types");
        set => SetArgument("use_avro_logical_types", value);
    }

    /// <summary>
    /// SourceModel block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceModel block(s) allowed")]
    public TerraformList<GoogleBigqueryJobExtractBlockSourceModelBlock>? SourceModel
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobExtractBlockSourceModelBlock>>("source_model");
        set => SetArgument("source_model", value);
    }

    /// <summary>
    /// SourceTable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceTable block(s) allowed")]
    public TerraformList<GoogleBigqueryJobExtractBlockSourceTableBlock>? SourceTable
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobExtractBlockSourceTableBlock>>("source_table");
        set => SetArgument("source_table", value);
    }

}

/// <summary>
/// Block type for source_model in GoogleBigqueryJobExtractBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobExtractBlockSourceModelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_model";

    /// <summary>
    /// The ID of the dataset containing this model.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the model.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    public required TerraformValue<string> ModelId
    {
        get => GetRequiredArgument<TerraformValue<string>>("model_id");
        set => SetArgument("model_id", value);
    }

    /// <summary>
    /// The ID of the project containing this model.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

}

/// <summary>
/// Block type for source_table in GoogleBigqueryJobExtractBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobExtractBlockSourceTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_table";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    public TerraformValue<string> DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id") ?? CreateReference("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    public TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id") ?? CreateReference("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The table. Can be specified &#39;{{table_id}}&#39; if &#39;project_id&#39; and &#39;dataset_id&#39; are also set,
    /// or of the form &#39;projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}}&#39; if not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}


/// <summary>
/// Block type for load in GoogleBigqueryJob.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobLoadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load";

    /// <summary>
    /// Accept rows that are missing trailing optional columns. The missing values are treated as nulls.
    /// If false, records with missing trailing columns are treated as bad records, and if there are too many bad records,
    /// an invalid error is returned in the job result. The default value is false. Only applicable to CSV, ignored for other formats.
    /// </summary>
    public TerraformValue<bool>? AllowJaggedRows
    {
        get => GetArgument<TerraformValue<bool>>("allow_jagged_rows");
        set => SetArgument("allow_jagged_rows", value);
    }

    /// <summary>
    /// Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file.
    /// The default value is false.
    /// </summary>
    public TerraformValue<bool>? AllowQuotedNewlines
    {
        get => GetArgument<TerraformValue<bool>>("allow_quoted_newlines");
        set => SetArgument("allow_quoted_newlines", value);
    }

    /// <summary>
    /// Indicates if we should automatically infer the options and schema for CSV and JSON sources.
    /// </summary>
    public TerraformValue<bool>? Autodetect
    {
        get => GetArgument<TerraformValue<bool>>("autodetect");
        set => SetArgument("autodetect", value);
    }

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &#39;notFound&#39; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion Default value: &amp;quot;CREATE_IF_NEEDED&amp;quot; Possible values: [&amp;quot;CREATE_IF_NEEDED&amp;quot;, &amp;quot;CREATE_NEVER&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CreateDisposition
    {
        get => GetArgument<TerraformValue<string>>("create_disposition");
        set => SetArgument("create_disposition", value);
    }

    /// <summary>
    /// The character encoding of the data. The supported values are UTF-8 or ISO-8859-1.
    /// The default value is UTF-8. BigQuery decodes the data after the raw, binary data
    /// has been split using the values of the quote and fieldDelimiter properties.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => GetArgument<TerraformValue<string>>("encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The separator for fields in a CSV file. The separator can be any ISO-8859-1 single-byte character.
    /// To use a character in the range 128-255, you must encode the character as UTF8. BigQuery converts
    /// the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the
    /// data in its raw, binary state. BigQuery also supports the escape sequence &amp;quot;\t&amp;quot; to specify a tab separator.
    /// The default value is a comma (&#39;,&#39;).
    /// </summary>
    public TerraformValue<string> FieldDelimiter
    {
        get => GetArgument<TerraformValue<string>>("field_delimiter") ?? CreateReference("field_delimiter");
        set => SetArgument("field_delimiter", value);
    }

    /// <summary>
    /// Indicates if BigQuery should allow extra values that are not represented in the table schema.
    /// If true, the extra values are ignored. If false, records with extra columns are treated as bad records,
    /// and if there are too many bad records, an invalid error is returned in the job result.
    /// The default value is false. The sourceFormat property determines what BigQuery treats as an extra value:
    /// CSV: Trailing columns
    /// JSON: Named values that don&#39;t match any column names
    /// </summary>
    public TerraformValue<bool>? IgnoreUnknownValues
    {
        get => GetArgument<TerraformValue<bool>>("ignore_unknown_values");
        set => SetArgument("ignore_unknown_values", value);
    }

    /// <summary>
    /// If sourceFormat is set to newline-delimited JSON, indicates whether it should be processed as a JSON variant such as GeoJSON.
    /// For a sourceFormat other than JSON, omit this field. If the sourceFormat is newline-delimited JSON: - for newline-delimited
    /// GeoJSON: set to GEOJSON.
    /// </summary>
    public TerraformValue<string>? JsonExtension
    {
        get => GetArgument<TerraformValue<string>>("json_extension");
        set => SetArgument("json_extension", value);
    }

    /// <summary>
    /// The maximum number of bad records that BigQuery can ignore when running the job. If the number of bad records exceeds this value,
    /// an invalid error is returned in the job result. The default value is 0, which requires that all records are valid.
    /// </summary>
    public TerraformValue<double>? MaxBadRecords
    {
        get => GetArgument<TerraformValue<double>>("max_bad_records");
        set => SetArgument("max_bad_records", value);
    }

    /// <summary>
    /// Specifies a string that represents a null value in a CSV file. For example, if you specify &amp;quot;\N&amp;quot;, BigQuery interprets &amp;quot;\N&amp;quot; as a null value
    /// when loading a CSV file. The default value is the empty string. If you set this property to a custom value, BigQuery throws an error if an
    /// empty string is present for all data types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as
    /// an empty value.
    /// </summary>
    public TerraformValue<string>? NullMarker
    {
        get => GetArgument<TerraformValue<string>>("null_marker");
        set => SetArgument("null_marker", value);
    }

    /// <summary>
    /// If sourceFormat is set to &amp;quot;DATASTORE_BACKUP&amp;quot;, indicates which entity properties to load into BigQuery from a Cloud Datastore backup.
    /// Property names are case sensitive and must be top-level properties. If no properties are specified, BigQuery loads all properties.
    /// If any named property isn&#39;t found in the Cloud Datastore backup, an invalid error is returned in the job result.
    /// </summary>
    public TerraformList<string>? ProjectionFields
    {
        get => GetArgument<TerraformList<string>>("projection_fields");
        set => SetArgument("projection_fields", value);
    }

    /// <summary>
    /// The value that is used to quote data sections in a CSV file. BigQuery converts the string to ISO-8859-1 encoding,
    /// and then uses the first byte of the encoded string to split the data in its raw, binary state.
    /// The default value is a double-quote (&#39;&amp;quot;&#39;). If your data does not contain quoted sections, set the property value to an empty string.
    /// If your data contains quoted newline characters, you must also set the allowQuotedNewlines property to true.
    /// </summary>
    public TerraformValue<string> Quote
    {
        get => GetArgument<TerraformValue<string>>("quote") ?? CreateReference("quote");
        set => SetArgument("quote", value);
    }

    /// <summary>
    /// Allows the schema of the destination table to be updated as a side effect of the load job if a schema is autodetected or
    /// supplied in the job configuration. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND;
    /// when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators.
    /// For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified:
    /// ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema.
    /// ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.
    /// </summary>
    public TerraformList<string>? SchemaUpdateOptions
    {
        get => GetArgument<TerraformList<string>>("schema_update_options");
        set => SetArgument("schema_update_options", value);
    }

    /// <summary>
    /// The number of rows at the top of a CSV file that BigQuery will skip when loading the data.
    /// The default value is 0. This property is useful if you have header rows in the file that should be skipped.
    /// When autodetect is on, the behavior is the following:
    /// skipLeadingRows unspecified - Autodetect tries to detect headers in the first row. If they are not detected,
    /// the row is read as data. Otherwise data is read starting from the second row.
    /// skipLeadingRows is 0 - Instructs autodetect that there are no headers and data should be read starting from the first row.
    /// skipLeadingRows = N &amp;gt; 0 - Autodetect skips N-1 rows and tries to detect headers in row N. If headers are not detected,
    /// row N is just skipped. Otherwise row N is used to extract column names for the detected schema.
    /// </summary>
    public TerraformValue<double>? SkipLeadingRows
    {
        get => GetArgument<TerraformValue<double>>("skip_leading_rows");
        set => SetArgument("skip_leading_rows", value);
    }

    /// <summary>
    /// The format of the data files. For CSV files, specify &amp;quot;CSV&amp;quot;. For datastore backups, specify &amp;quot;DATASTORE_BACKUP&amp;quot;.
    /// For newline-delimited JSON, specify &amp;quot;NEWLINE_DELIMITED_JSON&amp;quot;. For Avro, specify &amp;quot;AVRO&amp;quot;. For parquet, specify &amp;quot;PARQUET&amp;quot;.
    /// For orc, specify &amp;quot;ORC&amp;quot;. [Beta] For Bigtable, specify &amp;quot;BIGTABLE&amp;quot;.
    /// The default value is CSV.
    /// </summary>
    public TerraformValue<string>? SourceFormat
    {
        get => GetArgument<TerraformValue<string>>("source_format");
        set => SetArgument("source_format", value);
    }

    /// <summary>
    /// The fully-qualified URIs that point to your data in Google Cloud.
    /// For Google Cloud Storage URIs: Each URI can contain one &#39;\*&#39; wildcard character
    /// and it must come after the &#39;bucket&#39; name. Size limits related to load jobs apply
    /// to external data sources. For Google Cloud Bigtable URIs: Exactly one URI can be
    /// specified and it has be a fully specified and valid HTTPS URL for a Google Cloud Bigtable table.
    /// For Google Cloud Datastore backups: Exactly one URI can be specified. Also, the &#39;\*&#39; wildcard character is not allowed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUris is required")]
    public TerraformList<string>? SourceUris
    {
        get => GetArgument<TerraformList<string>>("source_uris");
        set => SetArgument("source_uris", value);
    }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &#39;duplicate&#39; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion. Default value: &amp;quot;WRITE_EMPTY&amp;quot; Possible values: [&amp;quot;WRITE_TRUNCATE&amp;quot;, &amp;quot;WRITE_APPEND&amp;quot;, &amp;quot;WRITE_EMPTY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? WriteDisposition
    {
        get => GetArgument<TerraformValue<string>>("write_disposition");
        set => SetArgument("write_disposition", value);
    }

    /// <summary>
    /// DestinationEncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationEncryptionConfiguration block(s) allowed")]
    public TerraformList<GoogleBigqueryJobLoadBlockDestinationEncryptionConfigurationBlock>? DestinationEncryptionConfiguration
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobLoadBlockDestinationEncryptionConfigurationBlock>>("destination_encryption_configuration");
        set => SetArgument("destination_encryption_configuration", value);
    }

    /// <summary>
    /// DestinationTable block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationTable is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationTable block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationTable block(s) allowed")]
    public required TerraformList<GoogleBigqueryJobLoadBlockDestinationTableBlock> DestinationTable
    {
        get => GetRequiredArgument<TerraformList<GoogleBigqueryJobLoadBlockDestinationTableBlock>>("destination_table");
        set => SetArgument("destination_table", value);
    }

    /// <summary>
    /// ParquetOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParquetOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryJobLoadBlockParquetOptionsBlock>? ParquetOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobLoadBlockParquetOptionsBlock>>("parquet_options");
        set => SetArgument("parquet_options", value);
    }

    /// <summary>
    /// TimePartitioning block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePartitioning block(s) allowed")]
    public TerraformList<GoogleBigqueryJobLoadBlockTimePartitioningBlock>? TimePartitioning
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobLoadBlockTimePartitioningBlock>>("time_partitioning");
        set => SetArgument("time_partitioning", value);
    }

}

/// <summary>
/// Block type for destination_encryption_configuration in GoogleBigqueryJobLoadBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobLoadBlockDestinationEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_encryption_configuration";

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
    /// The BigQuery Service Account associated with your project requires access to this encryption key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Describes the Cloud KMS encryption key version used to protect destination BigQuery table.
    /// </summary>
    public TerraformValue<string> KmsKeyVersion
        => CreateReference("kms_key_version");

}

/// <summary>
/// Block type for destination_table in GoogleBigqueryJobLoadBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobLoadBlockDestinationTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_table";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    public TerraformValue<string> DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id") ?? CreateReference("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    public TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id") ?? CreateReference("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The table. Can be specified &#39;{{table_id}}&#39; if &#39;project_id&#39; and &#39;dataset_id&#39; are also set,
    /// or of the form &#39;projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}}&#39; if not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}

/// <summary>
/// Block type for parquet_options in GoogleBigqueryJobLoadBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobLoadBlockParquetOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parquet_options";

    /// <summary>
    /// If sourceFormat is set to PARQUET, indicates whether to use schema inference specifically for Parquet LIST logical type.
    /// </summary>
    public TerraformValue<bool>? EnableListInference
    {
        get => GetArgument<TerraformValue<bool>>("enable_list_inference");
        set => SetArgument("enable_list_inference", value);
    }

    /// <summary>
    /// If sourceFormat is set to PARQUET, indicates whether to infer Parquet ENUM logical type as STRING instead of BYTES by default.
    /// </summary>
    public TerraformValue<bool>? EnumAsString
    {
        get => GetArgument<TerraformValue<bool>>("enum_as_string");
        set => SetArgument("enum_as_string", value);
    }

}

/// <summary>
/// Block type for time_partitioning in GoogleBigqueryJobLoadBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobLoadBlockTimePartitioningBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_partitioning";

    /// <summary>
    /// Number of milliseconds for which to keep the storage for a partition. A wrapper is used here because 0 is an invalid value.
    /// </summary>
    public TerraformValue<string>? ExpirationMs
    {
        get => GetArgument<TerraformValue<string>>("expiration_ms");
        set => SetArgument("expiration_ms", value);
    }

    /// <summary>
    /// If not set, the table is partitioned by pseudo column &#39;_PARTITIONTIME&#39;; if set, the table is partitioned by this field.
    /// The field must be a top-level TIMESTAMP or DATE field. Its mode must be NULLABLE or REQUIRED.
    /// A wrapper is used here because an empty string is an invalid value.
    /// </summary>
    public TerraformValue<string>? Field
    {
        get => GetArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The only type supported is DAY, which will generate one partition per day. Providing an empty string used to cause an error,
    /// but in OnePlatform the field will be treated as unset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for query in GoogleBigqueryJob.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobQueryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query";

    /// <summary>
    /// If true and query uses legacy SQL dialect, allows the query to produce arbitrarily large result tables at a slight cost in performance.
    /// Requires destinationTable to be set. For standard SQL queries, this flag is ignored and large results are always allowed.
    /// However, you must still set destinationTable when result size exceeds the allowed maximum response size.
    /// </summary>
    public TerraformValue<bool>? AllowLargeResults
    {
        get => GetArgument<TerraformValue<bool>>("allow_large_results");
        set => SetArgument("allow_large_results", value);
    }

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &#39;notFound&#39; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion Default value: &amp;quot;CREATE_IF_NEEDED&amp;quot; Possible values: [&amp;quot;CREATE_IF_NEEDED&amp;quot;, &amp;quot;CREATE_NEVER&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CreateDisposition
    {
        get => GetArgument<TerraformValue<string>>("create_disposition");
        set => SetArgument("create_disposition", value);
    }

    /// <summary>
    /// If true and query uses legacy SQL dialect, flattens all nested and repeated fields in the query results.
    /// allowLargeResults must be true if this is set to false. For standard SQL queries, this flag is ignored and results are never flattened.
    /// </summary>
    public TerraformValue<bool>? FlattenResults
    {
        get => GetArgument<TerraformValue<bool>>("flatten_results");
        set => SetArgument("flatten_results", value);
    }

    /// <summary>
    /// Limits the billing tier for this job. Queries that have resource usage beyond this tier will fail (without incurring a charge).
    /// If unspecified, this will be set to your project default.
    /// </summary>
    public TerraformValue<double>? MaximumBillingTier
    {
        get => GetArgument<TerraformValue<double>>("maximum_billing_tier");
        set => SetArgument("maximum_billing_tier", value);
    }

    /// <summary>
    /// Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will fail (without incurring a charge).
    /// If unspecified, this will be set to your project default.
    /// </summary>
    public TerraformValue<string>? MaximumBytesBilled
    {
        get => GetArgument<TerraformValue<string>>("maximum_bytes_billed");
        set => SetArgument("maximum_bytes_billed", value);
    }

    /// <summary>
    /// Standard SQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named (@myparam) query parameters in this query.
    /// </summary>
    public TerraformValue<string>? ParameterMode
    {
        get => GetArgument<TerraformValue<string>>("parameter_mode");
        set => SetArgument("parameter_mode", value);
    }

    /// <summary>
    /// Specifies a priority for the query. Default value: &amp;quot;INTERACTIVE&amp;quot; Possible values: [&amp;quot;INTERACTIVE&amp;quot;, &amp;quot;BATCH&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Priority
    {
        get => GetArgument<TerraformValue<string>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// SQL query text to execute. The useLegacySql field can be used to indicate whether the query uses legacy SQL or standard SQL.
    /// *NOTE*: queries containing [DML language](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-manipulation-language)
    /// (&#39;DELETE&#39;, &#39;UPDATE&#39;, &#39;MERGE&#39;, &#39;INSERT&#39;) must specify &#39;create_disposition = &amp;quot;&amp;quot;&#39; and &#39;write_disposition = &amp;quot;&amp;quot;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => GetRequiredArgument<TerraformValue<string>>("query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// Allows the schema of the destination table to be updated as a side effect of the query job.
    /// Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND;
    /// when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table,
    /// specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema.
    /// One or more of the following values are specified:
    /// ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema.
    /// ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.
    /// </summary>
    public TerraformList<string>? SchemaUpdateOptions
    {
        get => GetArgument<TerraformList<string>>("schema_update_options");
        set => SetArgument("schema_update_options", value);
    }

    /// <summary>
    /// Specifies whether to use BigQuery&#39;s legacy SQL dialect for this query. The default value is true.
    /// If set to false, the query will use BigQuery&#39;s standard SQL.
    /// </summary>
    public TerraformValue<bool>? UseLegacySql
    {
        get => GetArgument<TerraformValue<bool>>("use_legacy_sql");
        set => SetArgument("use_legacy_sql", value);
    }

    /// <summary>
    /// Whether to look for the result in the query cache. The query cache is a best-effort cache that will be flushed whenever
    /// tables in the query are modified. Moreover, the query cache is only available when a query does not have a destination table specified.
    /// The default value is true.
    /// </summary>
    public TerraformValue<bool>? UseQueryCache
    {
        get => GetArgument<TerraformValue<bool>>("use_query_cache");
        set => SetArgument("use_query_cache", value);
    }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &#39;duplicate&#39; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion. Default value: &amp;quot;WRITE_EMPTY&amp;quot; Possible values: [&amp;quot;WRITE_TRUNCATE&amp;quot;, &amp;quot;WRITE_APPEND&amp;quot;, &amp;quot;WRITE_EMPTY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? WriteDisposition
    {
        get => GetArgument<TerraformValue<string>>("write_disposition");
        set => SetArgument("write_disposition", value);
    }

    /// <summary>
    /// ConnectionProperties block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBigqueryJobQueryBlockConnectionPropertiesBlock>? ConnectionProperties
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobQueryBlockConnectionPropertiesBlock>>("connection_properties");
        set => SetArgument("connection_properties", value);
    }

    /// <summary>
    /// DefaultDataset block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultDataset block(s) allowed")]
    public TerraformList<GoogleBigqueryJobQueryBlockDefaultDatasetBlock>? DefaultDataset
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobQueryBlockDefaultDatasetBlock>>("default_dataset");
        set => SetArgument("default_dataset", value);
    }

    /// <summary>
    /// DestinationEncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationEncryptionConfiguration block(s) allowed")]
    public TerraformList<GoogleBigqueryJobQueryBlockDestinationEncryptionConfigurationBlock>? DestinationEncryptionConfiguration
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobQueryBlockDestinationEncryptionConfigurationBlock>>("destination_encryption_configuration");
        set => SetArgument("destination_encryption_configuration", value);
    }

    /// <summary>
    /// DestinationTable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationTable block(s) allowed")]
    public TerraformList<GoogleBigqueryJobQueryBlockDestinationTableBlock>? DestinationTable
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobQueryBlockDestinationTableBlock>>("destination_table");
        set => SetArgument("destination_table", value);
    }

    /// <summary>
    /// ScriptOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScriptOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryJobQueryBlockScriptOptionsBlock>? ScriptOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobQueryBlockScriptOptionsBlock>>("script_options");
        set => SetArgument("script_options", value);
    }

    /// <summary>
    /// UserDefinedFunctionResources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBigqueryJobQueryBlockUserDefinedFunctionResourcesBlock>? UserDefinedFunctionResources
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobQueryBlockUserDefinedFunctionResourcesBlock>>("user_defined_function_resources");
        set => SetArgument("user_defined_function_resources", value);
    }

}

/// <summary>
/// Block type for connection_properties in GoogleBigqueryJobQueryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobQueryBlockConnectionPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_properties";

    /// <summary>
    /// The key of the property to set. Currently supported connection properties:
    /// * &#39;dataset_project_id&#39;: represents the default project for datasets that are used in the query
    /// * &#39;time_zone&#39;: represents the default timezone used to run the query
    /// * &#39;session_id&#39;: associates the query with a given session
    /// * &#39;query_label&#39;: associates the query with a given job label
    /// * &#39;service_account&#39;: indicates the service account to use to run a continuous query
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value of the property to set.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for default_dataset in GoogleBigqueryJobQueryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobQueryBlockDefaultDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_dataset";

    /// <summary>
    /// The dataset. Can be specified &#39;{{dataset_id}}&#39; if &#39;project_id&#39; is also set,
    /// or of the form &#39;projects/{{project}}/datasets/{{dataset_id}}&#39; if not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    public TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id") ?? CreateReference("project_id");
        set => SetArgument("project_id", value);
    }

}

/// <summary>
/// Block type for destination_encryption_configuration in GoogleBigqueryJobQueryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobQueryBlockDestinationEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_encryption_configuration";

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination BigQuery table.
    /// The BigQuery Service Account associated with your project requires access to this encryption key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Describes the Cloud KMS encryption key version used to protect destination BigQuery table.
    /// </summary>
    public TerraformValue<string> KmsKeyVersion
        => CreateReference("kms_key_version");

}

/// <summary>
/// Block type for destination_table in GoogleBigqueryJobQueryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobQueryBlockDestinationTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_table";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    public TerraformValue<string> DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id") ?? CreateReference("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    public TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id") ?? CreateReference("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The table. Can be specified &#39;{{table_id}}&#39; if &#39;project_id&#39; and &#39;dataset_id&#39; are also set,
    /// or of the form &#39;projects/{{project}}/datasets/{{dataset_id}}/tables/{{table_id}}&#39; if not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}

/// <summary>
/// Block type for script_options in GoogleBigqueryJobQueryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobQueryBlockScriptOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "script_options";

    /// <summary>
    /// Determines which statement in the script represents the &amp;quot;key result&amp;quot;,
    /// used to populate the schema and query results of the script job. Possible values: [&amp;quot;LAST&amp;quot;, &amp;quot;FIRST_SELECT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? KeyResultStatement
    {
        get => GetArgument<TerraformValue<string>>("key_result_statement");
        set => SetArgument("key_result_statement", value);
    }

    /// <summary>
    /// Limit on the number of bytes billed per statement. Exceeding this budget results in an error.
    /// </summary>
    public TerraformValue<string>? StatementByteBudget
    {
        get => GetArgument<TerraformValue<string>>("statement_byte_budget");
        set => SetArgument("statement_byte_budget", value);
    }

    /// <summary>
    /// Timeout period for each statement in a script.
    /// </summary>
    public TerraformValue<string>? StatementTimeoutMs
    {
        get => GetArgument<TerraformValue<string>>("statement_timeout_ms");
        set => SetArgument("statement_timeout_ms", value);
    }

}

/// <summary>
/// Block type for user_defined_function_resources in GoogleBigqueryJobQueryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobQueryBlockUserDefinedFunctionResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_defined_function_resources";

    /// <summary>
    /// An inline resource that contains code for a user-defined function (UDF).
    /// Providing a inline code resource is equivalent to providing a URI for a file containing the same code.
    /// </summary>
    public TerraformValue<string>? InlineCode
    {
        get => GetArgument<TerraformValue<string>>("inline_code");
        set => SetArgument("inline_code", value);
    }

    /// <summary>
    /// A code resource to load from a Google Cloud Storage URI (gs://bucket/path).
    /// </summary>
    public TerraformValue<string>? ResourceUri
    {
        get => GetArgument<TerraformValue<string>>("resource_uri");
        set => SetArgument("resource_uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryJob.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryJobTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_bigquery_job Terraform resource.
/// Manages a google_bigquery_job resource.
/// </summary>
public partial class GoogleBigqueryJob(string name) : TerraformResource("google_bigquery_job", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the job. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). The maximum length is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    public required TerraformValue<string> JobId
    {
        get => GetRequiredArgument<TerraformValue<string>>("job_id");
        set => SetArgument("job_id", value);
    }

    /// <summary>
    /// Job timeout in milliseconds. If this time limit is exceeded, BigQuery may attempt to terminate the job.
    /// </summary>
    public TerraformValue<string>? JobTimeoutMs
    {
        get => GetArgument<TerraformValue<string>>("job_timeout_ms");
        set => SetArgument("job_timeout_ms", value);
    }

    /// <summary>
    /// The labels associated with this job. You can use these to organize and group your jobs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The geographic location of the job. The default value is US.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The type of the job.
    /// </summary>
    public TerraformValue<string> JobType
        => CreateReference("job_type");

    /// <summary>
    /// The status of this job. Examine this value when polling an asynchronous job to see if the job is complete.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
        => CreateReference("status");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Email address of the user who ran the job.
    /// </summary>
    public TerraformValue<string> UserEmail
        => CreateReference("user_email");

    /// <summary>
    /// Copy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Copy block(s) allowed")]
    public TerraformList<GoogleBigqueryJobCopyBlock>? Copy
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobCopyBlock>>("copy");
        set => SetArgument("copy", value);
    }

    /// <summary>
    /// Extract block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Extract block(s) allowed")]
    public TerraformList<GoogleBigqueryJobExtractBlock>? Extract
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobExtractBlock>>("extract");
        set => SetArgument("extract", value);
    }

    /// <summary>
    /// Load block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Load block(s) allowed")]
    public TerraformList<GoogleBigqueryJobLoadBlock>? Load
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobLoadBlock>>("load");
        set => SetArgument("load", value);
    }

    /// <summary>
    /// Query block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Query block(s) allowed")]
    public TerraformList<GoogleBigqueryJobQueryBlock>? Query
    {
        get => GetArgument<TerraformList<GoogleBigqueryJobQueryBlock>>("query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryJobTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryJobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
