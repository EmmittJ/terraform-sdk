using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerAdminRuleCollectionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_network_manager_admin_rule_collection resource.
/// </summary>
public class AzurermNetworkManagerAdminRuleCollection : TerraformResource
{
    public AzurermNetworkManagerAdminRuleCollection(string name) : base("azurerm_network_manager_admin_rule_collection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("network_group_ids");
        SetOutput("security_admin_configuration_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupIds is required")]
    public List<TerraformProperty<string>> NetworkGroupIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("network_group_ids");
        set => SetProperty("network_group_ids", value);
    }

    /// <summary>
    /// The security_admin_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityAdminConfigurationId is required")]
    public required TerraformProperty<string> SecurityAdminConfigurationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_admin_configuration_id");
        set => SetProperty("security_admin_configuration_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkManagerAdminRuleCollectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
