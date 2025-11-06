using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_eip resource.
/// </summary>
public class AwsEip : TerraformResource
{
    public AwsEip(string name) : base("aws_eip", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allocation_id");
        this.DeclareOutput("arn");
        this.DeclareOutput("association_id");
        this.DeclareOutput("carrier_ip");
        this.DeclareOutput("customer_owned_ip");
        this.DeclareOutput("private_dns");
        this.DeclareOutput("private_ip");
        this.DeclareOutput("ptr_record");
        this.DeclareOutput("public_dns");
        this.DeclareOutput("public_ip");
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public string? Address
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address")?.Value;
        set => this.WithProperty("address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The associate_with_private_ip attribute.
    /// </summary>
    public string? AssociateWithPrivateIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("associate_with_private_ip")?.Value;
        set => this.WithProperty("associate_with_private_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public string? CustomerOwnedIpv4Pool
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_owned_ipv4_pool")?.Value;
        set => this.WithProperty("customer_owned_ipv4_pool", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The instance attribute.
    /// </summary>
    public string? Instance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance")?.Value;
        set => this.WithProperty("instance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    public string? IpamPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipam_pool_id")?.Value;
        set => this.WithProperty("ipam_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    public string? NetworkBorderGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_border_group")?.Value;
        set => this.WithProperty("network_border_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public string? NetworkInterface
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface")?.Value;
        set => this.WithProperty("network_interface", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_ipv4_pool attribute.
    /// </summary>
    public string? PublicIpv4Pool
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ipv4_pool")?.Value;
        set => this.WithProperty("public_ipv4_pool", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformExpression AllocationId => this["allocation_id"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

    /// <summary>
    /// The carrier_ip attribute.
    /// </summary>
    public TerraformExpression CarrierIp => this["carrier_ip"];

    /// <summary>
    /// The customer_owned_ip attribute.
    /// </summary>
    public TerraformExpression CustomerOwnedIp => this["customer_owned_ip"];

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformExpression PrivateDns => this["private_dns"];

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformExpression PrivateIp => this["private_ip"];

    /// <summary>
    /// The ptr_record attribute.
    /// </summary>
    public TerraformExpression PtrRecord => this["ptr_record"];

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    public TerraformExpression PublicDns => this["public_dns"];

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformExpression PublicIp => this["public_ip"];

}
