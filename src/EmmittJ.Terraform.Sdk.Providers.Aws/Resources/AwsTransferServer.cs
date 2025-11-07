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
    public TerraformLiteralProperty<string>? Certificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate");
        set => this.WithProperty("certificate", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndpointType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_type");
        set => this.WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
    }

    /// <summary>
    /// The function attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Function
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function");
        set => this.WithProperty("function", value);
    }

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HostKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_key");
        set => this.WithProperty("host_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityProviderType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_provider_type");
        set => this.WithProperty("identity_provider_type", value);
    }

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InvocationRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("invocation_role");
        set => this.WithProperty("invocation_role", value);
    }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoggingRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logging_role");
        set => this.WithProperty("logging_role", value);
    }

    /// <summary>
    /// The post_authentication_login_banner attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PostAuthenticationLoginBanner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("post_authentication_login_banner");
        set => this.WithProperty("post_authentication_login_banner", value);
    }

    /// <summary>
    /// The pre_authentication_login_banner attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PreAuthenticationLoginBanner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pre_authentication_login_banner");
        set => this.WithProperty("pre_authentication_login_banner", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Protocols
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("protocols");
        set => this.WithProperty("protocols", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityPolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_policy_name");
        set => this.WithProperty("security_policy_name", value);
    }

    /// <summary>
    /// The sftp_authentication_methods attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SftpAuthenticationMethods
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sftp_authentication_methods");
        set => this.WithProperty("sftp_authentication_methods", value);
    }

    /// <summary>
    /// This is a set of arns of destinations that will receive structured logs from the transfer server
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? StructuredLogDestinations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("structured_log_destinations");
        set => this.WithProperty("structured_log_destinations", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Url
    {
        get => GetProperty<TerraformLiteralProperty<string>>("url");
        set => this.WithProperty("url", value);
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
