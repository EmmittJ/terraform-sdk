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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public bool? IsDefault
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_default")?.Value;
        set => this.WithProperty("is_default", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The vpn_server_configuration_id attribute.
    /// </summary>
    public string? VpnServerConfigurationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_server_configuration_id")?.Value;
        set => this.WithProperty("vpn_server_configuration_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
