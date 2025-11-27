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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
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
        get => new TerraformReference<string>(this, "customer_gateway_arn");
        set => SetArgument("customer_gateway_arn", value);
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceId is required")]
    public required TerraformValue<string> DeviceId
    {
        get => new TerraformReference<string>(this, "device_id");
        set => SetArgument("device_id", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformValue<string> GlobalNetworkId
    {
        get => new TerraformReference<string>(this, "global_network_id");
        set => SetArgument("global_network_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    public TerraformValue<string>? LinkId
    {
        get => new TerraformReference<string>(this, "link_id");
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
