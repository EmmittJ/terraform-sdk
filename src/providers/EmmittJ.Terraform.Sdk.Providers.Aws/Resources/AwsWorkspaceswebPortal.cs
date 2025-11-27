using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsWorkspaceswebPortal.
/// Nesting mode: single
/// </summary>
public class AwsWorkspaceswebPortalTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_workspacesweb_portal Terraform resource.
/// Manages a aws_workspacesweb_portal resource.
/// </summary>
public partial class AwsWorkspaceswebPortal(string name) : TerraformResource("aws_workspacesweb_portal", name)
{
    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalEncryptionContext
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_encryption_context").ResolveNodes(ctx));
        set => SetArgument("additional_encryption_context", value);
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
    /// The browser_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> BrowserSettingsArn
    {
        get => new TerraformReference<string>(this, "browser_settings_arn");
        set => SetArgument("browser_settings_arn", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformValue<string>? CustomerManagedKey
    {
        get => new TerraformReference<string>(this, "customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The max_concurrent_sessions attribute.
    /// </summary>
    public TerraformValue<double> MaxConcurrentSessions
    {
        get => new TerraformReference<double>(this, "max_concurrent_sessions");
        set => SetArgument("max_concurrent_sessions", value);
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
    /// The browser_type attribute.
    /// </summary>
    public TerraformValue<string> BrowserType
    {
        get => new TerraformReference<string>(this, "browser_type");
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
    {
        get => new TerraformReference<string>(this, "creation_date");
    }

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> DataProtectionSettingsArn
    {
        get => new TerraformReference<string>(this, "data_protection_settings_arn");
    }

    /// <summary>
    /// The ip_access_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> IpAccessSettingsArn
    {
        get => new TerraformReference<string>(this, "ip_access_settings_arn");
    }

    /// <summary>
    /// The network_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> NetworkSettingsArn
    {
        get => new TerraformReference<string>(this, "network_settings_arn");
    }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    public TerraformValue<string> PortalArn
    {
        get => new TerraformReference<string>(this, "portal_arn");
    }

    /// <summary>
    /// The portal_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PortalEndpoint
    {
        get => new TerraformReference<string>(this, "portal_endpoint");
    }

    /// <summary>
    /// The portal_status attribute.
    /// </summary>
    public TerraformValue<string> PortalStatus
    {
        get => new TerraformReference<string>(this, "portal_status");
    }

    /// <summary>
    /// The renderer_type attribute.
    /// </summary>
    public TerraformValue<string> RendererType
    {
        get => new TerraformReference<string>(this, "renderer_type");
    }

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    public TerraformValue<string> SessionLoggerArn
    {
        get => new TerraformReference<string>(this, "session_logger_arn");
    }

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformValue<string> StatusReason
    {
        get => new TerraformReference<string>(this, "status_reason");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    public TerraformValue<string> TrustStoreArn
    {
        get => new TerraformReference<string>(this, "trust_store_arn");
    }

    /// <summary>
    /// The user_access_logging_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> UserAccessLoggingSettingsArn
    {
        get => new TerraformReference<string>(this, "user_access_logging_settings_arn");
    }

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> UserSettingsArn
    {
        get => new TerraformReference<string>(this, "user_settings_arn");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsWorkspaceswebPortalTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsWorkspaceswebPortalTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
