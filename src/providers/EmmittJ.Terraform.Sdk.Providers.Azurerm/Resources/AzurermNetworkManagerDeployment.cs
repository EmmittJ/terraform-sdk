using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkManagerDeployment.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerDeploymentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_network_manager_deployment Terraform resource.
/// Manages a azurerm_network_manager_deployment resource.
/// </summary>
public partial class AzurermNetworkManagerDeployment(string name) : TerraformResource("azurerm_network_manager_deployment", name)
{
    /// <summary>
    /// The configuration_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationIds is required")]
    public TerraformList<string>? ConfigurationIds
    {
        get => GetArgument<TerraformList<string>>("configuration_ids");
        set => SetArgument("configuration_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    public required TerraformValue<string> NetworkManagerId
    {
        get => GetArgument<TerraformValue<string>>("network_manager_id");
        set => SetArgument("network_manager_id", value);
    }

    /// <summary>
    /// The scope_access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeAccess is required")]
    public required TerraformValue<string> ScopeAccess
    {
        get => GetArgument<TerraformValue<string>>("scope_access");
        set => SetArgument("scope_access", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformMap<string>? Triggers
    {
        get => GetArgument<TerraformMap<string>>("triggers");
        set => SetArgument("triggers", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkManagerDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkManagerDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
