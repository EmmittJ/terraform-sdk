using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_configuration in AwsApiGatewayDomainName.
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayDomainNameEndpointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_configuration";

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type") ?? CreateReference("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Types is required")]
    public TerraformList<string>? Types
    {
        get => GetArgument<TerraformList<string>>("types");
        set => SetArgument("types", value);
    }

}


/// <summary>
/// Block type for mutual_tls_authentication in AwsApiGatewayDomainName.
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayDomainNameMutualTlsAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mutual_tls_authentication";

    /// <summary>
    /// The truststore_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TruststoreUri is required")]
    public required TerraformValue<string> TruststoreUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("truststore_uri");
        set => SetArgument("truststore_uri", value);
    }

    /// <summary>
    /// The truststore_version attribute.
    /// </summary>
    public TerraformValue<string>? TruststoreVersion
    {
        get => GetArgument<TerraformValue<string>>("truststore_version");
        set => SetArgument("truststore_version", value);
    }

}


/// <summary>
/// Represents a aws_api_gateway_domain_name Terraform resource.
/// Manages a aws_api_gateway_domain_name resource.
/// </summary>
public partial class AwsApiGatewayDomainName(string name) : TerraformResource("aws_api_gateway_domain_name", name)
{
    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? CertificateArn
    {
        get => GetArgument<TerraformValue<string>>("certificate_arn");
        set => SetArgument("certificate_arn", value);
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public TerraformValue<string>? CertificateBody
    {
        get => GetArgument<TerraformValue<string>>("certificate_body");
        set => SetArgument("certificate_body", value);
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformValue<string>? CertificateChain
    {
        get => GetArgument<TerraformValue<string>>("certificate_chain");
        set => SetArgument("certificate_chain", value);
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    public TerraformValue<string>? CertificateName
    {
        get => GetArgument<TerraformValue<string>>("certificate_name");
        set => SetArgument("certificate_name", value);
    }

    /// <summary>
    /// The certificate_private_key attribute.
    /// </summary>
    public TerraformValue<string>? CertificatePrivateKey
    {
        get => GetArgument<TerraformValue<string>>("certificate_private_key");
        set => SetArgument("certificate_private_key", value);
    }

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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ownership_verification_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> OwnershipVerificationCertificateArn
    {
        get => GetArgument<TerraformValue<string>>("ownership_verification_certificate_arn") ?? CreateReference("ownership_verification_certificate_arn");
        set => SetArgument("ownership_verification_certificate_arn", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The regional_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? RegionalCertificateArn
    {
        get => GetArgument<TerraformValue<string>>("regional_certificate_arn");
        set => SetArgument("regional_certificate_arn", value);
    }

    /// <summary>
    /// The regional_certificate_name attribute.
    /// </summary>
    public TerraformValue<string>? RegionalCertificateName
    {
        get => GetArgument<TerraformValue<string>>("regional_certificate_name");
        set => SetArgument("regional_certificate_name", value);
    }

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    public TerraformValue<string> SecurityPolicy
    {
        get => GetArgument<TerraformValue<string>>("security_policy") ?? CreateReference("security_policy");
        set => SetArgument("security_policy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The certificate_upload_date attribute.
    /// </summary>
    public TerraformValue<string> CertificateUploadDate
        => CreateReference("certificate_upload_date");

    /// <summary>
    /// The cloudfront_domain_name attribute.
    /// </summary>
    public TerraformValue<string> CloudfrontDomainName
        => CreateReference("cloudfront_domain_name");

    /// <summary>
    /// The cloudfront_zone_id attribute.
    /// </summary>
    public TerraformValue<string> CloudfrontZoneId
        => CreateReference("cloudfront_zone_id");

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    public TerraformValue<string> DomainNameId
        => CreateReference("domain_name_id");

    /// <summary>
    /// The regional_domain_name attribute.
    /// </summary>
    public TerraformValue<string> RegionalDomainName
        => CreateReference("regional_domain_name");

    /// <summary>
    /// The regional_zone_id attribute.
    /// </summary>
    public TerraformValue<string> RegionalZoneId
        => CreateReference("regional_zone_id");

    /// <summary>
    /// EndpointConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfiguration block(s) allowed")]
    public TerraformList<AwsApiGatewayDomainNameEndpointConfigurationBlock>? EndpointConfiguration
    {
        get => GetArgument<TerraformList<AwsApiGatewayDomainNameEndpointConfigurationBlock>>("endpoint_configuration");
        set => SetArgument("endpoint_configuration", value);
    }

    /// <summary>
    /// MutualTlsAuthentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualTlsAuthentication block(s) allowed")]
    public TerraformList<AwsApiGatewayDomainNameMutualTlsAuthenticationBlock>? MutualTlsAuthentication
    {
        get => GetArgument<TerraformList<AwsApiGatewayDomainNameMutualTlsAuthenticationBlock>>("mutual_tls_authentication");
        set => SetArgument("mutual_tls_authentication", value);
    }

}
