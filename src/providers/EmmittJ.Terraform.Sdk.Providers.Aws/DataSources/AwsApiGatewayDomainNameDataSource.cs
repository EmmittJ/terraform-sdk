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
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    public TerraformValue<string> DomainNameId
    {
        get => GetArgument<TerraformValue<string>>("domain_name_id") ?? AsReference("domain_name_id");
        set => SetArgument("domain_name_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
        => AsReference("certificate_arn");

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    public TerraformValue<string> CertificateName
        => AsReference("certificate_name");

    /// <summary>
    /// The certificate_upload_date attribute.
    /// </summary>
    public TerraformValue<string> CertificateUploadDate
        => AsReference("certificate_upload_date");

    /// <summary>
    /// The cloudfront_domain_name attribute.
    /// </summary>
    public TerraformValue<string> CloudfrontDomainName
        => AsReference("cloudfront_domain_name");

    /// <summary>
    /// The cloudfront_zone_id attribute.
    /// </summary>
    public TerraformValue<string> CloudfrontZoneId
        => AsReference("cloudfront_zone_id");

    /// <summary>
    /// The endpoint_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EndpointConfiguration
        => AsReference("endpoint_configuration");

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
        => AsReference("policy");

    /// <summary>
    /// The regional_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> RegionalCertificateArn
        => AsReference("regional_certificate_arn");

    /// <summary>
    /// The regional_certificate_name attribute.
    /// </summary>
    public TerraformValue<string> RegionalCertificateName
        => AsReference("regional_certificate_name");

    /// <summary>
    /// The regional_domain_name attribute.
    /// </summary>
    public TerraformValue<string> RegionalDomainName
        => AsReference("regional_domain_name");

    /// <summary>
    /// The regional_zone_id attribute.
    /// </summary>
    public TerraformValue<string> RegionalZoneId
        => AsReference("regional_zone_id");

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    public TerraformValue<string> SecurityPolicy
        => AsReference("security_policy");

}
