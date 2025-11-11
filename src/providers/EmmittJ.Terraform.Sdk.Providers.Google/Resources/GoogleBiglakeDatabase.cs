using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for hive_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBiglakeDatabaseHiveOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// Cloud Storage folder URI where the database data is stored, starting with &amp;quot;gs://&amp;quot;.
    /// </summary>
    [TerraformProperty("location_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LocationUri { get; set; }

    /// <summary>
    /// Stores user supplied Hive database parameters. An object containing a
    /// list of&amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Parameters { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBiglakeDatabaseTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_biglake_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBiglakeDatabase : TerraformResource
{
    public GoogleBiglakeDatabase(string name) : base("google_biglake_database", name)
    {
    }

    /// <summary>
    /// The parent catalog.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Catalog is required")]
    [TerraformProperty("catalog")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Catalog { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The database type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for hive_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HiveOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HiveOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveOptions block(s) allowed")]
    [TerraformProperty("hive_options")]
    public TerraformList<TerraformBlock<GoogleBiglakeDatabaseHiveOptionsBlock>>? HiveOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleBiglakeDatabaseTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The creation time of the database. A timestamp in RFC3339
    /// UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional
    /// digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. The deletion time of the database. Only set after the
    /// database is deleted. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with
    /// nanosecond resolution and up to nine fractional digits. Examples:
    /// &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// Output only. The time when this database is considered expired. Only set
    /// after the database is deleted. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits. Examples:
    /// &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExpireTime { get; }

    /// <summary>
    /// Output only. The last modification time of the database. A timestamp in
    /// RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
