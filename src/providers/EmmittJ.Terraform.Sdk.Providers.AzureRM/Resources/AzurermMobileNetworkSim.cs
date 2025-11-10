using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for static_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkSimStaticIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The attached_data_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachedDataNetworkId is required")]
    public required TerraformProperty<string> AttachedDataNetworkId
    {
        set => SetProperty("attached_data_network_id", value);
    }

    /// <summary>
    /// The slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceId is required")]
    public required TerraformProperty<string> SliceId
    {
        set => SetProperty("slice_id", value);
    }

    /// <summary>
    /// The static_ipv4_address attribute.
    /// </summary>
    public TerraformProperty<string>? StaticIpv4Address
    {
        set => SetProperty("static_ipv4_address", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkSimTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("sim_state");
        SetOutput("vendor_key_fingerprint");
        SetOutput("vendor_name");
        SetOutput("authentication_key");
        SetOutput("device_type");
        SetOutput("id");
        SetOutput("integrated_circuit_card_identifier");
        SetOutput("international_mobile_subscriber_identity");
        SetOutput("mobile_network_sim_group_id");
        SetOutput("name");
        SetOutput("operator_key_code");
        SetOutput("sim_policy_id");
    }

    /// <summary>
    /// The authentication_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationKey is required")]
    public required TerraformProperty<string> AuthenticationKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_key");
        set => SetProperty("authentication_key", value);
    }

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    public TerraformProperty<string> DeviceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("device_type");
        set => SetProperty("device_type", value);
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
    /// The integrated_circuit_card_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegratedCircuitCardIdentifier is required")]
    public required TerraformProperty<string> IntegratedCircuitCardIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integrated_circuit_card_identifier");
        set => SetProperty("integrated_circuit_card_identifier", value);
    }

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InternationalMobileSubscriberIdentity is required")]
    public required TerraformProperty<string> InternationalMobileSubscriberIdentity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("international_mobile_subscriber_identity");
        set => SetProperty("international_mobile_subscriber_identity", value);
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
    /// The operator_key_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorKeyCode is required")]
    public required TerraformProperty<string> OperatorKeyCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("operator_key_code");
        set => SetProperty("operator_key_code", value);
    }

    /// <summary>
    /// The sim_policy_id attribute.
    /// </summary>
    public TerraformProperty<string> SimPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sim_policy_id");
        set => SetProperty("sim_policy_id", value);
    }

    /// <summary>
    /// Block for static_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMobileNetworkSimStaticIpConfigurationBlock>? StaticIpConfiguration
    {
        set => SetProperty("static_ip_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkSimTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
