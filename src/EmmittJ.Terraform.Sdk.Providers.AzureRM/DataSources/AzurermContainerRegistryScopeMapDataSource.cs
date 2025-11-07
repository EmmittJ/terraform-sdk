using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_container_registry_scope_map.
/// </summary>
public class AzurermContainerRegistryScopeMapDataSource : TerraformDataSource
{
    public AzurermContainerRegistryScopeMapDataSource(string name) : base("azurerm_container_registry_scope_map", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("actions");
        this.DeclareOutput("description");
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

    /// <summary>
    /// The actions attribute.
    /// </summary>
    public TerraformExpression Actions => this["actions"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

}
