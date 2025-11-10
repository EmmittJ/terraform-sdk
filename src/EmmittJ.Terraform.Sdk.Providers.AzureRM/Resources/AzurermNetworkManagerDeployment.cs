using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerDeploymentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationIds is required")]
    public List<TerraformProperty<string>>? ConfigurationIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("configuration_ids");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    public required TerraformProperty<string> NetworkManagerId
    {
        get => GetProperty<TerraformProperty<string>>("network_manager_id");
        set => this.WithProperty("network_manager_id", value);
    }

    /// <summary>
    /// The scope_access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeAccess is required")]
    public required TerraformProperty<string> ScopeAccess
    {
        get => GetProperty<TerraformProperty<string>>("scope_access");
        set => this.WithProperty("scope_access", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Triggers
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("triggers");
        set => this.WithProperty("triggers", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkManagerDeploymentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkManagerDeploymentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
