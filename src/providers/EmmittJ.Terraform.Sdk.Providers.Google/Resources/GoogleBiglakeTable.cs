using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for hive_options in GoogleBiglakeTable.
/// Nesting mode: list
/// </summary>
public class GoogleBiglakeTableHiveOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hive_options";

    /// <summary>
    /// Stores user supplied Hive table parameters. An object containing a
    /// list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Hive table type. For example, MANAGED_TABLE, EXTERNAL_TABLE.
    /// </summary>
    public TerraformValue<string>? TableType
    {
        get => GetArgument<TerraformValue<string>>("table_type");
        set => SetArgument("table_type", value);
    }

    /// <summary>
    /// StorageDescriptor block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageDescriptor block(s) allowed")]
    public TerraformList<GoogleBiglakeTableHiveOptionsBlockStorageDescriptorBlock>? StorageDescriptor
    {
        get => GetArgument<TerraformList<GoogleBiglakeTableHiveOptionsBlockStorageDescriptorBlock>>("storage_descriptor");
        set => SetArgument("storage_descriptor", value);
    }

}

/// <summary>
/// Block type for storage_descriptor in GoogleBiglakeTableHiveOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBiglakeTableHiveOptionsBlockStorageDescriptorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_descriptor";

    /// <summary>
    /// The fully qualified Java class name of the input format.
    /// </summary>
    public TerraformValue<string>? InputFormat
    {
        get => GetArgument<TerraformValue<string>>("input_format");
        set => SetArgument("input_format", value);
    }

    /// <summary>
    /// Cloud Storage folder URI where the table data is stored, starting with &amp;quot;gs://&amp;quot;.
    /// </summary>
    public TerraformValue<string>? LocationUri
    {
        get => GetArgument<TerraformValue<string>>("location_uri");
        set => SetArgument("location_uri", value);
    }

    /// <summary>
    /// The fully qualified Java class name of the output format.
    /// </summary>
    public TerraformValue<string>? OutputFormat
    {
        get => GetArgument<TerraformValue<string>>("output_format");
        set => SetArgument("output_format", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBiglakeTable.
/// Nesting mode: single
/// </summary>
public class GoogleBiglakeTableTimeoutsBlock : TerraformBlock
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
/// Represents a google_biglake_table Terraform resource.
/// Manages a google_biglake_table resource.
/// </summary>
public partial class GoogleBiglakeTable(string name) : TerraformResource("google_biglake_table", name)
{
    /// <summary>
    /// The id of the parent database.
    /// </summary>
    public TerraformValue<string>? Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Output only. The name of the Table. Format:
    /// projects/{project_id_or_number}/locations/{locationId}/catalogs/{catalogId}/databases/{databaseId}/tables/{tableId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The database type. Possible values: [&amp;quot;HIVE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Output only. The creation time of the table. A timestamp in RFC3339 UTC
    /// &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional
    /// digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Output only. The deletion time of the table. Only set after the
    /// table is deleted. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with
    /// nanosecond resolution and up to nine fractional digits. Examples:
    /// &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> DeleteTime
        => AsReference("delete_time");

    /// <summary>
    /// The checksum of a table object computed by the server based on the value
    /// of other fields. It may be sent on update requests to ensure the client
    /// has an up-to-date value before proceeding. It is only checked for update
    /// table operations.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Output only. The time when this table is considered expired. Only set
    /// after the table is deleted. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits. Examples:
    /// &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> ExpireTime
        => AsReference("expire_time");

    /// <summary>
    /// Output only. The last modification time of the table. A timestamp in
    /// RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// HiveOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveOptions block(s) allowed")]
    public TerraformList<GoogleBiglakeTableHiveOptionsBlock>? HiveOptions
    {
        get => GetArgument<TerraformList<GoogleBiglakeTableHiveOptionsBlock>>("hive_options");
        set => SetArgument("hive_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBiglakeTableTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBiglakeTableTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
