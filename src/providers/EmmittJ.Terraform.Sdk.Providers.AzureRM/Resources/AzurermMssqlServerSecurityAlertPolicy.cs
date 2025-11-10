using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlServerSecurityAlertPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_mssql_server_security_alert_policy resource.
/// </summary>
public class AzurermMssqlServerSecurityAlertPolicy : TerraformResource
{
    public AzurermMssqlServerSecurityAlertPolicy(string name) : base("azurerm_mssql_server_security_alert_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("disabled_alerts");
        SetOutput("email_account_admins");
        SetOutput("email_addresses");
        SetOutput("id");
        SetOutput("resource_group_name");
        SetOutput("retention_days");
        SetOutput("server_name");
        SetOutput("state");
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
    /// The email_account_admins attribute.
    /// </summary>
    public TerraformProperty<bool> EmailAccountAdmins
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("email_account_admins");
        set => SetProperty("email_account_admins", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
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
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    public required TerraformProperty<string> ServerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_name");
        set => SetProperty("server_name", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
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
    public AzurermMssqlServerSecurityAlertPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
