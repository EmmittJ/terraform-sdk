using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDxBgpPeer.
/// Nesting mode: single
/// </summary>
public class AwsDxBgpPeerTimeoutsBlock : TerraformBlock
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
/// Represents a aws_dx_bgp_peer Terraform resource.
/// Manages a aws_dx_bgp_peer resource.
/// </summary>
public partial class AwsDxBgpPeer(string name) : TerraformResource("aws_dx_bgp_peer", name)
{
    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    public required TerraformValue<string> AddressFamily
    {
        get => new TerraformReference<string>(this, "address_family");
        set => SetArgument("address_family", value);
    }

    /// <summary>
    /// The amazon_address attribute.
    /// </summary>
    public TerraformValue<string> AmazonAddress
    {
        get => new TerraformReference<string>(this, "amazon_address");
        set => SetArgument("amazon_address", value);
    }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BgpAsn is required")]
    public required TerraformValue<double> BgpAsn
    {
        get => new TerraformReference<double>(this, "bgp_asn");
        set => SetArgument("bgp_asn", value);
    }

    /// <summary>
    /// The bgp_auth_key attribute.
    /// </summary>
    public TerraformValue<string> BgpAuthKey
    {
        get => new TerraformReference<string>(this, "bgp_auth_key");
        set => SetArgument("bgp_auth_key", value);
    }

    /// <summary>
    /// The customer_address attribute.
    /// </summary>
    public TerraformValue<string> CustomerAddress
    {
        get => new TerraformReference<string>(this, "customer_address");
        set => SetArgument("customer_address", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The virtual_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualInterfaceId is required")]
    public required TerraformValue<string> VirtualInterfaceId
    {
        get => new TerraformReference<string>(this, "virtual_interface_id");
        set => SetArgument("virtual_interface_id", value);
    }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformValue<string> AwsDevice
    {
        get => new TerraformReference<string>(this, "aws_device");
    }

    /// <summary>
    /// The bgp_peer_id attribute.
    /// </summary>
    public TerraformValue<string> BgpPeerId
    {
        get => new TerraformReference<string>(this, "bgp_peer_id");
    }

    /// <summary>
    /// The bgp_status attribute.
    /// </summary>
    public TerraformValue<string> BgpStatus
    {
        get => new TerraformReference<string>(this, "bgp_status");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDxBgpPeerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDxBgpPeerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
