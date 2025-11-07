using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_registry_token resource.
/// </summary>
public class AzurermContainerRegistryToken : TerraformResource
{
    public AzurermContainerRegistryToken(string name) : base("azurerm_container_registry_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The container_registry_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerRegistryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_registry_name");
        set => this.WithProperty("container_registry_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scope_map_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScopeMapId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope_map_id");
        set => this.WithProperty("scope_map_id", value);
    }

}
