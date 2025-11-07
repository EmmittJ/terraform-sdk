using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_postgresql_virtual_network_rule resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermPostgresqlVirtualNetworkRule : TerraformResource
{
    public AzurermPostgresqlVirtualNetworkRule(string name) : base("azurerm_postgresql_virtual_network_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The ignore_missing_vnet_service_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool>? IgnoreMissingVnetServiceEndpoint
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_missing_vnet_service_endpoint");
        set => this.WithProperty("ignore_missing_vnet_service_endpoint", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public TerraformProperty<string>? ServerName
    {
        get => GetProperty<TerraformProperty<string>>("server_name");
        set => this.WithProperty("server_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

}
