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
    public TerraformMapProperty<string>? AdditionalEncryptionContext
    {
        get => GetProperty<TerraformMapProperty<string>>("additional_encryption_context");
        set => this.WithProperty("additional_encryption_context", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The browser_settings_arn attribute.
    /// </summary>
    public TerraformProperty<string>? BrowserSettingsArn
    {
        get => GetProperty<TerraformProperty<string>>("browser_settings_arn");
        set => this.WithProperty("browser_settings_arn", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerManagedKey
    {
        get => GetProperty<TerraformProperty<string>>("customer_managed_key");
        set => this.WithProperty("customer_managed_key", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The max_concurrent_sessions attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentSessions
    {
        get => GetProperty<TerraformProperty<double>>("max_concurrent_sessions");
        set => this.WithProperty("max_concurrent_sessions", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
