using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNetworkmanagerCustomerGatewayAssociation.
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerCustomerGatewayAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a aws_networkmanager_customer_gateway_association Terraform resource.
/// Manages a aws_networkmanager_customer_gateway_association resource.
/// </summary>
public partial class AwsNetworkmanagerCustomerGatewayAssociation(string name) : TerraformResource("aws_networkmanager_customer_gateway_association", name)
{
    /// <summary>
    /// The customer_gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerGatewayArn is required")]
    public required TerraformValue<string> CustomerGatewayArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("customer_gateway_arn");
        set => SetArgument("customer_gateway_arn", value);
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceId is required")]
    public required TerraformValue<string> DeviceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("device_id");
        set => SetArgument("device_id", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformValue<string> GlobalNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("global_network_id");
        set => SetArgument("global_network_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    public TerraformValue<string>? LinkId
    {
        get => GetArgument<TerraformValue<string>>("link_id");
        set => SetArgument("link_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkmanagerCustomerGatewayAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkmanagerCustomerGatewayAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
