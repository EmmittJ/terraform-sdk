using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDxBgpPeerTimeoutsBlock : TerraformBlock
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
/// Manages a aws_dx_bgp_peer resource.
/// </summary>
public class AwsDxBgpPeer : TerraformResource
{
    public AwsDxBgpPeer(string name) : base("aws_dx_bgp_peer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("aws_device");
        SetOutput("bgp_peer_id");
        SetOutput("bgp_status");
        SetOutput("address_family");
        SetOutput("amazon_address");
        SetOutput("bgp_asn");
        SetOutput("bgp_auth_key");
        SetOutput("customer_address");
        SetOutput("id");
        SetOutput("region");
        SetOutput("virtual_interface_id");
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
    /// The customer_address attribute.
    /// </summary>
    public TerraformProperty<string> CustomerAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_address");
        set => SetProperty("customer_address", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The virtual_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualInterfaceId is required")]
    public required TerraformProperty<string> VirtualInterfaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_interface_id");
        set => SetProperty("virtual_interface_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDxBgpPeerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformExpression AwsDevice => this["aws_device"];

    /// <summary>
    /// The bgp_peer_id attribute.
    /// </summary>
    public TerraformExpression BgpPeerId => this["bgp_peer_id"];

    /// <summary>
    /// The bgp_status attribute.
    /// </summary>
    public TerraformExpression BgpStatus => this["bgp_status"];

}
