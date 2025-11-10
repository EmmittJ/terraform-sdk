using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDxPrivateVirtualInterfaceTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_dx_private_virtual_interface resource.
/// </summary>
public class AwsDxPrivateVirtualInterface : TerraformResource
{
    public AwsDxPrivateVirtualInterface(string name) : base("aws_dx_private_virtual_interface", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("amazon_side_asn");
        SetOutput("arn");
        SetOutput("aws_device");
        SetOutput("jumbo_frame_capable");
        SetOutput("address_family");
        SetOutput("amazon_address");
        SetOutput("bgp_asn");
        SetOutput("bgp_auth_key");
        SetOutput("connection_id");
        SetOutput("customer_address");
        SetOutput("dx_gateway_id");
        SetOutput("id");
        SetOutput("mtu");
        SetOutput("name");
        SetOutput("region");
        SetOutput("sitelink_enabled");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("vlan");
        SetOutput("vpn_gateway_id");
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    public required TerraformProperty<string> AddressFamily
    {
        get => GetRequiredOutput<TerraformProperty<string>>("address_family");
        set => SetProperty("address_family", value);
    }

    /// <summary>
    /// The amazon_address attribute.
    /// </summary>
    public TerraformProperty<string> AmazonAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("amazon_address");
        set => SetProperty("amazon_address", value);
    }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BgpAsn is required")]
    public required TerraformProperty<double> BgpAsn
    {
        get => GetRequiredOutput<TerraformProperty<double>>("bgp_asn");
        set => SetProperty("bgp_asn", value);
    }

    /// <summary>
    /// The bgp_auth_key attribute.
    /// </summary>
    public TerraformProperty<string> BgpAuthKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bgp_auth_key");
        set => SetProperty("bgp_auth_key", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    public required TerraformProperty<string> ConnectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_id");
        set => SetProperty("connection_id", value);
    }

    /// <summary>
    /// The customer_address attribute.
    /// </summary>
    public TerraformProperty<string> CustomerAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_address");
        set => SetProperty("customer_address", value);
    }

    /// <summary>
    /// The dx_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> DxGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dx_gateway_id");
        set => SetProperty("dx_gateway_id", value);
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
    /// The mtu attribute.
    /// </summary>
    public TerraformProperty<double> Mtu
    {
        get => GetRequiredOutput<TerraformProperty<double>>("mtu");
        set => SetProperty("mtu", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The sitelink_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SitelinkEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sitelink_enabled");
        set => SetProperty("sitelink_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vlan is required")]
    public required TerraformProperty<double> Vlan
    {
        get => GetRequiredOutput<TerraformProperty<double>>("vlan");
        set => SetProperty("vlan", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> VpnGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpn_gateway_id");
        set => SetProperty("vpn_gateway_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDxPrivateVirtualInterfaceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    public TerraformExpression AmazonSideAsn => this["amazon_side_asn"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformExpression AwsDevice => this["aws_device"];

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    public TerraformExpression JumboFrameCapable => this["jumbo_frame_capable"];

}
