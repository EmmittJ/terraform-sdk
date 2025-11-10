using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkInterfaceApplicationSecurityGroupAssociationTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_network_interface_application_security_group_association resource.
/// </summary>
public class AzurermNetworkInterfaceApplicationSecurityGroupAssociation : TerraformResource
{
    public AzurermNetworkInterfaceApplicationSecurityGroupAssociation(string name) : base("azurerm_network_interface_application_security_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_security_group_id");
        SetOutput("id");
        SetOutput("network_interface_id");
    }

    /// <summary>
    /// The application_security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationSecurityGroupId is required")]
    public required TerraformProperty<string> ApplicationSecurityGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_security_group_id");
        set => SetProperty("application_security_group_id", value);
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
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformProperty<string> NetworkInterfaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_interface_id");
        set => SetProperty("network_interface_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkInterfaceApplicationSecurityGroupAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
