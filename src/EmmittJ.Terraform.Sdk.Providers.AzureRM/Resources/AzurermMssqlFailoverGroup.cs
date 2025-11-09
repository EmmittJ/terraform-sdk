using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_failover_group resource.
/// </summary>
public class AzurermMssqlFailoverGroup : TerraformResource
{
    public AzurermMssqlFailoverGroup(string name) : base("azurerm_mssql_failover_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The databases attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Databases
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("databases");
        set => this.WithProperty("databases", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ReadonlyEndpointFailoverPolicyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("readonly_endpoint_failover_policy_enabled");
        set => this.WithProperty("readonly_endpoint_failover_policy_enabled", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServerId
    {
        get => GetProperty<TerraformProperty<string>>("server_id");
        set => this.WithProperty("server_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
