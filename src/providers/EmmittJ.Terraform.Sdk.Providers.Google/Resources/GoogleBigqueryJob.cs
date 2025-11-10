using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for copy in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobCopyBlock : TerraformBlock
{
    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &#39;notFound&#39; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion Default value: &amp;quot;CREATE_IF_NEEDED&amp;quot; Possible values: [&amp;quot;CREATE_IF_NEEDED&amp;quot;, &amp;quot;CREATE_NEVER&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CreateDisposition
    {
        get => GetProperty<TerraformProperty<string>>("create_disposition");
        set => WithProperty("create_disposition", value);
    }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &#39;duplicate&#39; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion. Default value: &amp;quot;WRITE_EMPTY&amp;quot; Possible values: [&amp;quot;WRITE_TRUNCATE&amp;quot;, &amp;quot;WRITE_APPEND&amp;quot;, &amp;quot;WRITE_EMPTY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? WriteDisposition
    {
        get => GetProperty<TerraformProperty<string>>("write_disposition");
        set => WithProperty("write_disposition", value);
    }

}

/// <summary>
/// Block type for extract in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobExtractBlock : TerraformBlock
{
    /// <summary>
    /// The compression type to use for exported files. Possible values include GZIP, DEFLATE, SNAPPY, and NONE.
    /// The default value is NONE. DEFLATE and SNAPPY are only supported for Avro.
    /// </summary>
    public TerraformProperty<string>? Compression
    {
        get => GetProperty<TerraformProperty<string>>("compression");
        set => WithProperty("compression", value);
    }

    /// <summary>
    /// The exported file format. Possible values include CSV, NEWLINE_DELIMITED_JSON and AVRO for tables and SAVED_MODEL for models.
    /// The default value for tables is CSV. Tables with nested or repeated fields cannot be exported as CSV.
    /// The default value for models is SAVED_MODEL.
    /// </summary>
    public TerraformProperty<string>? DestinationFormat
    {
        get => GetProperty<TerraformProperty<string>>("destination_format");
        set => WithProperty("destination_format", value);
    }

    /// <summary>
    /// A list of fully-qualified Google Cloud Storage URIs where the extracted table should be written.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationUris is required")]
    public List<TerraformProperty<string>>? DestinationUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("destination_uris");
        set => WithProperty("destination_uris", value);
    }

    /// <summary>
    /// When extracting data in CSV format, this defines the delimiter to use between fields in the exported data.
    /// Default is &#39;,&#39;
    /// </summary>
    public TerraformProperty<string>? FieldDelimiter
    {
        get => GetProperty<TerraformProperty<string>>("field_delimiter");
        set => WithProperty("field_delimiter", value);
    }

    /// <summary>
    /// Whether to print out a header row in the results. Default is true.
    /// </summary>
    public TerraformProperty<bool>? PrintHeader
    {
        get => GetProperty<TerraformProperty<bool>>("print_header");
        set => WithProperty("print_header", value);
    }

    /// <summary>
    /// Whether to use logical types when extracting to AVRO format.
    /// </summary>
    public TerraformProperty<bool>? UseAvroLogicalTypes
    {
        get => GetProperty<TerraformProperty<bool>>("use_avro_logical_types");
        set => WithProperty("use_avro_logical_types", value);
    }

}

