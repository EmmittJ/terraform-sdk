using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for serialization in AzurermStreamAnalyticsOutputBlob.
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsOutputBlobSerializationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "serialization";

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => GetArgument<TerraformValue<string>>("encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    public TerraformValue<string>? FieldDelimiter
    {
        get => GetArgument<TerraformValue<string>>("field_delimiter");
        set => SetArgument("field_delimiter", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformValue<string>? Format
    {
        get => GetArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStreamAnalyticsOutputBlob.
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsOutputBlobTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_stream_analytics_output_blob Terraform resource.
/// Manages a azurerm_stream_analytics_output_blob resource.
/// </summary>
public partial class AzurermStreamAnalyticsOutputBlob(string name) : TerraformResource("azurerm_stream_analytics_output_blob", name)
{
    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationMode
    {
        get => GetArgument<TerraformValue<string>>("authentication_mode");
        set => SetArgument("authentication_mode", value);
    }

    /// <summary>
    /// The batch_max_wait_time attribute.
    /// </summary>
    public TerraformValue<string>? BatchMaxWaitTime
    {
        get => GetArgument<TerraformValue<string>>("batch_max_wait_time");
        set => SetArgument("batch_max_wait_time", value);
    }

    /// <summary>
    /// The batch_min_rows attribute.
    /// </summary>
    public TerraformValue<double>? BatchMinRows
    {
        get => GetArgument<TerraformValue<double>>("batch_min_rows");
        set => SetArgument("batch_min_rows", value);
    }

    /// <summary>
    /// The blob_write_mode attribute.
    /// </summary>
    public TerraformValue<string>? BlobWriteMode
    {
        get => GetArgument<TerraformValue<string>>("blob_write_mode");
        set => SetArgument("blob_write_mode", value);
    }

    /// <summary>
    /// The date_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DateFormat is required")]
    public required TerraformValue<string> DateFormat
    {
        get => GetRequiredArgument<TerraformValue<string>>("date_format");
        set => SetArgument("date_format", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path_pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PathPattern is required")]
    public required TerraformValue<string> PathPattern
    {
        get => GetRequiredArgument<TerraformValue<string>>("path_pattern");
        set => SetArgument("path_pattern", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountKey
    {
        get => GetArgument<TerraformValue<string>>("storage_account_key");
        set => SetArgument("storage_account_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformValue<string> StorageAccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerName is required")]
    public required TerraformValue<string> StorageContainerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_container_name");
        set => SetArgument("storage_container_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformValue<string> StreamAnalyticsJobName
    {
        get => GetRequiredArgument<TerraformValue<string>>("stream_analytics_job_name");
        set => SetArgument("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The time_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeFormat is required")]
    public required TerraformValue<string> TimeFormat
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_format");
        set => SetArgument("time_format", value);
    }

    /// <summary>
    /// Serialization block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serialization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Serialization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serialization block(s) allowed")]
    public required TerraformList<AzurermStreamAnalyticsOutputBlobSerializationBlock> Serialization
    {
        get => GetRequiredArgument<TerraformList<AzurermStreamAnalyticsOutputBlobSerializationBlock>>("serialization");
        set => SetArgument("serialization", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsOutputBlobTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsOutputBlobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
