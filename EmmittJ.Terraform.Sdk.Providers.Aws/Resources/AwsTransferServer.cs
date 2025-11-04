using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_server resource.
/// </summary>
public class AwsTransferServer : TerraformResource
{
    public AwsTransferServer(string name) : base("aws_transfer_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("host_key_fingerprint");
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public string? Certificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate")?.Value;
        set => this.WithProperty("certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public string? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id")?.Value;
        set => this.WithProperty("directory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public string? EndpointType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_type")?.Value;
        set => this.WithProperty("endpoint_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public bool? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy")?.Value;
        set => this.WithProperty("force_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The function attribute.
    /// </summary>
    public string? Function
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function")?.Value;
        set => this.WithProperty("function", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    public string? HostKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_key")?.Value;
        set => this.WithProperty("host_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The identity_provider_type attribute.
    /// </summary>
    public string? IdentityProviderType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_provider_type")?.Value;
        set => this.WithProperty("identity_provider_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    public string? InvocationRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("invocation_role")?.Value;
        set => this.WithProperty("invocation_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public string? LoggingRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logging_role")?.Value;
        set => this.WithProperty("logging_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The post_authentication_login_banner attribute.
    /// </summary>
    public string? PostAuthenticationLoginBanner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("post_authentication_login_banner")?.Value;
        set => this.WithProperty("post_authentication_login_banner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pre_authentication_login_banner attribute.
    /// </summary>
    public string? PreAuthenticationLoginBanner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pre_authentication_login_banner")?.Value;
        set => this.WithProperty("pre_authentication_login_banner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public HashSet<string>? Protocols
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("protocols")?.Value;
        set => this.WithProperty("protocols", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The security_policy_name attribute.
    /// </summary>
    public string? SecurityPolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_policy_name")?.Value;
        set => this.WithProperty("security_policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sftp_authentication_methods attribute.
    /// </summary>
    public string? SftpAuthenticationMethods
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sftp_authentication_methods")?.Value;
        set => this.WithProperty("sftp_authentication_methods", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// This is a set of arns of destinations that will receive structured logs from the transfer server
    /// </summary>
    public HashSet<string>? StructuredLogDestinations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("structured_log_destinations")?.Value;
        set => this.WithProperty("structured_log_destinations", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The url attribute.
    /// </summary>
    public string? Url
    {
        get => GetProperty<TerraformLiteralProperty<string>>("url")?.Value;
        set => this.WithProperty("url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    public TerraformExpression HostKeyFingerprint => this["host_key_fingerprint"];

}
