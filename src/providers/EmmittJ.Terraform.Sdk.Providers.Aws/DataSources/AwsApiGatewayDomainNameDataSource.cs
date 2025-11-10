using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_domain_name.
/// </summary>
public class AwsApiGatewayDomainNameDataSource : TerraformDataSource
{
    public AwsApiGatewayDomainNameDataSource(string name) : base("aws_api_gateway_domain_name", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("certificate_arn");
        SetOutput("certificate_name");
        SetOutput("certificate_upload_date");
        SetOutput("cloudfront_domain_name");
        SetOutput("cloudfront_zone_id");
        SetOutput("endpoint_configuration");
        SetOutput("policy");
        SetOutput("regional_certificate_arn");
        SetOutput("regional_certificate_name");
        SetOutput("regional_domain_name");
        SetOutput("regional_zone_id");
        SetOutput("security_policy");
        SetOutput("domain_name");
        SetOutput("domain_name_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    public TerraformProperty<string> DomainNameId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name_id");
        set => SetProperty("domain_name_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformExpression CertificateArn => this["certificate_arn"];

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    public TerraformExpression CertificateName => this["certificate_name"];

    /// <summary>
    /// The certificate_upload_date attribute.
    /// </summary>
    public TerraformExpression CertificateUploadDate => this["certificate_upload_date"];

    /// <summary>
    /// The cloudfront_domain_name attribute.
    /// </summary>
    public TerraformExpression CloudfrontDomainName => this["cloudfront_domain_name"];

    /// <summary>
    /// The cloudfront_zone_id attribute.
    /// </summary>
    public TerraformExpression CloudfrontZoneId => this["cloudfront_zone_id"];

    /// <summary>
    /// The endpoint_configuration attribute.
    /// </summary>
    public TerraformExpression EndpointConfiguration => this["endpoint_configuration"];

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformExpression Policy => this["policy"];

    /// <summary>
    /// The regional_certificate_arn attribute.
    /// </summary>
    public TerraformExpression RegionalCertificateArn => this["regional_certificate_arn"];

    /// <summary>
    /// The regional_certificate_name attribute.
    /// </summary>
    public TerraformExpression RegionalCertificateName => this["regional_certificate_name"];

    /// <summary>
    /// The regional_domain_name attribute.
    /// </summary>
    public TerraformExpression RegionalDomainName => this["regional_domain_name"];

    /// <summary>
    /// The regional_zone_id attribute.
    /// </summary>
    public TerraformExpression RegionalZoneId => this["regional_zone_id"];

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    public TerraformExpression SecurityPolicy => this["security_policy"];

}
