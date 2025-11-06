using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_customer_gateway resource.
/// </summary>
public class AwsCustomerGateway : TerraformResource
{
    public AwsCustomerGateway(string name) : base("aws_customer_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    public string? BgpAsn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bgp_asn")?.Value;
        set => this.WithProperty("bgp_asn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bgp_asn_extended attribute.
    /// </summary>
    public string? BgpAsnExtended
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bgp_asn_extended")?.Value;
        set => this.WithProperty("bgp_asn_extended", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public string? CertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_arn")?.Value;
        set => this.WithProperty("certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public string? DeviceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_name")?.Value;
        set => this.WithProperty("device_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ip_address attribute.
    /// </summary>
    public string? IpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address")?.Value;
        set => this.WithProperty("ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
