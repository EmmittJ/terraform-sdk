using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNetworkmanagerTransitGatewayRegistration.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerTransitGatewayRegistrationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_networkmanager_transit_gateway_registration Terraform resource.
/// Manages a aws_networkmanager_transit_gateway_registration resource.
/// </summary>
public partial class AwsNetworkmanagerTransitGatewayRegistration(string name) : TerraformResource("aws_networkmanager_transit_gateway_registration", name)
{
    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformValue<string> GlobalNetworkId
    {
        get => GetArgument<TerraformValue<string>>("global_network_id");
        set => SetArgument("global_network_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The transit_gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayArn is required")]
    public required TerraformValue<string> TransitGatewayArn
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_arn");
        set => SetArgument("transit_gateway_arn", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerTransitGatewayRegistrationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerTransitGatewayRegistrationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
