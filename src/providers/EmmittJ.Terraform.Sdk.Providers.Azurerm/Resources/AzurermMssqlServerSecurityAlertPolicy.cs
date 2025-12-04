using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMssqlServerSecurityAlertPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlServerSecurityAlertPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mssql_server_security_alert_policy Terraform resource.
/// Manages a azurerm_mssql_server_security_alert_policy resource.
/// </summary>
public partial class AzurermMssqlServerSecurityAlertPolicy(string name) : TerraformResource("azurerm_mssql_server_security_alert_policy", name)
{
    /// <summary>
    /// The disabled_alerts attribute.
    /// </summary>
    public TerraformSet<string>? DisabledAlerts
    {
        get => GetArgument<TerraformSet<string>>("disabled_alerts");
        set => SetArgument("disabled_alerts", value);
    }

    /// <summary>
    /// The email_account_admins attribute.
    /// </summary>
    public TerraformValue<bool>? EmailAccountAdmins
    {
        get => GetArgument<TerraformValue<bool>>("email_account_admins");
        set => SetArgument("email_account_admins", value);
    }

    /// <summary>
    /// The email_addresses attribute.
    /// </summary>
    public TerraformSet<string>? EmailAddresses
    {
        get => GetArgument<TerraformSet<string>>("email_addresses");
        set => SetArgument("email_addresses", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionDays
    {
        get => GetArgument<TerraformValue<double>>("retention_days");
        set => SetArgument("retention_days", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    public required TerraformValue<string> ServerName
    {
        get => GetArgument<TerraformValue<string>>("server_name");
        set => SetArgument("server_name", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
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
    /// The storage_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StorageEndpoint
    {
        get => GetArgument<TerraformValue<string>>("storage_endpoint");
        set => SetArgument("storage_endpoint", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlServerSecurityAlertPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlServerSecurityAlertPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
