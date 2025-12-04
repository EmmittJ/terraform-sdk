using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDxHostedTransitVirtualInterface.
/// Nesting mode: single
/// </summary>
public class AwsDxHostedTransitVirtualInterfaceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_dx_hosted_transit_virtual_interface Terraform resource.
/// Manages a aws_dx_hosted_transit_virtual_interface resource.
/// </summary>
public partial class AwsDxHostedTransitVirtualInterface(string name) : TerraformResource("aws_dx_hosted_transit_virtual_interface", name)
{
    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    public required TerraformValue<string> AddressFamily
    {
        get => GetArgument<TerraformValue<string>>("address_family");
        set => SetArgument("address_family", value);
    }

    /// <summary>
    /// The amazon_address attribute.
    /// </summary>
    public TerraformValue<string>? AmazonAddress
    {
        get => GetArgument<TerraformValue<string>>("amazon_address");
        set => SetArgument("amazon_address", value);
    }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BgpAsn is required")]
    public required TerraformValue<double> BgpAsn
    {
        get => GetArgument<TerraformValue<double>>("bgp_asn");
        set => SetArgument("bgp_asn", value);
    }

    /// <summary>
    /// The bgp_auth_key attribute.
    /// </summary>
    public TerraformValue<string>? BgpAuthKey
    {
        get => GetArgument<TerraformValue<string>>("bgp_auth_key");
        set => SetArgument("bgp_auth_key", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformValue<string> ConnectionId
    {
        get => GetArgument<TerraformValue<string>>("connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// The customer_address attribute.
    /// </summary>
    public TerraformValue<string>? CustomerAddress
    {
        get => GetArgument<TerraformValue<string>>("customer_address");
        set => SetArgument("customer_address", value);
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
    /// The mtu attribute.
    /// </summary>
    public TerraformValue<double>? Mtu
    {
        get => GetArgument<TerraformValue<double>>("mtu");
        set => SetArgument("mtu", value);
    }

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
    /// The owner_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerAccountId is required")]
    public required TerraformValue<string> OwnerAccountId
    {
        get => GetArgument<TerraformValue<string>>("owner_account_id");
        set => SetArgument("owner_account_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vlan is required")]
    public required TerraformValue<double> Vlan
    {
        get => GetArgument<TerraformValue<double>>("vlan");
        set => SetArgument("vlan", value);
    }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    public TerraformValue<string> AmazonSideAsn
        => AsReference("amazon_side_asn");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformValue<string> AwsDevice
        => AsReference("aws_device");

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    public TerraformValue<bool> JumboFrameCapable
        => AsReference("jumbo_frame_capable");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDxHostedTransitVirtualInterfaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDxHostedTransitVirtualInterfaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
