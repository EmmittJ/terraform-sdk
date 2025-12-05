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
        get => GetArgument<TerraformValue<bool>>("allow_authorizer_override");
        set => SetArgument("allow_authorizer_override", value);
    }

    /// <summary>
    /// The default_authorizer_name attribute.
    /// </summary>
    public TerraformValue<string>? DefaultAuthorizerName
    {
        get => GetArgument<TerraformValue<string>>("default_authorizer_name");
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
        get => GetArgument<TerraformValue<string>>("security_policy") ?? CreateReference("security_policy");
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
        get => GetArgument<TerraformValue<string>>("application_protocol") ?? CreateReference("application_protocol");
        set => SetArgument("application_protocol", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformValue<string> AuthenticationType
    {
        get => GetArgument<TerraformValue<string>>("authentication_type") ?? CreateReference("authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name") ?? CreateReference("domain_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The server_certificate_arns attribute.
    /// </summary>
    public TerraformSet<string>? ServerCertificateArns
    {
        get => GetArgument<TerraformSet<string>>("server_certificate_arns");
        set => SetArgument("server_certificate_arns", value);
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public TerraformValue<string>? ServiceType
    {
        get => GetArgument<TerraformValue<string>>("service_type");
        set => SetArgument("service_type", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
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
    /// The validation_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? ValidationCertificateArn
    {
        get => GetArgument<TerraformValue<string>>("validation_certificate_arn");
        set => SetArgument("validation_certificate_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The domain_type attribute.
    /// </summary>
    public TerraformValue<string> DomainType
        => CreateReference("domain_type");

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
