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
    public string? ApplicationSecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_security_group_id")?.Value;
        set => this.WithProperty("application_security_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The network_interface_id attribute.
    /// </summary>
    public string? NetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface_id")?.Value;
        set => this.WithProperty("network_interface_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
