using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSimDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("device_type");
        SetOutput("integrated_circuit_card_identifier");
        SetOutput("international_mobile_subscriber_identity");
        SetOutput("sim_policy_id");
        SetOutput("sim_state");
        SetOutput("static_ip_configuration");
        SetOutput("vendor_key_fingerprint");
        SetOutput("vendor_name");
        SetOutput("id");
        SetOutput("mobile_network_sim_group_id");
        SetOutput("name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The mobile_network_sim_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkSimGroupId is required")]
    public required TerraformProperty<string> MobileNetworkSimGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mobile_network_sim_group_id");
        set => SetProperty("mobile_network_sim_group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkSimDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
