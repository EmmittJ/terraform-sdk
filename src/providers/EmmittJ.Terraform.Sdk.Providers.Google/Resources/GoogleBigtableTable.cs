using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_policy in .
/// Nesting mode: set
/// </summary>
public class GoogleBigtableTableAutomatedBackupPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// How frequently automated backups should occur.
    /// </summary>
    [TerraformPropertyName("frequency")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Frequency { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "frequency");

    /// <summary>
    /// How long the automated backups should be retained.
    /// </summary>
    [TerraformPropertyName("retention_period")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RetentionPeriod { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "retention_period");

}

/// <summary>
/// Block type for column_family in .
/// Nesting mode: set
/// </summary>
public class GoogleBigtableTableColumnFamilyBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the column family.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    [TerraformPropertyName("family")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Family { get; set; }

    /// <summary>
    /// The type of the column family.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigtableTableTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigtable_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigtableTable : TerraformResource
{
    public GoogleBigtableTable(string name) : base("google_bigtable_table", name)
    {
    }

    /// <summary>
    /// Duration to retain change stream data for the table. Set to 0 to disable. Must be between 1 and 7 days.
    /// </summary>
    [TerraformPropertyName("change_stream_retention")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ChangeStreamRetention { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "change_stream_retention");

    /// <summary>
    /// A field to make the table protected against data loss i.e. when set to PROTECTED, deleting the table, the column families in the table, and the instance containing the table would be prohibited. If not provided, currently deletion protection will be set to UNPROTECTED as it is the API default value.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DeletionProtection { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deletion_protection");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the Bigtable instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    [TerraformPropertyName("instance_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceName { get; set; }

    /// <summary>
    /// The name of the table. Must be 1-50 characters and must only contain hyphens, underscores, periods, letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Defines the row key schema of a table. To create or update a table with a row key schema, specify this argument.
    /// 					Note that in-place update is not supported, and any in-place modification to the schema will lead to failure.
    /// 				    To update a schema, please clear it (by omitting the field), and update the resource again with a new schema.\n
    /// 					
    /// 					The schema must be a valid JSON encoded string representing a Type&#39;s struct protobuf message. Note that for bytes sequence (like delimited_bytes.delimiter)
    /// 					the delimiter must be base64 encoded. For example, if you want to set a delimiter to a single byte character &amp;quot;#&amp;quot;, it should be set to &amp;quot;Iw==&amp;quot;, which is the base64 encoding of the byte sequence &amp;quot;#&amp;quot;.
    /// </summary>
    [TerraformPropertyName("row_key_schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RowKeySchema { get; set; }

    /// <summary>
    /// A list of predefined keys to split the table on. !&amp;gt; Warning: Modifying the split_keys of an existing table will cause Terraform to delete/recreate the entire google_bigtable_table resource.
    /// </summary>
    [TerraformPropertyName("split_keys")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SplitKeys { get; set; }

    /// <summary>
    /// Block for automated_backup_policy.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupPolicy block(s) allowed")]
    [TerraformPropertyName("automated_backup_policy")]
    public TerraformSet<TerraformBlock<GoogleBigtableTableAutomatedBackupPolicyBlock>>? AutomatedBackupPolicy { get; set; } = new();

    /// <summary>
    /// Block for column_family.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("column_family")]
    public TerraformSet<TerraformBlock<GoogleBigtableTableColumnFamilyBlock>>? ColumnFamily { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigtableTableTimeoutsBlock>? Timeouts { get; set; } = new();

}
