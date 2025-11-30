using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLogAnalyticsClusterCustomerManagedKey.
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsClusterCustomerManagedKeyTimeoutsBlock : TerraformBlock
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
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_log_analytics_cluster_customer_managed_key Terraform resource.
/// Manages a azurerm_log_analytics_cluster_customer_managed_key resource.
/// </summary>
public partial class AzurermLogAnalyticsClusterCustomerManagedKey(string name) : TerraformResource("azurerm_log_analytics_cluster_customer_managed_key", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The log_analytics_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsClusterId is required")]
    public required TerraformValue<string> LogAnalyticsClusterId
    {
        get => new TerraformReference<string>(this, "log_analytics_cluster_id");
        set => SetArgument("log_analytics_cluster_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogAnalyticsClusterCustomerManagedKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogAnalyticsClusterCustomerManagedKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
