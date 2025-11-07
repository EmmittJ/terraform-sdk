using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_mobile_network_sim.
/// </summary>
public class AzurermMobileNetworkSimDataSource : TerraformDataSource
{
    public AzurermMobileNetworkSimDataSource(string name) : base("azurerm_mobile_network_sim", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("device_type");
        this.DeclareOutput("integrated_circuit_card_identifier");
        this.DeclareOutput("international_mobile_subscriber_identity");
        this.DeclareOutput("sim_policy_id");
        this.DeclareOutput("sim_state");
        this.DeclareOutput("static_ip_configuration");
        this.DeclareOutput("vendor_key_fingerprint");
        this.DeclareOutput("vendor_name");
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
    /// The mobile_network_sim_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? MobileNetworkSimGroupId
    {
        get => GetProperty<TerraformProperty<string>>("mobile_network_sim_group_id");
        set => this.WithProperty("mobile_network_sim_group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    public TerraformExpression DeviceType => this["device_type"];

    /// <summary>
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    public TerraformExpression IntegratedCircuitCardIdentifier => this["integrated_circuit_card_identifier"];

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    public TerraformExpression InternationalMobileSubscriberIdentity => this["international_mobile_subscriber_identity"];

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    public TerraformExpression SimPolicyId => this["sim_policy_id"];

    /// <summary>
    /// The sim_state attribute.
    /// </summary>
    public TerraformExpression SimState => this["sim_state"];

    /// <summary>
    /// The static_ip_configuration attribute.
    /// </summary>
    public TerraformExpression StaticIpConfiguration => this["static_ip_configuration"];

    /// <summary>
    /// The vendor_key_fingerprint attribute.
    /// </summary>
    public TerraformExpression VendorKeyFingerprint => this["vendor_key_fingerprint"];

    /// <summary>
    /// The vendor_name attribute.
    /// </summary>
    public TerraformExpression VendorName => this["vendor_name"];

}
