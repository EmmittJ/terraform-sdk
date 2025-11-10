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
        SetOutput("arn");
        SetOutput("bgp_asn");
        SetOutput("bgp_asn_extended");
        SetOutput("certificate_arn");
        SetOutput("device_name");
        SetOutput("id");
        SetOutput("ip_address");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
    }

    /// <summary>
    /// The bgp_asn attribute.
    /// </summary>
    public TerraformProperty<string> BgpAsn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bgp_asn");
        set => SetProperty("bgp_asn", value);
    }

    /// <summary>
    /// The bgp_asn_extended attribute.
    /// </summary>
    public TerraformProperty<string> BgpAsnExtended
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bgp_asn_extended");
        set => SetProperty("bgp_asn_extended", value);
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string> CertificateArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_arn");
        set => SetProperty("certificate_arn", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformProperty<string> DeviceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("device_name");
        set => SetProperty("device_name", value);
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
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string> IpAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address");
        set => SetProperty("ip_address", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
