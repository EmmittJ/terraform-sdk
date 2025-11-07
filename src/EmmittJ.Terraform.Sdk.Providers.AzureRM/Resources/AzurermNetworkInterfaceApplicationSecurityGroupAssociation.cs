using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The application_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationSecurityGroupId
    {
        get => GetProperty<TerraformProperty<string>>("application_security_group_id");
        set => this.WithProperty("application_security_group_id", value);
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
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("network_interface_id");
        set => this.WithProperty("network_interface_id", value);
    }

}
