using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_policy in GoogleBigtableTable.
/// Nesting mode: set
/// </summary>
public class GoogleBigtableTableAutomatedBackupPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automated_backup_policy";

    /// <summary>
    /// How frequently automated backups should occur.
    /// </summary>
    public TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// How long the automated backups should be retained.
    /// </summary>
    public TerraformValue<string> RetentionPeriod
    {
        get => new TerraformReference<string>(this, "retention_period");
        set => SetArgument("retention_period", value);
    }

}


/// <summary>
/// Block type for column_family in GoogleBigtableTable.
/// Nesting mode: set
/// </summary>
public class GoogleBigtableTableColumnFamilyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "column_family";

    /// <summary>
    /// The name of the column family.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    public required TerraformValue<string> Family
    {
        get => new TerraformReference<string>(this, "family");
        set => SetArgument("family", value);
    }

    /// <summary>
    /// The type of the column family.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigtableTable.
/// Nesting mode: single
/// </summary>
public class GoogleBigtableTableTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_bigtable_table Terraform resource.
/// Manages a google_bigtable_table resource.
/// </summary>
public partial class GoogleBigtableTable(string name) : TerraformResource("google_bigtable_table", name)
{
    /// <summary>
    /// Duration to retain change stream data for the table. Set to 0 to disable. Must be between 1 and 7 days.
    /// </summary>
    public TerraformValue<string> ChangeStreamRetention
    {
        get => new TerraformReference<string>(this, "change_stream_retention");
        set => SetArgument("change_stream_retention", value);
    }

    /// <summary>
    /// A field to make the table protected against data loss i.e. when set to PROTECTED, deleting the table, the column families in the table, and the instance containing the table would be prohibited. If not provided, currently deletion protection will be set to UNPROTECTED as it is the API default value.
    /// </summary>
    public TerraformValue<string> DeletionProtection
    {
        get => new TerraformReference<string>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
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
    /// The name of the Bigtable instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformValue<string> InstanceName
    {
        get => new TerraformReference<string>(this, "instance_name");
        set => SetArgument("instance_name", value);
    }

    /// <summary>
    /// The name of the table. Must be 1-50 characters and must only contain hyphens, underscores, periods, letters and numbers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Defines the row key schema of a table. To create or update a table with a row key schema, specify this argument.
    /// 					Note that in-place update is not supported, and any in-place modification to the schema will lead to failure.
    /// 				    To update a schema, please clear it (by omitting the field), and update the resource again with a new schema.\n
    /// 					
    /// 					The schema must be a valid JSON encoded string representing a Type&#39;s struct protobuf message. Note that for bytes sequence (like delimited_bytes.delimiter)
    /// 					the delimiter must be base64 encoded. For example, if you want to set a delimiter to a single byte character &amp;quot;#&amp;quot;, it should be set to &amp;quot;Iw==&amp;quot;, which is the base64 encoding of the byte sequence &amp;quot;#&amp;quot;.
    /// </summary>
    public TerraformValue<string>? RowKeySchema
    {
        get => new TerraformReference<string>(this, "row_key_schema");
        set => SetArgument("row_key_schema", value);
    }

    /// <summary>
    /// A list of predefined keys to split the table on. !&amp;gt; Warning: Modifying the split_keys of an existing table will cause Terraform to delete/recreate the entire google_bigtable_table resource.
    /// </summary>
    public TerraformList<string>? SplitKeys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "split_keys").ResolveNodes(ctx));
        set => SetArgument("split_keys", value);
    }

    /// <summary>
    /// AutomatedBackupPolicy block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupPolicy block(s) allowed")]
    public TerraformSet<GoogleBigtableTableAutomatedBackupPolicyBlock>? AutomatedBackupPolicy
    {
        get => GetArgument<TerraformSet<GoogleBigtableTableAutomatedBackupPolicyBlock>>("automated_backup_policy");
        set => SetArgument("automated_backup_policy", value);
    }

    /// <summary>
    /// ColumnFamily block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleBigtableTableColumnFamilyBlock>? ColumnFamily
    {
        get => GetArgument<TerraformSet<GoogleBigtableTableColumnFamilyBlock>>("column_family");
        set => SetArgument("column_family", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigtableTableTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigtableTableTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
