using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_domain_name Terraform data source.
/// Retrieves information about a aws_api_gateway_domain_name.
/// </summary>
public partial class AwsApiGatewayDomainNameDataSource(string name) : TerraformDataSource("aws_api_gateway_domain_name", name)
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    public TerraformValue<string> DomainNameId
    {
        get => new TerraformReference<string>(this, "domain_name_id");
        set => SetArgument("domain_name_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
    {
        get => new TerraformReference<string>(this, "certificate_arn");
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    public TerraformValue<string> CertificateName
    {
        get => new TerraformReference<string>(this, "certificate_name");
    }

    /// <summary>
    /// The certificate_upload_date attribute.
    /// </summary>
    public TerraformValue<string> CertificateUploadDate
    {
        get => new TerraformReference<string>(this, "certificate_upload_date");
    }

    /// <summary>
    /// The cloudfront_domain_name attribute.
    /// </summary>
    public TerraformValue<string> CloudfrontDomainName
    {
        get => new TerraformReference<string>(this, "cloudfront_domain_name");
    }

    /// <summary>
    /// The cloudfront_zone_id attribute.
    /// </summary>
    public TerraformValue<string> CloudfrontZoneId
    {
        get => new TerraformReference<string>(this, "cloudfront_zone_id");
    }

    /// <summary>
    /// The endpoint_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EndpointConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "endpoint_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
    }

    /// <summary>
    /// The regional_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> RegionalCertificateArn
    {
        get => new TerraformReference<string>(this, "regional_certificate_arn");
    }

    /// <summary>
    /// The regional_certificate_name attribute.
    /// </summary>
    public TerraformValue<string> RegionalCertificateName
    {
        get => new TerraformReference<string>(this, "regional_certificate_name");
    }

    /// <summary>
    /// The regional_domain_name attribute.
    /// </summary>
    public TerraformValue<string> RegionalDomainName
    {
        get => new TerraformReference<string>(this, "regional_domain_name");
    }

    /// <summary>
    /// The regional_zone_id attribute.
    /// </summary>
    public TerraformValue<string> RegionalZoneId
    {
        get => new TerraformReference<string>(this, "regional_zone_id");
    }

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    public TerraformValue<string> SecurityPolicy
    {
        get => new TerraformReference<string>(this, "security_policy");
    }

}
