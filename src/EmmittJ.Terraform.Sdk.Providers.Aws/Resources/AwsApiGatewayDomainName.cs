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
    public TerraformProperty<string>? CertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("certificate_arn");
        set => this.WithProperty("certificate_arn", value);
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateBody
    {
        get => GetProperty<TerraformProperty<string>>("certificate_body");
        set => this.WithProperty("certificate_body", value);
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateChain
    {
        get => GetProperty<TerraformProperty<string>>("certificate_chain");
        set => this.WithProperty("certificate_chain", value);
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateName
    {
        get => GetProperty<TerraformProperty<string>>("certificate_name");
        set => this.WithProperty("certificate_name", value);
    }

    /// <summary>
    /// The certificate_private_key attribute.
    /// </summary>
    public TerraformProperty<string>? CertificatePrivateKey
    {
        get => GetProperty<TerraformProperty<string>>("certificate_private_key");
        set => this.WithProperty("certificate_private_key", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ownership_verification_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? OwnershipVerificationCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("ownership_verification_certificate_arn");
        set => this.WithProperty("ownership_verification_certificate_arn", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
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
    /// The regional_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RegionalCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("regional_certificate_arn");
        set => this.WithProperty("regional_certificate_arn", value);
    }

    /// <summary>
    /// The regional_certificate_name attribute.
    /// </summary>
    public TerraformProperty<string>? RegionalCertificateName
    {
        get => GetProperty<TerraformProperty<string>>("regional_certificate_name");
        set => this.WithProperty("regional_certificate_name", value);
    }

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityPolicy
    {
        get => GetProperty<TerraformProperty<string>>("security_policy");
        set => this.WithProperty("security_policy", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
