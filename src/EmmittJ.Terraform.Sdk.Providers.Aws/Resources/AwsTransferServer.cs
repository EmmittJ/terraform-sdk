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
    public TerraformProperty<string>? Certificate
    {
        get => GetProperty<TerraformProperty<string>>("certificate");
        set => this.WithProperty("certificate", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryId
    {
        get => GetProperty<TerraformProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointType
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_type");
        set => this.WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
    }

    /// <summary>
    /// The function attribute.
    /// </summary>
    public TerraformProperty<string>? Function
    {
        get => GetProperty<TerraformProperty<string>>("function");
        set => this.WithProperty("function", value);
    }

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    public TerraformProperty<string>? HostKey
    {
        get => GetProperty<TerraformProperty<string>>("host_key");
        set => this.WithProperty("host_key", value);
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
    /// The identity_provider_type attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityProviderType
    {
        get => GetProperty<TerraformProperty<string>>("identity_provider_type");
        set => this.WithProperty("identity_provider_type", value);
    }

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    public TerraformProperty<string>? InvocationRole
    {
        get => GetProperty<TerraformProperty<string>>("invocation_role");
        set => this.WithProperty("invocation_role", value);
    }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public TerraformProperty<string>? LoggingRole
    {
        get => GetProperty<TerraformProperty<string>>("logging_role");
        set => this.WithProperty("logging_role", value);
    }

    /// <summary>
    /// The post_authentication_login_banner attribute.
    /// </summary>
    public TerraformProperty<string>? PostAuthenticationLoginBanner
    {
        get => GetProperty<TerraformProperty<string>>("post_authentication_login_banner");
        set => this.WithProperty("post_authentication_login_banner", value);
    }

    /// <summary>
    /// The pre_authentication_login_banner attribute.
    /// </summary>
    public TerraformProperty<string>? PreAuthenticationLoginBanner
    {
        get => GetProperty<TerraformProperty<string>>("pre_authentication_login_banner");
        set => this.WithProperty("pre_authentication_login_banner", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Protocols
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("protocols");
        set => this.WithProperty("protocols", value);
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
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityPolicyName
    {
        get => GetProperty<TerraformProperty<string>>("security_policy_name");
        set => this.WithProperty("security_policy_name", value);
    }

    /// <summary>
    /// The sftp_authentication_methods attribute.
    /// </summary>
    public TerraformProperty<string>? SftpAuthenticationMethods
    {
        get => GetProperty<TerraformProperty<string>>("sftp_authentication_methods");
        set => this.WithProperty("sftp_authentication_methods", value);
    }

    /// <summary>
    /// This is a set of arns of destinations that will receive structured logs from the transfer server
    /// </summary>
    public TerraformProperty<HashSet<string>>? StructuredLogDestinations
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("structured_log_destinations");
        set => this.WithProperty("structured_log_destinations", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
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
