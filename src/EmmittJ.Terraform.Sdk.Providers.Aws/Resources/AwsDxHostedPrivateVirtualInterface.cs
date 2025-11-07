using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_hosted_private_virtual_interface resource.
/// </summary>
public class AwsDxHostedPrivateVirtualInterface : TerraformResource
{
    public AwsDxHostedPrivateVirtualInterface(string name) : base("aws_dx_hosted_private_virtual_interface", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("amazon_side_asn");
        this.DeclareOutput("arn");
        this.DeclareOutput("aws_device");
        this.DeclareOutput("jumbo_frame_capable");
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
    /// The connection_id attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionId
    {
        get => GetProperty<TerraformProperty<string>>("connection_id");
        set => this.WithProperty("connection_id", value);
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
    /// The mtu attribute.
    /// </summary>
    public TerraformProperty<double>? Mtu
    {
        get => GetProperty<TerraformProperty<double>>("mtu");
        set => this.WithProperty("mtu", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? OwnerAccountId
    {
        get => GetProperty<TerraformProperty<string>>("owner_account_id");
        set => this.WithProperty("owner_account_id", value);
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
    /// The vlan attribute.
    /// </summary>
    public TerraformProperty<double>? Vlan
    {
        get => GetProperty<TerraformProperty<double>>("vlan");
        set => this.WithProperty("vlan", value);
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
