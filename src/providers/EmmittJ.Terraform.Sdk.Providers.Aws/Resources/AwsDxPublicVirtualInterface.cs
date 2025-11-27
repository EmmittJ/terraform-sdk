using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDxPublicVirtualInterface.
/// Nesting mode: single
/// </summary>
public class AwsDxPublicVirtualInterfaceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_dx_public_virtual_interface Terraform resource.
/// Manages a aws_dx_public_virtual_interface resource.
/// </summary>
public partial class AwsDxPublicVirtualInterface(string name) : TerraformResource("aws_dx_public_virtual_interface", name)
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
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformValue<string> ConnectionId
    {
        get => new TerraformReference<string>(this, "connection_id");
        set => SetArgument("connection_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The route_filter_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteFilterPrefixes is required")]
    public required TerraformSet<string> RouteFilterPrefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "route_filter_prefixes").ResolveNodes(ctx));
        set => SetArgument("route_filter_prefixes", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vlan is required")]
    public required TerraformValue<double> Vlan
    {
        get => new TerraformReference<double>(this, "vlan");
        set => SetArgument("vlan", value);
    }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    public TerraformValue<string> AmazonSideAsn
    {
        get => new TerraformReference<string>(this, "amazon_side_asn");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformValue<string> AwsDevice
    {
        get => new TerraformReference<string>(this, "aws_device");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDxPublicVirtualInterfaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDxPublicVirtualInterfaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
