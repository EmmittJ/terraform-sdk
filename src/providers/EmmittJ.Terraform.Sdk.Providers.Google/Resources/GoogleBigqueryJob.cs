using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for copy in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobCopyBlock
{
    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &#39;notFound&#39; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion Default value: &amp;quot;CREATE_IF_NEEDED&amp;quot; Possible values: [&amp;quot;CREATE_IF_NEEDED&amp;quot;, &amp;quot;CREATE_NEVER&amp;quot;]
    /// </summary>
    [TerraformPropertyName("create_disposition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateDisposition { get; set; }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &#39;duplicate&#39; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion. Default value: &amp;quot;WRITE_EMPTY&amp;quot; Possible values: [&amp;quot;WRITE_TRUNCATE&amp;quot;, &amp;quot;WRITE_APPEND&amp;quot;, &amp;quot;WRITE_EMPTY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("write_disposition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WriteDisposition { get; set; }

}

/// <summary>
/// Block type for extract in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobExtractBlock
{
    /// <summary>
    /// The compression type to use for exported files. Possible values include GZIP, DEFLATE, SNAPPY, and NONE.
    /// The default value is NONE. DEFLATE and SNAPPY are only supported for Avro.
    /// </summary>
    [TerraformPropertyName("compression")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Compression { get; set; }

    /// <summary>
    /// The exported file format. Possible values include CSV, NEWLINE_DELIMITED_JSON and AVRO for tables and SAVED_MODEL for models.
    /// The default value for tables is CSV. Tables with nested or repeated fields cannot be exported as CSV.
    /// The default value for models is SAVED_MODEL.
    /// </summary>
    [TerraformPropertyName("destination_format")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DestinationFormat { get; set; } = default!;

    /// <summary>
    /// A list of fully-qualified Google Cloud Storage URIs where the extracted table should be written.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationUris is required")]
    [TerraformPropertyName("destination_uris")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? DestinationUris { get; set; }

    /// <summary>
    /// When extracting data in CSV format, this defines the delimiter to use between fields in the exported data.
    /// Default is &#39;,&#39;
    /// </summary>
    [TerraformPropertyName("field_delimiter")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FieldDelimiter { get; set; } = default!;

    /// <summary>
    /// Whether to print out a header row in the results. Default is true.
    /// </summary>
    [TerraformPropertyName("print_header")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrintHeader { get; set; }

    /// <summary>
    /// Whether to use logical types when extracting to AVRO format.
    /// </summary>
    [TerraformPropertyName("use_avro_logical_types")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseAvroLogicalTypes { get; set; }

}

/// <summary>
/// Block type for load in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobLoadBlock
{
    /// <summary>
    /// Accept rows that are missing trailing optional columns. The missing values are treated as nulls.
    /// If false, records with missing trailing columns are treated as bad records, and if there are too many bad records,
    /// an invalid error is returned in the job result. The default value is false. Only applicable to CSV, ignored for other formats.
    /// </summary>
    [TerraformPropertyName("allow_jagged_rows")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowJaggedRows { get; set; }

    /// <summary>
    /// Indicates if BigQuery should allow quoted data sections that contain newline characters in a CSV file.
    /// The default value is false.
    /// </summary>
    [TerraformPropertyName("allow_quoted_newlines")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowQuotedNewlines { get; set; }

    /// <summary>
    /// Indicates if we should automatically infer the options and schema for CSV and JSON sources.
    /// </summary>
    [TerraformPropertyName("autodetect")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Autodetect { get; set; }

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &#39;notFound&#39; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion Default value: &amp;quot;CREATE_IF_NEEDED&amp;quot; Possible values: [&amp;quot;CREATE_IF_NEEDED&amp;quot;, &amp;quot;CREATE_NEVER&amp;quot;]
    /// </summary>
    [TerraformPropertyName("create_disposition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateDisposition { get; set; }

    /// <summary>
    /// The character encoding of the data. The supported values are UTF-8 or ISO-8859-1.
    /// The default value is UTF-8. BigQuery decodes the data after the raw, binary data
    /// has been split using the values of the quote and fieldDelimiter properties.
    /// </summary>
    [TerraformPropertyName("encoding")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Encoding { get; set; }

    /// <summary>
    /// The separator for fields in a CSV file. The separator can be any ISO-8859-1 single-byte character.
    /// To use a character in the range 128-255, you must encode the character as UTF8. BigQuery converts
    /// the string to ISO-8859-1 encoding, and then uses the first byte of the encoded string to split the
    /// data in its raw, binary state. BigQuery also supports the escape sequence &amp;quot;\t&amp;quot; to specify a tab separator.
    /// The default value is a comma (&#39;,&#39;).
    /// </summary>
    [TerraformPropertyName("field_delimiter")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FieldDelimiter { get; set; } = default!;

    /// <summary>
    /// Indicates if BigQuery should allow extra values that are not represented in the table schema.
    /// If true, the extra values are ignored. If false, records with extra columns are treated as bad records,
    /// and if there are too many bad records, an invalid error is returned in the job result.
    /// The default value is false. The sourceFormat property determines what BigQuery treats as an extra value:
    /// CSV: Trailing columns
    /// JSON: Named values that don&#39;t match any column names
    /// </summary>
    [TerraformPropertyName("ignore_unknown_values")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreUnknownValues { get; set; }

    /// <summary>
    /// If sourceFormat is set to newline-delimited JSON, indicates whether it should be processed as a JSON variant such as GeoJSON.
    /// For a sourceFormat other than JSON, omit this field. If the sourceFormat is newline-delimited JSON: - for newline-delimited
    /// GeoJSON: set to GEOJSON.
    /// </summary>
    [TerraformPropertyName("json_extension")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? JsonExtension { get; set; }

    /// <summary>
    /// The maximum number of bad records that BigQuery can ignore when running the job. If the number of bad records exceeds this value,
    /// an invalid error is returned in the job result. The default value is 0, which requires that all records are valid.
    /// </summary>
    [TerraformPropertyName("max_bad_records")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxBadRecords { get; set; }

    /// <summary>
    /// Specifies a string that represents a null value in a CSV file. For example, if you specify &amp;quot;\N&amp;quot;, BigQuery interprets &amp;quot;\N&amp;quot; as a null value
    /// when loading a CSV file. The default value is the empty string. If you set this property to a custom value, BigQuery throws an error if an
    /// empty string is present for all data types except for STRING and BYTE. For STRING and BYTE columns, BigQuery interprets the empty string as
    /// an empty value.
    /// </summary>
    [TerraformPropertyName("null_marker")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NullMarker { get; set; }

    /// <summary>
    /// If sourceFormat is set to &amp;quot;DATASTORE_BACKUP&amp;quot;, indicates which entity properties to load into BigQuery from a Cloud Datastore backup.
    /// Property names are case sensitive and must be top-level properties. If no properties are specified, BigQuery loads all properties.
    /// If any named property isn&#39;t found in the Cloud Datastore backup, an invalid error is returned in the job result.
    /// </summary>
    [TerraformPropertyName("projection_fields")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ProjectionFields { get; set; }

    /// <summary>
    /// The value that is used to quote data sections in a CSV file. BigQuery converts the string to ISO-8859-1 encoding,
    /// and then uses the first byte of the encoded string to split the data in its raw, binary state.
    /// The default value is a double-quote (&#39;&amp;quot;&#39;). If your data does not contain quoted sections, set the property value to an empty string.
    /// If your data contains quoted newline characters, you must also set the allowQuotedNewlines property to true.
    /// </summary>
    [TerraformPropertyName("quote")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Quote { get; set; } = default!;

    /// <summary>
    /// Allows the schema of the destination table to be updated as a side effect of the load job if a schema is autodetected or
    /// supplied in the job configuration. Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND;
    /// when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table, specified by partition decorators.
    /// For normal tables, WRITE_TRUNCATE will always overwrite the schema. One or more of the following values are specified:
    /// ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema.
    /// ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.
    /// </summary>
    [TerraformPropertyName("schema_update_options")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? SchemaUpdateOptions { get; set; }

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
    [TerraformPropertyName("skip_leading_rows")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SkipLeadingRows { get; set; }

    /// <summary>
    /// The format of the data files. For CSV files, specify &amp;quot;CSV&amp;quot;. For datastore backups, specify &amp;quot;DATASTORE_BACKUP&amp;quot;.
    /// For newline-delimited JSON, specify &amp;quot;NEWLINE_DELIMITED_JSON&amp;quot;. For Avro, specify &amp;quot;AVRO&amp;quot;. For parquet, specify &amp;quot;PARQUET&amp;quot;.
    /// For orc, specify &amp;quot;ORC&amp;quot;. [Beta] For Bigtable, specify &amp;quot;BIGTABLE&amp;quot;.
    /// The default value is CSV.
    /// </summary>
    [TerraformPropertyName("source_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceFormat { get; set; }

    /// <summary>
    /// The fully-qualified URIs that point to your data in Google Cloud.
    /// For Google Cloud Storage URIs: Each URI can contain one &#39;\*&#39; wildcard character
    /// and it must come after the &#39;bucket&#39; name. Size limits related to load jobs apply
    /// to external data sources. For Google Cloud Bigtable URIs: Exactly one URI can be
    /// specified and it has be a fully specified and valid HTTPS URL for a Google Cloud Bigtable table.
    /// For Google Cloud Datastore backups: Exactly one URI can be specified. Also, the &#39;\*&#39; wildcard character is not allowed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUris is required")]
    [TerraformPropertyName("source_uris")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? SourceUris { get; set; }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &#39;duplicate&#39; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion. Default value: &amp;quot;WRITE_EMPTY&amp;quot; Possible values: [&amp;quot;WRITE_TRUNCATE&amp;quot;, &amp;quot;WRITE_APPEND&amp;quot;, &amp;quot;WRITE_EMPTY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("write_disposition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WriteDisposition { get; set; }

}

/// <summary>
/// Block type for query in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryJobQueryBlock
{
    /// <summary>
    /// If true and query uses legacy SQL dialect, allows the query to produce arbitrarily large result tables at a slight cost in performance.
    /// Requires destinationTable to be set. For standard SQL queries, this flag is ignored and large results are always allowed.
    /// However, you must still set destinationTable when result size exceeds the allowed maximum response size.
    /// </summary>
    [TerraformPropertyName("allow_large_results")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowLargeResults { get; set; }

    /// <summary>
    /// Specifies whether the job is allowed to create new tables. The following values are supported:
    /// CREATE_IF_NEEDED: If the table does not exist, BigQuery creates the table.
    /// CREATE_NEVER: The table must already exist. If it does not, a &#39;notFound&#39; error is returned in the job result.
    /// Creation, truncation and append actions occur as one atomic update upon job completion Default value: &amp;quot;CREATE_IF_NEEDED&amp;quot; Possible values: [&amp;quot;CREATE_IF_NEEDED&amp;quot;, &amp;quot;CREATE_NEVER&amp;quot;]
    /// </summary>
    [TerraformPropertyName("create_disposition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateDisposition { get; set; }

    /// <summary>
    /// If true and query uses legacy SQL dialect, flattens all nested and repeated fields in the query results.
    /// allowLargeResults must be true if this is set to false. For standard SQL queries, this flag is ignored and results are never flattened.
    /// </summary>
    [TerraformPropertyName("flatten_results")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FlattenResults { get; set; }

    /// <summary>
    /// Limits the billing tier for this job. Queries that have resource usage beyond this tier will fail (without incurring a charge).
    /// If unspecified, this will be set to your project default.
    /// </summary>
    [TerraformPropertyName("maximum_billing_tier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaximumBillingTier { get; set; }

    /// <summary>
    /// Limits the bytes billed for this job. Queries that will have bytes billed beyond this limit will fail (without incurring a charge).
    /// If unspecified, this will be set to your project default.
    /// </summary>
    [TerraformPropertyName("maximum_bytes_billed")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaximumBytesBilled { get; set; }

    /// <summary>
    /// Standard SQL only. Set to POSITIONAL to use positional (?) query parameters or to NAMED to use named (@myparam) query parameters in this query.
    /// </summary>
    [TerraformPropertyName("parameter_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ParameterMode { get; set; }

    /// <summary>
    /// Specifies a priority for the query. Default value: &amp;quot;INTERACTIVE&amp;quot; Possible values: [&amp;quot;INTERACTIVE&amp;quot;, &amp;quot;BATCH&amp;quot;]
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Priority { get; set; }

    /// <summary>
    /// SQL query text to execute. The useLegacySql field can be used to indicate whether the query uses legacy SQL or standard SQL.
    /// *NOTE*: queries containing [DML language](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-manipulation-language)
    /// (&#39;DELETE&#39;, &#39;UPDATE&#39;, &#39;MERGE&#39;, &#39;INSERT&#39;) must specify &#39;create_disposition = &amp;quot;&amp;quot;&#39; and &#39;write_disposition = &amp;quot;&amp;quot;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformPropertyName("query")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Query { get; set; }

    /// <summary>
    /// Allows the schema of the destination table to be updated as a side effect of the query job.
    /// Schema update options are supported in two cases: when writeDisposition is WRITE_APPEND;
    /// when writeDisposition is WRITE_TRUNCATE and the destination table is a partition of a table,
    /// specified by partition decorators. For normal tables, WRITE_TRUNCATE will always overwrite the schema.
    /// One or more of the following values are specified:
    /// ALLOW_FIELD_ADDITION: allow adding a nullable field to the schema.
    /// ALLOW_FIELD_RELAXATION: allow relaxing a required field in the original schema to nullable.
    /// </summary>
    [TerraformPropertyName("schema_update_options")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? SchemaUpdateOptions { get; set; }

    /// <summary>
    /// Specifies whether to use BigQuery&#39;s legacy SQL dialect for this query. The default value is true.
    /// If set to false, the query will use BigQuery&#39;s standard SQL.
    /// </summary>
    [TerraformPropertyName("use_legacy_sql")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseLegacySql { get; set; }

    /// <summary>
    /// Whether to look for the result in the query cache. The query cache is a best-effort cache that will be flushed whenever
    /// tables in the query are modified. Moreover, the query cache is only available when a query does not have a destination table specified.
    /// The default value is true.
    /// </summary>
    [TerraformPropertyName("use_query_cache")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseQueryCache { get; set; }

    /// <summary>
    /// Specifies the action that occurs if the destination table already exists. The following values are supported:
    /// WRITE_TRUNCATE: If the table already exists, BigQuery overwrites the table data and uses the schema from the query result.
    /// WRITE_APPEND: If the table already exists, BigQuery appends the data to the table.
    /// WRITE_EMPTY: If the table already exists and contains data, a &#39;duplicate&#39; error is returned in the job result.
    /// Each action is atomic and only occurs if BigQuery is able to complete the job successfully.
    /// Creation, truncation and append actions occur as one atomic update upon job completion. Default value: &amp;quot;WRITE_EMPTY&amp;quot; Possible values: [&amp;quot;WRITE_TRUNCATE&amp;quot;, &amp;quot;WRITE_APPEND&amp;quot;, &amp;quot;WRITE_EMPTY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("write_disposition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WriteDisposition { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryJobTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryJob : TerraformResource
{
    public GoogleBigqueryJob(string name) : base("google_bigquery_job", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID of the job. The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), or dashes (-). The maximum length is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    [TerraformPropertyName("job_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> JobId { get; set; }

    /// <summary>
    /// Job timeout in milliseconds. If this time limit is exceeded, BigQuery may attempt to terminate the job.
    /// </summary>
    [TerraformPropertyName("job_timeout_ms")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? JobTimeoutMs { get; set; }

    /// <summary>
    /// The labels associated with this job. You can use these to organize and group your jobs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The geographic location of the job. The default value is US.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for copy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Copy block(s) allowed")]
    [TerraformPropertyName("copy")]
    public TerraformList<TerraformBlock<GoogleBigqueryJobCopyBlock>>? Copy { get; set; }

    /// <summary>
    /// Block for extract.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Extract block(s) allowed")]
    [TerraformPropertyName("extract")]
    public TerraformList<TerraformBlock<GoogleBigqueryJobExtractBlock>>? Extract { get; set; }

    /// <summary>
    /// Block for load.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Load block(s) allowed")]
    [TerraformPropertyName("load")]
    public TerraformList<TerraformBlock<GoogleBigqueryJobLoadBlock>>? Load { get; set; }

    /// <summary>
    /// Block for query.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Query block(s) allowed")]
    [TerraformPropertyName("query")]
    public TerraformList<TerraformBlock<GoogleBigqueryJobQueryBlock>>? Query { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryJobTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The type of the job.
    /// </summary>
    [TerraformPropertyName("job_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JobType => new TerraformReference(this, "job_type");

    /// <summary>
    /// The status of this job. Examine this value when polling an asynchronous job to see if the job is complete.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Email address of the user who ran the job.
    /// </summary>
    [TerraformPropertyName("user_email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserEmail => new TerraformReference(this, "user_email");

}
