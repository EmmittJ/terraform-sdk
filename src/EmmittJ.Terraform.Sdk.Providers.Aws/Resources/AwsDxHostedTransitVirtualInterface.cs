using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_hosted_transit_virtual_interface resource.
/// </summary>
public class AwsDxHostedTransitVirtualInterface : TerraformResource
{
    public AwsDxHostedTransitVirtualInterface(string name) : base("aws_dx_hosted_transit_virtual_interface", name)
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
    public TerraformLiteralProperty<string>? AddressFamily
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_family");
        set => this.WithProperty("address_family", value);
    }

    /// <summary>
    /// The amazon_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AmazonAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("amazon_address");
        set => this.WithProperty("amazon_address", value);
    }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BgpAsn
    {
        get => GetProperty<TerraformLiteralProperty<double>>("bgp_asn");
        set => this.WithProperty("bgp_asn", value);
    }

    /// <summary>
    /// The bgp_auth_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BgpAuthKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bgp_auth_key");
        set => this.WithProperty("bgp_auth_key", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_id");
        set => this.WithProperty("connection_id", value);
    }

    /// <summary>
    /// The customer_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomerAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_address");
        set => this.WithProperty("customer_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Mtu
    {
        get => GetProperty<TerraformLiteralProperty<double>>("mtu");
        set => this.WithProperty("mtu", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OwnerAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_account_id");
        set => this.WithProperty("owner_account_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Vlan
    {
        get => GetProperty<TerraformLiteralProperty<double>>("vlan");
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
