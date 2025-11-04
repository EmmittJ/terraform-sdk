using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_customer_gateway.
/// </summary>
public class AwsCustomerGatewayDataSource : TerraformDataSource
{
    public AwsCustomerGatewayDataSource(string name) : base("aws_customer_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("bgp_asn");
        this.DeclareOutput("bgp_asn_extended");
        this.DeclareOutput("certificate_arn");
        this.DeclareOutput("device_name");
        this.DeclareOutput("ip_address");
        this.DeclareOutput("type");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    public TerraformExpression BgpAsn => this["bgp_asn"];

    /// <summary>
    /// The bgp_asn_extended attribute.
    /// </summary>
    public TerraformExpression BgpAsnExtended => this["bgp_asn_extended"];

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformExpression CertificateArn => this["certificate_arn"];

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformExpression DeviceName => this["device_name"];

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
