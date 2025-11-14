using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_server_microsoft_support_auditing_policy resource.
/// </summary>
public class AzurermMssqlServerMicrosoftSupportAuditingPolicy : TerraformResource
{
    public AzurermMssqlServerMicrosoftSupportAuditingPolicy(string name) : base("azurerm_mssql_server_microsoft_support_auditing_policy", name)
    {
    }

    /// <summary>
    /// The blob_storage_endpoint attribute.
    /// </summary>
    [TerraformArgument("blob_storage_endpoint")]
    public TerraformValue<string>? BlobStorageEndpoint
    {
        get => new TerraformReference<string>(this, "blob_storage_endpoint");
        set => SetArgument("blob_storage_endpoint", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_monitoring_enabled attribute.
    /// </summary>
    [TerraformArgument("log_monitoring_enabled")]
    public TerraformValue<bool>? LogMonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "log_monitoring_enabled");
        set => SetArgument("log_monitoring_enabled", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformArgument("server_id")]
    public required TerraformValue<string> ServerId
    {
        get => new TerraformReference<string>(this, "server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformArgument("storage_account_access_key")]
    public TerraformValue<string>? StorageAccountAccessKey
    {
        get => new TerraformReference<string>(this, "storage_account_access_key");
        set => SetArgument("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_account_subscription_id attribute.
    /// </summary>
    [TerraformArgument("storage_account_subscription_id")]
    public TerraformValue<string>? StorageAccountSubscriptionId
    {
        get => new TerraformReference<string>(this, "storage_account_subscription_id");
        set => SetArgument("storage_account_subscription_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlServerMicrosoftSupportAuditingPolicyTimeoutsBlock Timeouts { get; set; } = new();

}
