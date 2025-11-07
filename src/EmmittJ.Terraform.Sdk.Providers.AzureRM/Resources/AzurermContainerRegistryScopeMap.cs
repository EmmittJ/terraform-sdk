using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_registry_scope_map resource.
/// </summary>
public class AzurermContainerRegistryScopeMap : TerraformResource
{
    public AzurermContainerRegistryScopeMap(string name) : base("azurerm_container_registry_scope_map", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The actions attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Actions
    {
        get => GetProperty<TerraformProperty<List<string>>>("actions");
        set => this.WithProperty("actions", value);
    }

    /// <summary>
    /// The container_registry_name attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerRegistryName
    {
        get => GetProperty<TerraformProperty<string>>("container_registry_name");
        set => this.WithProperty("container_registry_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
