using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerTransitGatewayConnectPeerAssociationTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a aws_networkmanager_transit_gateway_connect_peer_association resource.
/// </summary>
public class AwsNetworkmanagerTransitGatewayConnectPeerAssociation : TerraformResource
{
    public AwsNetworkmanagerTransitGatewayConnectPeerAssociation(string name) : base("aws_networkmanager_transit_gateway_connect_peer_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("device_id");
        SetOutput("global_network_id");
        SetOutput("id");
        SetOutput("link_id");
        SetOutput("transit_gateway_connect_peer_arn");
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceId is required")]
    public required TerraformProperty<string> DeviceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("device_id");
        set => SetProperty("device_id", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformProperty<string> GlobalNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_network_id");
        set => SetProperty("global_network_id", value);
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
    /// The link_id attribute.
    /// </summary>
    public TerraformProperty<string> LinkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("link_id");
        set => SetProperty("link_id", value);
    }

    /// <summary>
    /// The transit_gateway_connect_peer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayConnectPeerArn is required")]
    public required TerraformProperty<string> TransitGatewayConnectPeerArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_connect_peer_arn");
        set => SetProperty("transit_gateway_connect_peer_arn", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerTransitGatewayConnectPeerAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
