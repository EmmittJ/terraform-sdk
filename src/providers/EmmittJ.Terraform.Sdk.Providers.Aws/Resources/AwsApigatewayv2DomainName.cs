using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for domain_name_configuration in AwsApigatewayv2DomainName.
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2DomainNameDomainNameConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "domain_name_configuration";

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateArn is required")]
    public required TerraformValue<string> CertificateArn
    {
        get => new TerraformReference<string>(this, "certificate_arn");
        set => SetArgument("certificate_arn", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformValue<string> EndpointType
    {
        get => new TerraformReference<string>(this, "endpoint_type");
        set => SetArgument("endpoint_type", value);
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
    {
        get => new TerraformReference<string>(this, "hosted_zone_id");
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The ownership_verification_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> OwnershipVerificationCertificateArn
    {
        get => new TerraformReference<string>(this, "ownership_verification_certificate_arn");
        set => SetArgument("ownership_verification_certificate_arn", value);
    }

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityPolicy is required")]
    public required TerraformValue<string> SecurityPolicy
    {
        get => new TerraformReference<string>(this, "security_policy");
        set => SetArgument("security_policy", value);
    }

    /// <summary>
    /// The target_domain_name attribute.
    /// </summary>
    public TerraformValue<string> TargetDomainName
    {
        get => new TerraformReference<string>(this, "target_domain_name");
    }

}


/// <summary>
/// Block type for mutual_tls_authentication in AwsApigatewayv2DomainName.
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2DomainNameMutualTlsAuthenticationBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "truststore_uri");
        set => SetArgument("truststore_uri", value);
    }

    /// <summary>
    /// The truststore_version attribute.
    /// </summary>
    public TerraformValue<string>? TruststoreVersion
    {
        get => new TerraformReference<string>(this, "truststore_version");
        set => SetArgument("truststore_version", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsApigatewayv2DomainName.
/// Nesting mode: single
/// </summary>
public class AwsApigatewayv2DomainNameTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_apigatewayv2_domain_name Terraform resource.
/// Manages a aws_apigatewayv2_domain_name resource.
/// </summary>
public partial class AwsApigatewayv2DomainName(string name) : TerraformResource("aws_apigatewayv2_domain_name", name)
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
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The api_mapping_selection_expression attribute.
    /// </summary>
    public TerraformValue<string> ApiMappingSelectionExpression
    {
        get => new TerraformReference<string>(this, "api_mapping_selection_expression");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// DomainNameConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNameConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DomainNameConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainNameConfiguration block(s) allowed")]
    public required TerraformList<AwsApigatewayv2DomainNameDomainNameConfigurationBlock> DomainNameConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsApigatewayv2DomainNameDomainNameConfigurationBlock>>("domain_name_configuration");
        set => SetArgument("domain_name_configuration", value);
    }

    /// <summary>
    /// MutualTlsAuthentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MutualTlsAuthentication block(s) allowed")]
    public TerraformList<AwsApigatewayv2DomainNameMutualTlsAuthenticationBlock>? MutualTlsAuthentication
    {
        get => GetArgument<TerraformList<AwsApigatewayv2DomainNameMutualTlsAuthenticationBlock>>("mutual_tls_authentication");
        set => SetArgument("mutual_tls_authentication", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsApigatewayv2DomainNameTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsApigatewayv2DomainNameTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
