using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_hosted_public_virtual_interface resource.
/// </summary>
public class AwsDxHostedPublicVirtualInterface : TerraformResource
{
    public AwsDxHostedPublicVirtualInterface(string name) : base("aws_dx_hosted_public_virtual_interface", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("amazon_side_asn");
        this.DeclareOutput("arn");
        this.DeclareOutput("aws_device");
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    public string? AddressFamily
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_family")?.Value;
        set => this.WithProperty("address_family", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The amazon_address attribute.
    /// </summary>
    public string? AmazonAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("amazon_address")?.Value;
        set => this.WithProperty("amazon_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    public double? BgpAsn
    {
        get => GetProperty<TerraformLiteralProperty<double>>("bgp_asn")?.Value;
        set => this.WithProperty("bgp_asn", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The bgp_auth_key attribute.
    /// </summary>
    public string? BgpAuthKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bgp_auth_key")?.Value;
        set => this.WithProperty("bgp_auth_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    public string? ConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_id")?.Value;
        set => this.WithProperty("connection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_address attribute.
    /// </summary>
    public string? CustomerAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_address")?.Value;
        set => this.WithProperty("customer_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public string? OwnerAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_account_id")?.Value;
        set => this.WithProperty("owner_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The route_filter_prefixes attribute.
    /// </summary>
    public HashSet<string>? RouteFilterPrefixes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("route_filter_prefixes")?.Value;
        set => this.WithProperty("route_filter_prefixes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    public double? Vlan
    {
        get => GetProperty<TerraformLiteralProperty<double>>("vlan")?.Value;
        set => this.WithProperty("vlan", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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

}
