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
public class AzurermSynapseSqlPoolSecurityAlertPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_synapse_sql_pool_security_alert_policy resource.
/// </summary>
public class AzurermSynapseSqlPoolSecurityAlertPolicy : TerraformResource
{
    public AzurermSynapseSqlPoolSecurityAlertPolicy(string name) : base("azurerm_synapse_sql_pool_security_alert_policy", name)
    {
    }

    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    [TerraformArgument("disabled_alerts")]
    public TerraformSet<string>? DisabledAlerts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "disabled_alerts").ResolveNodes(ctx));
        set => SetArgument("disabled_alerts", value);
    }

    /// <summary>
    /// The email_account_admins_enabled attribute.
    /// </summary>
    [TerraformArgument("email_account_admins_enabled")]
    public TerraformValue<bool>? EmailAccountAdminsEnabled
    {
        get => new TerraformReference<bool>(this, "email_account_admins_enabled");
        set => SetArgument("email_account_admins_enabled", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    [TerraformArgument("email_addresses")]
    public TerraformSet<string>? EmailAddresses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "email_addresses").ResolveNodes(ctx));
        set => SetArgument("email_addresses", value);
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
    /// The policy_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyState is required")]
    [TerraformArgument("policy_state")]
    public required TerraformValue<string> PolicyState
    {
        get => new TerraformReference<string>(this, "policy_state");
        set => SetArgument("policy_state", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [TerraformArgument("retention_days")]
    public TerraformValue<double>? RetentionDays
    {
        get => new TerraformReference<double>(this, "retention_days");
        set => SetArgument("retention_days", value);
    }

    /// <summary>
    /// The sql_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlPoolId is required")]
    [TerraformArgument("sql_pool_id")]
    public required TerraformValue<string> SqlPoolId
    {
        get => new TerraformReference<string>(this, "sql_pool_id");
        set => SetArgument("sql_pool_id", value);
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
    /// The storage_endpoint attribute.
    /// </summary>
    [TerraformArgument("storage_endpoint")]
    public TerraformValue<string>? StorageEndpoint
    {
        get => new TerraformReference<string>(this, "storage_endpoint");
        set => SetArgument("storage_endpoint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSynapseSqlPoolSecurityAlertPolicyTimeoutsBlock Timeouts { get; set; } = new();

}