/// <summary>
/// Block type for load in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobLoadBlock : TerraformBlock
{
    /// <summary>
    /// Accept rows that are missing trailing optional columns. The missing values are treated as nulls.
    /// If false, records with missing trailing columns are treated as bad records, and if there are too many bad records,
    /// an invalid error is returned in the job result. The default value is false. Only applicable to CSV, ignored for other formats.
    /// </summary>
    public TerraformProperty<bool>? AllowJaggedRows
    {
        get => GetProperty<TerraformProperty<bool>>("allow_jagged_rows");
        set => WithProperty("allow_jagged_rows", value);
    }

    /// <summary>
    /// Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file.
    /// The default value is false.
    /// </summary>
    public TerraformProperty<bool>? AllowQuotedNewlines
    {
        get => GetProperty<TerraformProperty<bool>>("allow_quoted_newlines");
        set => WithProperty("allow_quoted_newlines", value);
    }

    /// <summary>
    /// Indicates if we should automatically infer the options and schema for CSV and JSON sources.
    /// </summary>
    public TerraformProperty<bool>? Autodetect
    {
        get => GetProperty<TerraformProperty<bool>>("autodetect");
        set => WithProperty("autodetect", value);
    }

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &#39;notFound&#39; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion Default value: &amp;quot;CREATE_IF_NEEDED&amp;quot; Possible values: [&amp;quot;CREATE_IF_NEEDED&amp;quot;, &amp;quot;CREATE_NEVER&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CreateDisposition
    {
        get => GetProperty<TerraformProperty<string>>("create_disposition");
        set => WithProperty("create_disposition", value);
    }

    /// <summary>
    /// The character encoding of the data. The supported values are UTF-8 or ISO-8859-1.
    /// The default value is UTF-8. BigQuery decodes the data after the raw, binary data
    /// has been split using the values of the quote and fieldDelimiter properties.
    /// </summary>
    public TerraformProperty<string>? Encoding
    {
        get => GetProperty<TerraformProperty<string>>("encoding");
        set => WithProperty("encoding", value);
    }

    /// <summary>
    /// The separator for fields in a CSV file. The separator can be any ISO-8859-1 single-byte character.
    /// To use a character in the range 128-255, you must encode the character as UTF8. BigQuery converts
    /// the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the
    /// data in its raw, binary state. BigQuery also supports the escape sequence &amp;quot;\t&amp;quot; to specify a tab separator.
    /// The default value is a comma (&#39;,&#39;).
    /// </summary>
    public TerraformProperty<string>? FieldDelimiter
    {
        get => GetProperty<TerraformProperty<string>>("field_delimiter");
        set => WithProperty("field_delimiter", value);
    }

    /// <summary>
    /// Indicates if BigQuery should allow extra values that are not represented in the table schema.
    /// If true, the extra values are ignored. If false, records with extra columns are treated as bad records,
    /// and if there are too many bad records, an invalid error is returned in the job result.
    /// The default value is false. The sourceFormat property determines what BigQuery treats as an extra value:
    /// CSV: Trailing columns
    /// JSON: Named values that don&#39;t match any column names
    /// </summary>
    public TerraformProperty<bool>? IgnoreUnknownValues
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_unknown_values");
        set => WithProperty("ignore_unknown_values", value);
    }

    /// <summary>
    /// If sourceFormat is set to newline-delimited JSON, indicates whether it should be processed as a JSON variant such as GeoJSON.
    /// For a sourceFormat other than JSON, omit this field. If the sourceFormat is newline-delimited JSON: - for newline-delimited
    /// GeoJSON: set to GEOJSON.
    /// </summary>
    public TerraformProperty<string>? JsonExtension
    {
        get => GetProperty<TerraformProperty<string>>("json_extension");
        set => WithProperty("json_extension", value);
    }

    /// <summary>
    /// The maximum number of bad records that BigQuery can ignore when running the job. If the number of bad records exceeds this value,
    /// an invalid error is returned in the job result. The default value is 0, which requires that all records are valid.
    /// </summary>
    public TerraformProperty<double>? MaxBadRecords
    {
        get => GetProperty<TerraformProperty<double>>("max_bad_records");
        set => WithProperty("max_bad_records", value);
    }

    /// <summary>
    /// Specifies a string that represents a null value in a CSV file. For example, if you specify &amp;quot;\N&amp;quot;, BigQuery interprets &amp;quot;\N&amp;quot; as a null value
    /// when loading a CSV file. The default value is the empty string. If you set this property to a custom value, BigQuery throws an error if an
    /// empty string is present for all data types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as
    /// an empty value.
    /// </summary>
    public TerraformProperty<string>? NullMarker
    {
        get => GetProperty<TerraformProperty<string>>("null_marker");
        set => WithProperty("null_marker", value);
    }

    /// <summary>
    /// If sourceFormat is set to &amp;quot;DATASTORE_BACKUP&amp;quot;, indicates which entity properties to load into BigQuery from a Cloud Datastore backup.
    /// Property names are case sensitive and must be top-level properties. If no properties are specified, BigQuery loads all properties.
    /// If any named property isn&#39;t found in the Cloud Datastore backup, an invalid error is returned in the job result.
    /// </summary>
    public List<TerraformProperty<string>>? ProjectionFields
    {
        get => GetProperty<List<TerraformProperty<string>>>("projection_fields");
        set => WithProperty("projection_fields", value);
    }

    /// <summary>
    /// The value that is used to quote data sections in a CSV file. BigQuery converts the string to ISO-8859-1 encoding,
    /// and then uses the first byte of the encoded string to split the data in its raw, binary state.
    /// The default value is a double-quote (&#39;&amp;quot;&#39;). If your data does not contain quoted sections, set the property value to an empty string.
    /// If your data contains quoted newline characters, you must also set the allowQuotedNewlines property to true.
    /// </summary>
    public TerraformProperty<string>? Quote
    {
        get => GetProperty<TerraformProperty<string>>("quote");
        set => WithProperty("quote", value);
    }

    /// <summary>
    /// Allows the schema of the destination table to be updated as a side effect of the load job if a schema is autodetected or
    /// supplied in the job configuration. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND;
    /// when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators.
    /// For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified:
    /// ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema.
    /// ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.
    /// </summary>
    public List<TerraformProperty<string>>? SchemaUpdateOptions
    {
        get => GetProperty<List<TerraformProperty<string>>>("schema_update_options");
        set => WithProperty("schema_update_options", value);
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
    public TerraformProperty<double>? SkipLeadingRows
    {
        get => GetProperty<TerraformProperty<double>>("skip_leading_rows");
        set => WithProperty("skip_leading_rows", value);
    }

    /// <summary>
    /// The format of the data files. For CSV files, specify &amp;quot;CSV&amp;quot;. For datastore backups, specify &amp;quot;DATASTORE_BACKUP&amp;quot;.
    /// For newline-delimited JSON, specify &amp;quot;NEWLINE_DELIMITED_JSON&amp;quot;. For Avro, specify &amp;quot;AVRO&amp;quot;. For parquet, specify &amp;quot;PARQUET&amp;quot;.
    /// For orc, specify &amp;quot;ORC&amp;quot;. [Beta] For Bigtable, specify &amp;quot;BIGTABLE&amp;quot;.
    /// The default value is CSV.
    /// </summary>
    public TerraformProperty<string>? SourceFormat
    {
        get => GetProperty<TerraformProperty<string>>("source_format");
        set => WithProperty("source_format", value);
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
    public List<TerraformProperty<string>>? SourceUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("source_uris");
        set => WithProperty("source_uris", value);
    }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &#39;duplicate&#39; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion. Default value: &amp;quot;WRITE_EMPTY&amp;quot; Possible values: [&amp;quot;WRITE_TRUNCATE&amp;quot;, &amp;quot;WRITE_APPEND&amp;quot;, &amp;quot;WRITE_EMPTY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? WriteDisposition
    {
        get => GetProperty<TerraformProperty<string>>("write_disposition");
        set => WithProperty("write_disposition", value);
    }

}

