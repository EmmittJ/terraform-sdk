using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("aws_device");
        this.DeclareOutput("bgp_peer_id");
        this.DeclareOutput("bgp_status");
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    public TerraformProperty<string>? AddressFamily
    {
        get => GetProperty<TerraformProperty<string>>("address_family");
        set => this.WithProperty("address_family", value);
    }

    /// <summary>
    /// The amazon_address attribute.
    /// </summary>
    public TerraformProperty<string>? AmazonAddress
    {
        get => GetProperty<TerraformProperty<string>>("amazon_address");
        set => this.WithProperty("amazon_address", value);
    }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    public TerraformProperty<double>? BgpAsn
    {
        get => GetProperty<TerraformProperty<double>>("bgp_asn");
        set => this.WithProperty("bgp_asn", value);
    }

    /// <summary>
    /// The bgp_auth_key attribute.
    /// </summary>
    public TerraformProperty<string>? BgpAuthKey
    {
        get => GetProperty<TerraformProperty<string>>("bgp_auth_key");
        set => this.WithProperty("bgp_auth_key", value);
    }

    /// <summary>
    /// The customer_address attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerAddress
    {
        get => GetProperty<TerraformProperty<string>>("customer_address");
        set => this.WithProperty("customer_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The virtual_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_interface_id");
        set => this.WithProperty("virtual_interface_id", value);
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
