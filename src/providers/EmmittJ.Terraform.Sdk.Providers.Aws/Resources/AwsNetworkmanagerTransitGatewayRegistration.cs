using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerTransitGatewayRegistrationTimeoutsBlock : TerraformBlock
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
/// Manages a aws_networkmanager_transit_gateway_registration resource.
/// </summary>
public class AwsNetworkmanagerTransitGatewayRegistration : TerraformResource
{
    public AwsNetworkmanagerTransitGatewayRegistration(string name) : base("aws_networkmanager_transit_gateway_registration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("global_network_id");
        SetOutput("id");
        SetOutput("transit_gateway_arn");
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
    /// The transit_gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayArn is required")]
    public required TerraformProperty<string> TransitGatewayArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_arn");
        set => SetProperty("transit_gateway_arn", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerTransitGatewayRegistrationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