/// <summary>
/// Block type for query in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobQueryBlock : TerraformBlock
{
    /// <summary>
    /// If true and query uses legacy SQL dialect, allows the query to produce arbitrarily large result tables at a slight cost in performance.
    /// Requires destinationTable to be set. For standard SQL queries, this flag is ignored and large results are always allowed.
    /// However, you must still set destinationTable when result size exceeds the allowed maximum response size.
    /// </summary>
    public TerraformProperty<bool>? AllowLargeResults
    {
        get => GetProperty<TerraformProperty<bool>>("allow_large_results");
        set => WithProperty("allow_large_results", value);
    }

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &#39;notFound&#39; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion Default value: &amp;quot;CREATE_IF_NEEDED&amp;quot; Possible values: [&amp;quot;CREATE_IF_NEEDED&amp;quot;, &amp;quot;CREATE_NEVER&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CreateDisposition
    {
        get => GetProperty<TerraformProperty<string>>("create_disposition");
        set => WithProperty("create_disposition", value);
    }

    /// <summary>
    /// If true and query uses legacy SQL dialect, flattens all nested and repeated fields in the query results.
    /// allowLargeResults must be true if this is set to false. For standard SQL queries, this flag is ignored and results are never flattened.
    /// </summary>
    public TerraformProperty<bool>? FlattenResults
    {
        get => GetProperty<TerraformProperty<bool>>("flatten_results");
        set => WithProperty("flatten_results", value);
    }

    /// <summary>
    /// Limits the billing tier for this job. Queries that have resource usage beyond this tier will fail (without incurring a charge).
    /// If unspecified, this will be set to your project default.
    /// </summary>
    public TerraformProperty<double>? MaximumBillingTier
    {
        get => GetProperty<TerraformProperty<double>>("maximum_billing_tier");
        set => WithProperty("maximum_billing_tier", value);
    }

    /// <summary>
    /// Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will fail (without incurring a charge).
    /// If unspecified, this will be set to your project default.
    /// </summary>
    public TerraformProperty<string>? MaximumBytesBilled
    {
        get => GetProperty<TerraformProperty<string>>("maximum_bytes_billed");
        set => WithProperty("maximum_bytes_billed", value);
    }

    /// <summary>
    /// Standard SQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named (@myparam) query parameters in this query.
    /// </summary>
    public TerraformProperty<string>? ParameterMode
    {
        get => GetProperty<TerraformProperty<string>>("parameter_mode");
        set => WithProperty("parameter_mode", value);
    }

    /// <summary>
    /// Specifies a priority for the query. Default value: &amp;quot;INTERACTIVE&amp;quot; Possible values: [&amp;quot;INTERACTIVE&amp;quot;, &amp;quot;BATCH&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Priority
    {
        get => GetProperty<TerraformProperty<string>>("priority");
        set => WithProperty("priority", value);
    }

    /// <summary>
    /// SQL query text to execute. The useLegacySql field can be used to indicate whether the query uses legacy SQL or standard SQL.
    /// *NOTE*: queries containing [DML language](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-manipulation-language)
    /// (&#39;DELETE&#39;, &#39;UPDATE&#39;, &#39;MERGE&#39;, &#39;INSERT&#39;) must specify &#39;create_disposition = &amp;quot;&amp;quot;&#39; and &#39;write_disposition = &amp;quot;&amp;quot;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformProperty<string> Query
    {
        get => GetRequiredProperty<TerraformProperty<string>>("query");
        set => WithProperty("query", value);
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
    public List<TerraformProperty<string>>? SchemaUpdateOptions
    {
        get => GetProperty<List<TerraformProperty<string>>>("schema_update_options");
        set => WithProperty("schema_update_options", value);
    }

    /// <summary>
    /// Specifies whether to use BigQuery&#39;s legacy SQL dialect for this query. The default value is true.
    /// If set to false, the query will use BigQuery&#39;s standard SQL.
    /// </summary>
    public TerraformProperty<bool>? UseLegacySql
    {
        get => GetProperty<TerraformProperty<bool>>("use_legacy_sql");
        set => WithProperty("use_legacy_sql", value);
    }

    /// <summary>
    /// Whether to look for the result in the query cache. The query cache is a best-effort cache that will be flushed whenever
    /// tables in the query are modified. Moreover, the query cache is only available when a query does not have a destination table specified.
    /// The default value is true.
    /// </summary>
    public TerraformProperty<bool>? UseQueryCache
    {
        get => GetProperty<TerraformProperty<bool>>("use_query_cache");
        set => WithProperty("use_query_cache", value);
    }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &#39;duplicate&#39; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion. Default value: &amp;quot;WRITE_EMPTY&amp;quot; Possible values: [&amp;quot;WRITE_TRUNCATE&amp;quot;, &amp;quot;WRITE_APPEND&amp;quot;, &amp;quot;WRITE_EMPTY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? WriteDisposition
    {
        get => GetProperty<TerraformProperty<string>>("write_disposition");
        set => WithProperty("write_disposition", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryJobTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_bigquery_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryJob : TerraformResource
{
    public GoogleBigqueryJob(string name) : base("google_bigquery_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("effective_labels");
        this.WithOutput("job_type");
        this.WithOutput("status");
        this.WithOutput("terraform_labels");
        this.WithOutput("user_email");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ID of the job. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). The maximum length is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    public required TerraformProperty<string> JobId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("job_id");
        set => this.WithProperty("job_id", value);
    }

    /// <summary>
    /// Job timeout in milliseconds. If this time limit is exceeded, BigQuery may attempt to terminate the job.
    /// </summary>
    public TerraformProperty<string>? JobTimeoutMs
    {
        get => GetProperty<TerraformProperty<string>>("job_timeout_ms");
        set => this.WithProperty("job_timeout_ms", value);
    }

    /// <summary>
    /// The labels associated with this job. You can use these to organize and group your jobs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The geographic location of the job. The default value is US.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for copy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Copy block(s) allowed")]
    public List<GoogleBigqueryJobCopyBlock>? Copy
    {
        get => GetProperty<List<GoogleBigqueryJobCopyBlock>>("copy");
        set => this.WithProperty("copy", value);
    }

    /// <summary>
    /// Block for extract.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Extract block(s) allowed")]
    public List<GoogleBigqueryJobExtractBlock>? Extract
    {
        get => GetProperty<List<GoogleBigqueryJobExtractBlock>>("extract");
        set => this.WithProperty("extract", value);
    }

    /// <summary>
    /// Block for load.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Load block(s) allowed")]
    public List<GoogleBigqueryJobLoadBlock>? Load
    {
        get => GetProperty<List<GoogleBigqueryJobLoadBlock>>("load");
        set => this.WithProperty("load", value);
    }

    /// <summary>
    /// Block for query.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Query block(s) allowed")]
    public List<GoogleBigqueryJobQueryBlock>? Query
    {
        get => GetProperty<List<GoogleBigqueryJobQueryBlock>>("query");
        set => this.WithProperty("query", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryJobTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigqueryJobTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The type of the job.
    /// </summary>
    public TerraformExpression JobType => this["job_type"];

    /// <summary>
    /// The status of this job. Examine this value when polling an asynchronous job to see if the job is complete.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Email address of the user who ran the job.
    /// </summary>
    public TerraformExpression UserEmail => this["user_email"];

}
