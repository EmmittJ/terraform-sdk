using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsVpnConnectionDataSource.
/// Nesting mode: set
/// </summary>
public class AwsVpnConnectionDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_vpn_connection Terraform data source.
/// Retrieves information about a aws_vpn_connection.
/// </summary>
public partial class AwsVpnConnectionDataSource(string name) : TerraformDataSource("aws_vpn_connection", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The vpn_connection_id attribute.
    /// </summary>
    public TerraformValue<string>? VpnConnectionId
    {
        get => GetArgument<TerraformValue<string>>("vpn_connection_id");
        set => SetArgument("vpn_connection_id", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    public TerraformValue<string> Category
        => AsReference("category");

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkArn
        => AsReference("core_network_arn");

    /// <summary>
    /// The core_network_attachment_arn attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkAttachmentArn
        => AsReference("core_network_attachment_arn");

    /// <summary>
    /// The customer_gateway_configuration attribute.
    /// </summary>
    public TerraformValue<string> CustomerGatewayConfiguration
        => AsReference("customer_gateway_configuration");

    /// <summary>
    /// The customer_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> CustomerGatewayId
        => AsReference("customer_gateway_id");

    /// <summary>
    /// The gateway_association_state attribute.
    /// </summary>
    public TerraformValue<string> GatewayAssociationState
        => AsReference("gateway_association_state");

    /// <summary>
    /// The pre_shared_key_arn attribute.
    /// </summary>
    public TerraformValue<string> PreSharedKeyArn
        => AsReference("pre_shared_key_arn");

    /// <summary>
    /// The routes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Routes
        => AsReference("routes");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayId
        => AsReference("transit_gateway_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// The vgw_telemetries attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VgwTelemetries
        => AsReference("vgw_telemetries");

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> VpnGatewayId
        => AsReference("vpn_gateway_id");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVpnConnectionDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsVpnConnectionDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
