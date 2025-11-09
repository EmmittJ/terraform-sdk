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
        this.DeclareOutput("arn");
        this.DeclareOutput("certificate_arn");
        this.DeclareOutput("certificate_name");
        this.DeclareOutput("certificate_upload_date");
        this.DeclareOutput("cloudfront_domain_name");
        this.DeclareOutput("cloudfront_zone_id");
        this.DeclareOutput("endpoint_configuration");
        this.DeclareOutput("policy");
        this.DeclareOutput("regional_certificate_arn");
        this.DeclareOutput("regional_certificate_name");
        this.DeclareOutput("regional_domain_name");
        this.DeclareOutput("regional_zone_id");
        this.DeclareOutput("security_policy");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    public TerraformProperty<string>? DomainNameId
    {
        get => GetProperty<TerraformProperty<string>>("domain_name_id");
        set => this.WithProperty("domain_name_id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
