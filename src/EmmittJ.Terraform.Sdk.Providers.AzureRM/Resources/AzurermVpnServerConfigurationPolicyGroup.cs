using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_vpn_server_configuration_policy_group resource.
/// </summary>
public class AzurermVpnServerConfigurationPolicyGroup : TerraformResource
{
    public AzurermVpnServerConfigurationPolicyGroup(string name) : base("azurerm_vpn_server_configuration_policy_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IsDefault
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_default");
        set => this.WithProperty("is_default", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The vpn_server_configuration_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VpnServerConfigurationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_server_configuration_id");
        set => this.WithProperty("vpn_server_configuration_id", value);
    }

}
