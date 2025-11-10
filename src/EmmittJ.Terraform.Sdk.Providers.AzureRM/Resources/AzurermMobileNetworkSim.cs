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
        get => GetRequiredProperty<TerraformProperty<string>>("attached_data_network_id");
        set => WithProperty("attached_data_network_id", value);
    }

    /// <summary>
    /// The slice_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SliceId is required")]
    public required TerraformProperty<string> SliceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("slice_id");
        set => WithProperty("slice_id", value);
    }

    /// <summary>
    /// The static_ipv4_address attribute.
    /// </summary>
    public TerraformProperty<string>? StaticIpv4Address
    {
        get => GetProperty<TerraformProperty<string>>("static_ipv4_address");
        set => WithProperty("static_ipv4_address", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.DeclareOutput("sim_state");
        this.DeclareOutput("vendor_key_fingerprint");
        this.DeclareOutput("vendor_name");
    }

    /// <summary>
    /// The authentication_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationKey is required")]
    public required TerraformProperty<string> AuthenticationKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("authentication_key");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegratedCircuitCardIdentifier is required")]
    public required TerraformProperty<string> IntegratedCircuitCardIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("integrated_circuit_card_identifier");
        set => this.WithProperty("integrated_circuit_card_identifier", value);
    }

    /// <summary>
    /// The international_mobile_subscriber_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InternationalMobileSubscriberIdentity is required")]
    public required TerraformProperty<string> InternationalMobileSubscriberIdentity
    {
        get => GetRequiredProperty<TerraformProperty<string>>("international_mobile_subscriber_identity");
        set => this.WithProperty("international_mobile_subscriber_identity", value);
    }

    /// <summary>
    /// The mobile_network_sim_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkSimGroupId is required")]
    public required TerraformProperty<string> MobileNetworkSimGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("mobile_network_sim_group_id");
        set => this.WithProperty("mobile_network_sim_group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The operator_key_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorKeyCode is required")]
    public required TerraformProperty<string> OperatorKeyCode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("operator_key_code");
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
    /// Block for static_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMobileNetworkSimStaticIpConfigurationBlock>? StaticIpConfiguration
    {
        get => GetProperty<List<AzurermMobileNetworkSimStaticIpConfigurationBlock>>("static_ip_configuration");
        set => this.WithProperty("static_ip_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkSimTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMobileNetworkSimTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
