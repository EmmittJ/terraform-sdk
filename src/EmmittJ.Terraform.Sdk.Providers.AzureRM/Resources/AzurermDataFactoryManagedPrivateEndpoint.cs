using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_managed_private_endpoint resource.
/// </summary>
public class AzurermDataFactoryManagedPrivateEndpoint : TerraformResource
{
    public AzurermDataFactoryManagedPrivateEndpoint(string name) : base("azurerm_data_factory_managed_private_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Fqdns
    {
        get => GetProperty<TerraformProperty<List<string>>>("fqdns");
        set => this.WithProperty("fqdns", value);
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
    /// The subresource_name attribute.
    /// </summary>
    public TerraformProperty<string>? SubresourceName
    {
        get => GetProperty<TerraformProperty<string>>("subresource_name");
        set => this.WithProperty("subresource_name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

}
