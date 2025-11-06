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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The linked_resource_id attribute.
    /// </summary>
    public string? LinkedResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("linked_resource_id")?.Value;
        set => this.WithProperty("linked_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scope_name attribute.
    /// </summary>
    public string? ScopeName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope_name")?.Value;
        set => this.WithProperty("scope_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
