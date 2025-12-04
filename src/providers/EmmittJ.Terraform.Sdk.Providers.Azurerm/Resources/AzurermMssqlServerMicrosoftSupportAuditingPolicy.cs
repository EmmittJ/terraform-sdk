using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMssqlServerMicrosoftSupportAuditingPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlServerMicrosoftSupportAuditingPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mssql_server_microsoft_support_auditing_policy Terraform resource.
/// Manages a azurerm_mssql_server_microsoft_support_auditing_policy resource.
/// </summary>
public partial class AzurermMssqlServerMicrosoftSupportAuditingPolicy(string name) : TerraformResource("azurerm_mssql_server_microsoft_support_auditing_policy", name)
{
    /// <summary>
    /// The blob_storage_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? BlobStorageEndpoint
    {
        get => GetArgument<TerraformValue<string>>("blob_storage_endpoint");
        set => SetArgument("blob_storage_endpoint", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
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
    /// The log_monitoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LogMonitoringEnabled
    {
        get => GetArgument<TerraformValue<bool>>("log_monitoring_enabled");
        set => SetArgument("log_monitoring_enabled", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountAccessKey
    {
        get => GetArgument<TerraformValue<string>>("storage_account_access_key");
        set => SetArgument("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountSubscriptionId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_subscription_id");
        set => SetArgument("storage_account_subscription_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlServerMicrosoftSupportAuditingPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlServerMicrosoftSupportAuditingPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
