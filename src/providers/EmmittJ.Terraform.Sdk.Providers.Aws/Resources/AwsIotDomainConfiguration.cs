using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authorizer_config in AwsIotDomainConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsIotDomainConfigurationAuthorizerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorizer_config";

    /// <summary>
    /// The allow_authorizer_override attribute.
    /// </summary>
    public TerraformValue<bool>? AllowAuthorizerOverride
    {
        get => new TerraformReference<bool>(this, "allow_authorizer_override");
        set => SetArgument("allow_authorizer_override", value);
    }

    /// <summary>
    /// The default_authorizer_name attribute.
    /// </summary>
    public TerraformValue<string>? DefaultAuthorizerName
    {
        get => new TerraformReference<string>(this, "default_authorizer_name");
        set => SetArgument("default_authorizer_name", value);
    }

}


/// <summary>
/// Block type for tls_config in AwsIotDomainConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsIotDomainConfigurationTlsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls_config";

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    public TerraformValue<string> SecurityPolicy
    {
        get => new TerraformReference<string>(this, "security_policy");
        set => SetArgument("security_policy", value);
    }

}


/// <summary>
/// Represents a aws_iot_domain_configuration Terraform resource.
/// Manages a aws_iot_domain_configuration resource.
/// </summary>
public partial class AwsIotDomainConfiguration(string name) : TerraformResource("aws_iot_domain_configuration", name)
{
    /// <summary>
    /// The application_protocol attribute.
    /// </summary>
    public TerraformValue<string> ApplicationProtocol
    {
        get => new TerraformReference<string>(this, "application_protocol");
        set => SetArgument("application_protocol", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformValue<string> AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The server_certificate_arns attribute.
    /// </summary>
    public TerraformSet<string>? ServerCertificateArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "server_certificate_arns").ResolveNodes(ctx));
        set => SetArgument("server_certificate_arns", value);
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public TerraformValue<string>? ServiceType
    {
        get => new TerraformReference<string>(this, "service_type");
        set => SetArgument("service_type", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
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
    /// The validation_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? ValidationCertificateArn
    {
        get => new TerraformReference<string>(this, "validation_certificate_arn");
        set => SetArgument("validation_certificate_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The domain_type attribute.
    /// </summary>
    public TerraformValue<string> DomainType
    {
        get => new TerraformReference<string>(this, "domain_type");
    }

    /// <summary>
    /// AuthorizerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizerConfig block(s) allowed")]
    public TerraformList<AwsIotDomainConfigurationAuthorizerConfigBlock>? AuthorizerConfig
    {
        get => GetArgument<TerraformList<AwsIotDomainConfigurationAuthorizerConfigBlock>>("authorizer_config");
        set => SetArgument("authorizer_config", value);
    }

    /// <summary>
    /// TlsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public TerraformList<AwsIotDomainConfigurationTlsConfigBlock>? TlsConfig
    {
        get => GetArgument<TerraformList<AwsIotDomainConfigurationTlsConfigBlock>>("tls_config");
        set => SetArgument("tls_config", value);
    }

}
