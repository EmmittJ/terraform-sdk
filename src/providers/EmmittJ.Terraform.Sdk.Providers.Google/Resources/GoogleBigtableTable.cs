using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_policy in .
/// Nesting mode: set
/// </summary>
public class GoogleBigtableTableAutomatedBackupPolicyBlock : TerraformBlock
{
    /// <summary>
    /// How frequently automated backups should occur.
    /// </summary>
    public TerraformProperty<string>? Frequency
    {
        set => SetProperty("frequency", value);
    }

    /// <summary>
    /// How long the automated backups should be retained.
    /// </summary>
    public TerraformProperty<string>? RetentionPeriod
    {
        set => SetProperty("retention_period", value);
    }

}

/// <summary>
/// Block type for column_family in .
/// Nesting mode: set
/// </summary>
public class GoogleBigtableTableColumnFamilyBlock : TerraformBlock
{
    /// <summary>
    /// The name of the column family.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    public required TerraformProperty<string> Family
    {
        set => SetProperty("family", value);
    }

    /// <summary>
    /// The type of the column family.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigtableTableTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_bigtable_table resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigtableTable : TerraformResource
{
    public GoogleBigtableTable(string name) : base("google_bigtable_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("change_stream_retention");
        SetOutput("deletion_protection");
        SetOutput("id");
        SetOutput("instance_name");
        SetOutput("name");
        SetOutput("project");
        SetOutput("row_key_schema");
        SetOutput("split_keys");
    }

    /// <summary>
    /// Duration to retain change stream data for the table. Set to 0 to disable. Must be between 1 and 7 days.
    /// </summary>
    public TerraformProperty<string> ChangeStreamRetention
    {
        get => GetRequiredOutput<TerraformProperty<string>>("change_stream_retention");
        set => SetProperty("change_stream_retention", value);
    }

    /// <summary>
    /// A field to make the table protected against data loss i.e. when set to PROTECTED, deleting the table, the column families in the table, and the instance containing the table would be prohibited. If not provided, currently deletion protection will be set to UNPROTECTED as it is the API default value.
    /// </summary>
    public TerraformProperty<string> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name of the Bigtable instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformProperty<string> InstanceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_name");
        set => SetProperty("instance_name", value);
    }

    /// <summary>
    /// The name of the table. Must be 1-50 characters and must only contain hyphens, underscores, periods, letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Defines the row key schema of a table. To create or update a table with a row key schema, specify this argument.
    /// 					Note that in-place update is not supported, and any in-place modification to the schema will lead to failure.
    /// 				    To update a schema, please clear it (by omitting the field), and update the resource again with a new schema.\n
    /// 					
    /// 					The schema must be a valid JSON encoded string representing a Type&#39;s struct protobuf message. Note that for bytes sequence (like delimited_bytes.delimiter)
    /// 					the delimiter must be base64 encoded. For example, if you want to set a delimiter to a single byte character &amp;quot;#&amp;quot;, it should be set to &amp;quot;Iw==&amp;quot;, which is the base64 encoding of the byte sequence &amp;quot;#&amp;quot;.
    /// </summary>
    public TerraformProperty<string> RowKeySchema
    {
        get => GetRequiredOutput<TerraformProperty<string>>("row_key_schema");
        set => SetProperty("row_key_schema", value);
    }

    /// <summary>
    /// A list of predefined keys to split the table on. !&amp;gt; Warning: Modifying the split_keys of an existing table will cause Terraform to delete/recreate the entire google_bigtable_table resource.
    /// </summary>
    public List<TerraformProperty<string>> SplitKeys
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("split_keys");
        set => SetProperty("split_keys", value);
    }

    /// <summary>
    /// Block for automated_backup_policy.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupPolicy block(s) allowed")]
    public HashSet<GoogleBigtableTableAutomatedBackupPolicyBlock>? AutomatedBackupPolicy
    {
        set => SetProperty("automated_backup_policy", value);
    }

    /// <summary>
    /// Block for column_family.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleBigtableTableColumnFamilyBlock>? ColumnFamily
    {
        set => SetProperty("column_family", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigtableTableTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
