using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_subnet_network_security_group_association resource.
/// </summary>
public class AzurermSubnetNetworkSecurityGroupAssociation : TerraformResource
{
    public AzurermSubnetNetworkSecurityGroupAssociation(string name) : base("azurerm_subnet_network_security_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The network_security_group_id attribute.
    /// </summary>
    public string? NetworkSecurityGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_security_group_id")?.Value;
        set => this.WithProperty("network_security_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
