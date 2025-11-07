using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? DisabledAlerts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("disabled_alerts");
        set => this.WithProperty("disabled_alerts", value);
    }

    /// <summary>
    /// The email_account_admins_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EmailAccountAdminsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("email_account_admins_enabled");
        set => this.WithProperty("email_account_admins_enabled", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? EmailAddresses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("email_addresses");
        set => this.WithProperty("email_addresses", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The policy_state attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_state");
        set => this.WithProperty("policy_state", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_days");
        set => this.WithProperty("retention_days", value);
    }

    /// <summary>
    /// The sql_pool_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqlPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_pool_id");
        set => this.WithProperty("sql_pool_id", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_access_key");
        set => this.WithProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_endpoint");
        set => this.WithProperty("storage_endpoint", value);
    }

}
