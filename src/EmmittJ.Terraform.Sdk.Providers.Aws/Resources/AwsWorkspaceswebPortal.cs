using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_portal resource.
/// </summary>
public class AwsWorkspaceswebPortal : TerraformResource
{
    public AwsWorkspaceswebPortal(string name) : base("aws_workspacesweb_portal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("browser_type");
        this.DeclareOutput("creation_date");
        this.DeclareOutput("data_protection_settings_arn");
        this.DeclareOutput("ip_access_settings_arn");
        this.DeclareOutput("network_settings_arn");
        this.DeclareOutput("portal_arn");
        this.DeclareOutput("portal_endpoint");
        this.DeclareOutput("portal_status");
        this.DeclareOutput("renderer_type");
        this.DeclareOutput("session_logger_arn");
        this.DeclareOutput("status_reason");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("trust_store_arn");
        this.DeclareOutput("user_access_logging_settings_arn");
        this.DeclareOutput("user_settings_arn");
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public Dictionary<string, string>? AdditionalEncryptionContext
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("additional_encryption_context")?.Value;
        set => this.WithProperty("additional_encryption_context", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public string? AuthenticationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_type")?.Value;
        set => this.WithProperty("authentication_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The browser_settings_arn attribute.
    /// </summary>
    public string? BrowserSettingsArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("browser_settings_arn")?.Value;
        set => this.WithProperty("browser_settings_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public string? CustomerManagedKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_managed_key")?.Value;
        set => this.WithProperty("customer_managed_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => this.WithProperty("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_concurrent_sessions attribute.
    /// </summary>
    public double? MaxConcurrentSessions
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_concurrent_sessions")?.Value;
        set => this.WithProperty("max_concurrent_sessions", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The browser_type attribute.
    /// </summary>
    public TerraformExpression BrowserType => this["browser_type"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    public TerraformExpression DataProtectionSettingsArn => this["data_protection_settings_arn"];

    /// <summary>
    /// The ip_access_settings_arn attribute.
    /// </summary>
    public TerraformExpression IpAccessSettingsArn => this["ip_access_settings_arn"];

    /// <summary>
    /// The network_settings_arn attribute.
    /// </summary>
    public TerraformExpression NetworkSettingsArn => this["network_settings_arn"];

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    public TerraformExpression PortalArn => this["portal_arn"];

    /// <summary>
    /// The portal_endpoint attribute.
    /// </summary>
    public TerraformExpression PortalEndpoint => this["portal_endpoint"];

    /// <summary>
    /// The portal_status attribute.
    /// </summary>
    public TerraformExpression PortalStatus => this["portal_status"];

    /// <summary>
    /// The renderer_type attribute.
    /// </summary>
    public TerraformExpression RendererType => this["renderer_type"];

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    public TerraformExpression SessionLoggerArn => this["session_logger_arn"];

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    public TerraformExpression TrustStoreArn => this["trust_store_arn"];

    /// <summary>
    /// The user_access_logging_settings_arn attribute.
    /// </summary>
    public TerraformExpression UserAccessLoggingSettingsArn => this["user_access_logging_settings_arn"];

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    public TerraformExpression UserSettingsArn => this["user_settings_arn"];

}
