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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("configuration_ids");
        SetOutput("id");
        SetOutput("location");
        SetOutput("network_manager_id");
        SetOutput("scope_access");
        SetOutput("triggers");
    }

    /// <summary>
    /// The configuration_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationIds is required")]
    public List<TerraformProperty<string>> ConfigurationIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("configuration_ids");
        set => SetProperty("configuration_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    public required TerraformProperty<string> NetworkManagerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_manager_id");
        set => SetProperty("network_manager_id", value);
    }

    /// <summary>
    /// The scope_access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeAccess is required")]
    public required TerraformProperty<string> ScopeAccess
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope_access");
        set => SetProperty("scope_access", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Triggers
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("triggers");
        set => SetProperty("triggers", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkManagerDeploymentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
