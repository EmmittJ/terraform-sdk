using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_domain_name resource.
/// </summary>
public class AwsApiGatewayDomainName : TerraformResource
{
    public AwsApiGatewayDomainName(string name) : base("aws_api_gateway_domain_name", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("certificate_upload_date");
        this.DeclareOutput("cloudfront_domain_name");
        this.DeclareOutput("cloudfront_zone_id");
        this.DeclareOutput("domain_name_id");
        this.DeclareOutput("regional_domain_name");
        this.DeclareOutput("regional_zone_id");
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
    /// The certificate_body attribute.
    /// </summary>
    public string? CertificateBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_body")?.Value;
        set => this.WithProperty("certificate_body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public string? CertificateChain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_chain")?.Value;
        set => this.WithProperty("certificate_chain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    public string? CertificateName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_name")?.Value;
        set => this.WithProperty("certificate_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_private_key attribute.
    /// </summary>
    public string? CertificatePrivateKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_private_key")?.Value;
        set => this.WithProperty("certificate_private_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ownership_verification_certificate_arn attribute.
    /// </summary>
    public string? OwnershipVerificationCertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ownership_verification_certificate_arn")?.Value;
        set => this.WithProperty("ownership_verification_certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public string? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy")?.Value;
        set => this.WithProperty("policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The regional_certificate_arn attribute.
    /// </summary>
    public string? RegionalCertificateArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("regional_certificate_arn")?.Value;
        set => this.WithProperty("regional_certificate_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The regional_certificate_name attribute.
    /// </summary>
    public string? RegionalCertificateName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("regional_certificate_name")?.Value;
        set => this.WithProperty("regional_certificate_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    public string? SecurityPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_policy")?.Value;
        set => this.WithProperty("security_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

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
    /// The domain_name_id attribute.
    /// </summary>
    public TerraformExpression DomainNameId => this["domain_name_id"];

    /// <summary>
    /// The regional_domain_name attribute.
    /// </summary>
    public TerraformExpression RegionalDomainName => this["regional_domain_name"];

    /// <summary>
    /// The regional_zone_id attribute.
    /// </summary>
    public TerraformExpression RegionalZoneId => this["regional_zone_id"];

}
