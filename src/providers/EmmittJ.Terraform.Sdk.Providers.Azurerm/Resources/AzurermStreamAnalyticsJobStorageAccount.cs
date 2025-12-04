using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStreamAnalyticsJobStorageAccount.
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsJobStorageAccountTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_stream_analytics_job_storage_account Terraform resource.
/// Manages a azurerm_stream_analytics_job_storage_account resource.
/// </summary>
public partial class AzurermStreamAnalyticsJobStorageAccount(string name) : TerraformResource("azurerm_stream_analytics_job_storage_account", name)
{
    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationMode is required")]
    public required TerraformValue<string> AuthenticationMode
    {
        get => GetArgument<TerraformValue<string>>("authentication_mode");
        set => SetArgument("authentication_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
        get => GetArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    public required TerraformValue<string> StreamAnalyticsJobId
    {
        get => GetArgument<TerraformValue<string>>("stream_analytics_job_id");
        set => SetArgument("stream_analytics_job_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsJobStorageAccountTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsJobStorageAccountTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
