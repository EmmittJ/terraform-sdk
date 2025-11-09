using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_deployment resource.
/// </summary>
public class AzurermNetworkManagerDeployment : TerraformResource
{
    public AzurermNetworkManagerDeployment(string name) : base("azurerm_network_manager_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The configuration_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ConfigurationIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("configuration_ids");
        set => this.WithProperty("configuration_ids", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkManagerId
    {
        get => GetProperty<TerraformProperty<string>>("network_manager_id");
        set => this.WithProperty("network_manager_id", value);
    }

    /// <summary>
    /// The scope_access attribute.
    /// </summary>
    public TerraformProperty<string>? ScopeAccess
    {
        get => GetProperty<TerraformProperty<string>>("scope_access");
        set => this.WithProperty("scope_access", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformMapProperty<string>? Triggers
    {
        get => GetProperty<TerraformMapProperty<string>>("triggers");
        set => this.WithProperty("triggers", value);
    }

}
