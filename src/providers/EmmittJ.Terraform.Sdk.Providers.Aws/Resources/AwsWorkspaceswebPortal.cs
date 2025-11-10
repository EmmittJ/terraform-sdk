using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsWorkspaceswebPortalTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("browser_type");
        SetOutput("creation_date");
        SetOutput("data_protection_settings_arn");
        SetOutput("ip_access_settings_arn");
        SetOutput("network_settings_arn");
        SetOutput("portal_arn");
        SetOutput("portal_endpoint");
        SetOutput("portal_status");
        SetOutput("renderer_type");
        SetOutput("session_logger_arn");
        SetOutput("status_reason");
        SetOutput("tags_all");
        SetOutput("trust_store_arn");
        SetOutput("user_access_logging_settings_arn");
        SetOutput("user_settings_arn");
        SetOutput("additional_encryption_context");
        SetOutput("authentication_type");
        SetOutput("browser_settings_arn");
        SetOutput("customer_managed_key");
        SetOutput("display_name");
        SetOutput("instance_type");
        SetOutput("max_concurrent_sessions");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AdditionalEncryptionContext
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("additional_encryption_context");
        set => SetProperty("additional_encryption_context", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string> AuthenticationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_type");
        set => SetProperty("authentication_type", value);
    }

    /// <summary>
    /// The browser_settings_arn attribute.
    /// </summary>
    public TerraformProperty<string> BrowserSettingsArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("browser_settings_arn");
        set => SetProperty("browser_settings_arn", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformProperty<string> CustomerManagedKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_managed_key");
        set => SetProperty("customer_managed_key", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string> InstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_type");
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The max_concurrent_sessions attribute.
    /// </summary>
    public TerraformProperty<double> MaxConcurrentSessions
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_concurrent_sessions");
        set => SetProperty("max_concurrent_sessions", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsWorkspaceswebPortalTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
