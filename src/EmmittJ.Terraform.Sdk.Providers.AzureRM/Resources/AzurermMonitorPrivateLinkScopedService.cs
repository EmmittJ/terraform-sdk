using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_monitor_private_link_scoped_service resource.
/// </summary>
public class AzurermMonitorPrivateLinkScopedService : TerraformResource
{
    public AzurermMonitorPrivateLinkScopedService(string name) : base("azurerm_monitor_private_link_scoped_service", name)
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
    /// The linked_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? LinkedResourceId
    {
        get => GetProperty<TerraformProperty<string>>("linked_resource_id");
        set => this.WithProperty("linked_resource_id", value);
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
    /// The scope_name attribute.
    /// </summary>
    public TerraformProperty<string>? ScopeName
    {
        get => GetProperty<TerraformProperty<string>>("scope_name");
        set => this.WithProperty("scope_name", value);
    }

}
