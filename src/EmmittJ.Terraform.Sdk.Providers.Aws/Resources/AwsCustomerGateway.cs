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
    public TerraformProperty<string>? BgpAsn
    {
        get => GetProperty<TerraformProperty<string>>("bgp_asn");
        set => this.WithProperty("bgp_asn", value);
    }

    /// <summary>
    /// The bgp_asn_extended attribute.
    /// </summary>
    public TerraformProperty<string>? BgpAsnExtended
    {
        get => GetProperty<TerraformProperty<string>>("bgp_asn_extended");
        set => this.WithProperty("bgp_asn_extended", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("certificate_arn");
        set => this.WithProperty("certificate_arn", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => this.WithProperty("device_name", value);
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
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        get => GetProperty<TerraformProperty<string>>("ip_address");
        set => this.WithProperty("ip_address", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
