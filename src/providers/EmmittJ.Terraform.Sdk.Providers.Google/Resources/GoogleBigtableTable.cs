using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_policy in .
/// Nesting mode: set
/// </summary>
public partial class GoogleBigtableTableAutomatedBackupPolicyBlock() : TerraformBlock("automated_backup_policy")
{
    /// <summary>
    /// How frequently automated backups should occur.
    /// </summary>
    [TerraformProperty("frequency")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Frequency { get; set; }

    /// <summary>
    /// How long the automated backups should be retained.
    /// </summary>
    [TerraformProperty("retention_period")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RetentionPeriod { get; set; }

}

/// <summary>
/// Block type for column_family in .
/// Nesting mode: set
/// </summary>
public partial class GoogleBigtableTableColumnFamilyBlock() : TerraformBlock("column_family")
{
    /// <summary>
    /// The name of the column family.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    [TerraformProperty("family")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Family { get; set; }

    /// <summary>
    /// The type of the column family.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigtableTableTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigtable_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigtableTable : TerraformResource
{
    public GoogleBigtableTable(string name) : base("google_bigtable_table", name)
    {
    }

    /// <summary>
    /// Duration to retain change stream data for the table. Set to 0 to disable. Must be between 1 and 7 days.
    /// </summary>
    [TerraformProperty("change_stream_retention")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ChangeStreamRetention { get; set; }

    /// <summary>
    /// A field to make the table protected against data loss i.e. when set to PROTECTED, deleting the table, the column families in the table, and the instance containing the table would be prohibited. If not provided, currently deletion protection will be set to UNPROTECTED as it is the API default value.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DeletionProtection { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Bigtable instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    [TerraformProperty("instance_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceName { get; set; }

    /// <summary>
    /// The name of the table. Must be 1-50 characters and must only contain hyphens, underscores, periods, letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Defines the row key schema of a table. To create or update a table with a row key schema, specify this argument.
    /// 					Note that in-place update is not supported, and any in-place modification to the schema will lead to failure.
    /// 				    To update a schema, please clear it (by omitting the field), and update the resource again with a new schema.\n
    /// 					
    /// 					The schema must be a valid JSON encoded string representing a Type&#39;s struct protobuf message. Note that for bytes sequence (like delimited_bytes.delimiter)
    /// 					the delimiter must be base64 encoded. For example, if you want to set a delimiter to a single byte character &amp;quot;#&amp;quot;, it should be set to &amp;quot;Iw==&amp;quot;, which is the base64 encoding of the byte sequence &amp;quot;#&amp;quot;.
    /// </summary>
    [TerraformProperty("row_key_schema")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RowKeySchema { get; set; }

    /// <summary>
    /// A list of predefined keys to split the table on. !&amp;gt; Warning: Modifying the split_keys of an existing table will cause Terraform to delete/recreate the entire google_bigtable_table resource.
    /// </summary>
    [TerraformProperty("split_keys")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SplitKeys { get; set; }

    /// <summary>
    /// Block for automated_backup_policy.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupPolicy block(s) allowed")]
    [TerraformProperty("automated_backup_policy")]
    public TerraformSet<GoogleBigtableTableAutomatedBackupPolicyBlock> AutomatedBackupPolicy { get; set; } = new();

    /// <summary>
    /// Block for column_family.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("column_family")]
    public TerraformSet<GoogleBigtableTableColumnFamilyBlock> ColumnFamily { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBigtableTableTimeoutsBlock Timeouts { get; set; } = new();

}
