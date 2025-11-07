using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mobile_network_sim resource.
/// </summary>
public class AzurermMobileNetworkSim : TerraformResource
{
    public AzurermMobileNetworkSim(string name) : base("azurerm_mobile_network_sim", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("sim_state");
        this.DeclareOutput("vendor_key_fingerprint");
        this.DeclareOutput("vendor_name");
    }

    /// <summary>
    /// The authentication_key attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationKey
    {
        get => GetProperty<TerraformProperty<string>>("authentication_key");
        set => this.WithProperty("authentication_key", value);
    }

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceType
    {
        get => GetProperty<TerraformProperty<string>>("device_type");
        set => this.WithProperty("device_type", value);
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
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? IntegratedCircuitCardIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("integrated_circuit_card_identifier");
        set => this.WithProperty("integrated_circuit_card_identifier", value);
    }

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    public TerraformProperty<string>? InternationalMobileSubscriberIdentity
    {
        get => GetProperty<TerraformProperty<string>>("international_mobile_subscriber_identity");
        set => this.WithProperty("international_mobile_subscriber_identity", value);
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
    /// The operator_key_code attribute.
    /// </summary>
    public TerraformProperty<string>? OperatorKeyCode
    {
        get => GetProperty<TerraformProperty<string>>("operator_key_code");
        set => this.WithProperty("operator_key_code", value);
    }

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? SimPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("sim_policy_id");
        set => this.WithProperty("sim_policy_id", value);
    }

    /// <summary>
    /// The sim_state attribute.
    /// </summary>
    public TerraformExpression SimState => this["sim_state"];

    /// <summary>
    /// The vendor_key_fingerprint attribute.
    /// </summary>
    public TerraformExpression VendorKeyFingerprint => this["vendor_key_fingerprint"];

    /// <summary>
    /// The vendor_name attribute.
    /// </summary>
    public TerraformExpression VendorName => this["vendor_name"];

}
