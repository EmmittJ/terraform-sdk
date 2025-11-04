using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_container_registry_token.
/// </summary>
public class AzurermContainerRegistryTokenDataSource : TerraformDataSource
{
    public AzurermContainerRegistryTokenDataSource(string name) : base("azurerm_container_registry_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("enabled");
        this.DeclareOutput("scope_map_id");
    }

    /// <summary>
    /// The container_registry_name attribute.
    /// </summary>
    public string? ContainerRegistryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_registry_name")?.Value;
        set => this.WithProperty("container_registry_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The scope_map_id attribute.
    /// </summary>
    public TerraformExpression ScopeMapId => this["scope_map_id"];

}
