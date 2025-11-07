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
    public TerraformLiteralProperty<string>? AuthenticationKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_key");
        set => this.WithProperty("authentication_key", value);
    }

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeviceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_type");
        set => this.WithProperty("device_type", value);
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
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IntegratedCircuitCardIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integrated_circuit_card_identifier");
        set => this.WithProperty("integrated_circuit_card_identifier", value);
    }

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InternationalMobileSubscriberIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("international_mobile_subscriber_identity");
        set => this.WithProperty("international_mobile_subscriber_identity", value);
    }

    /// <summary>
    /// The mobile_network_sim_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MobileNetworkSimGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mobile_network_sim_group_id");
        set => this.WithProperty("mobile_network_sim_group_id", value);
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
    /// The operator_key_code attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OperatorKeyCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("operator_key_code");
        set => this.WithProperty("operator_key_code", value);
    }

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SimPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sim_policy_id");
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
