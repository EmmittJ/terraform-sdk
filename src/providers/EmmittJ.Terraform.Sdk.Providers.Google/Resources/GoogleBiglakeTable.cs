using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for hive_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBiglakeTableHiveOptionsBlock() : TerraformBlock("hive_options")
{
    /// <summary>
    /// Stores user supplied Hive table parameters. An object containing a
    /// list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// Hive table type. For example, MANAGED_TABLE, EXTERNAL_TABLE.
    /// </summary>
    [TerraformProperty("table_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TableType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBiglakeTableTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_biglake_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBiglakeTable : TerraformResource
{
    public GoogleBiglakeTable(string name) : base("google_biglake_table", name)
    {
    }

    /// <summary>
    /// The id of the parent database.
    /// </summary>
    [TerraformProperty("database")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Database { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Output only. The name of the Table. Format:
    /// projects/{project_id_or_number}/locations/{locationId}/catalogs/{catalogId}/databases/{databaseId}/tables/{tableId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The database type. Possible values: [&amp;quot;HIVE&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// Block for hive_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveOptions block(s) allowed")]
    [TerraformProperty("hive_options")]
    public TerraformList<GoogleBiglakeTableHiveOptionsBlock> HiveOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBiglakeTableTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The creation time of the table. A timestamp in RFC3339 UTC
    /// &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional
    /// digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. The deletion time of the table. Only set after the
    /// table is deleted. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with
    /// nanosecond resolution and up to nine fractional digits. Examples:
    /// &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// The checksum of a table object computed by the server based on the value
    /// of other fields. It may be sent on update requests to ensure the client
    /// has an up-to-date value before proceeding. It is only checked for update
    /// table operations.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Output only. The time when this table is considered expired. Only set
    /// after the table is deleted. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits. Examples:
    /// &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpireTime { get; }

    /// <summary>
    /// Output only. The last modification time of the table. A timestamp in
    /// RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
