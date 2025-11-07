using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_security_admin_configuration resource.
/// </summary>
public class AzurermNetworkManagerSecurityAdminConfiguration : TerraformResource
{
    public AzurermNetworkManagerSecurityAdminConfiguration(string name) : base("azurerm_network_manager_security_admin_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The apply_on_network_intent_policy_based_services attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ApplyOnNetworkIntentPolicyBasedServices
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("apply_on_network_intent_policy_based_services");
        set => this.WithProperty("apply_on_network_intent_policy_based_services", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkManagerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_manager_id");
        set => this.WithProperty("network_manager_id", value);
    }

}
