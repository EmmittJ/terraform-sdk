using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseWorkspaceSecurityAlertPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_synapse_workspace_security_alert_policy resource.
/// </summary>
public class AzurermSynapseWorkspaceSecurityAlertPolicy : TerraformResource
{
    public AzurermSynapseWorkspaceSecurityAlertPolicy(string name) : base("azurerm_synapse_workspace_security_alert_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DisabledAlerts
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("disabled_alerts");
        set => this.WithProperty("disabled_alerts", value);
    }

    /// <summary>
    /// The email_account_admins_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EmailAccountAdminsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("email_account_admins_enabled");
        set => this.WithProperty("email_account_admins_enabled", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EmailAddresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("email_addresses");
        set => this.WithProperty("email_addresses", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The policy_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyState is required")]
    public required TerraformProperty<string> PolicyState
    {
        get => GetProperty<TerraformProperty<string>>("policy_state");
        set => this.WithProperty("policy_state", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_days");
        set => this.WithProperty("retention_days", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_access_key");
        set => this.WithProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? StorageEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("storage_endpoint");
        set => this.WithProperty("storage_endpoint", value);
    }

    /// <summary>
    /// The synapse_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynapseWorkspaceId is required")]
    public required TerraformProperty<string> SynapseWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("synapse_workspace_id");
        set => this.WithProperty("synapse_workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseWorkspaceSecurityAlertPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSynapseWorkspaceSecurityAlertPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
