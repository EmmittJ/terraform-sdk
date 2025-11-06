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
    public string? AuthenticationKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_key")?.Value;
        set => this.WithProperty("authentication_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    public string? DeviceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_type")?.Value;
        set => this.WithProperty("device_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    public string? IntegratedCircuitCardIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integrated_circuit_card_identifier")?.Value;
        set => this.WithProperty("integrated_circuit_card_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    public string? InternationalMobileSubscriberIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("international_mobile_subscriber_identity")?.Value;
        set => this.WithProperty("international_mobile_subscriber_identity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mobile_network_sim_group_id attribute.
    /// </summary>
    public string? MobileNetworkSimGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mobile_network_sim_group_id")?.Value;
        set => this.WithProperty("mobile_network_sim_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The operator_key_code attribute.
    /// </summary>
    public string? OperatorKeyCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("operator_key_code")?.Value;
        set => this.WithProperty("operator_key_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    public string? SimPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sim_policy_id")?.Value;
        set => this.WithProperty("sim_policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
