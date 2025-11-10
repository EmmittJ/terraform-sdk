using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseSqlPoolSecurityAlertPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
/// Manages a azurerm_synapse_sql_pool_security_alert_policy resource.
/// </summary>
public class AzurermSynapseSqlPoolSecurityAlertPolicy : TerraformResource
{
    public AzurermSynapseSqlPoolSecurityAlertPolicy(string name) : base("azurerm_synapse_sql_pool_security_alert_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("disabled_alerts");
        SetOutput("email_account_admins_enabled");
        SetOutput("email_addresses");
        SetOutput("id");
        SetOutput("policy_state");
        SetOutput("retention_days");
        SetOutput("sql_pool_id");
        SetOutput("storage_account_access_key");
        SetOutput("storage_endpoint");
    }

    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> DisabledAlerts
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("disabled_alerts");
        set => SetProperty("disabled_alerts", value);
    }

    /// <summary>
    /// The email_account_admins_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> EmailAccountAdminsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("email_account_admins_enabled");
        set => SetProperty("email_account_admins_enabled", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> EmailAddresses
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("email_addresses");
        set => SetProperty("email_addresses", value);
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
    /// The policy_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyState is required")]
    public required TerraformProperty<string> PolicyState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_state");
        set => SetProperty("policy_state", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    public TerraformProperty<double> RetentionDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retention_days");
        set => SetProperty("retention_days", value);
    }

    /// <summary>
    /// The sql_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlPoolId is required")]
    public required TerraformProperty<string> SqlPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_pool_id");
        set => SetProperty("sql_pool_id", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformProperty<string> StorageAccountAccessKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_access_key");
        set => SetProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    public TerraformProperty<string> StorageEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_endpoint");
        set => SetProperty("storage_endpoint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseSqlPoolSecurityAlertPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
