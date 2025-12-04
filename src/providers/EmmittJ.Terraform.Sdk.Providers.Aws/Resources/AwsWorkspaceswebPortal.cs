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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformMap<string>>("additional_encryption_context");
        set => SetArgument("additional_encryption_context", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformValue<string> AuthenticationType
    {
        get => GetArgument<TerraformValue<string>>("authentication_type") ?? AsReference("authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The browser_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> BrowserSettingsArn
    {
        get => GetArgument<TerraformValue<string>>("browser_settings_arn") ?? AsReference("browser_settings_arn");
        set => SetArgument("browser_settings_arn", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformValue<string>? CustomerManagedKey
    {
        get => GetArgument<TerraformValue<string>>("customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name") ?? AsReference("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type") ?? AsReference("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The max_concurrent_sessions attribute.
    /// </summary>
    public TerraformValue<double> MaxConcurrentSessions
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_sessions") ?? AsReference("max_concurrent_sessions");
        set => SetArgument("max_concurrent_sessions", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
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
    /// The browser_type attribute.
    /// </summary>
    public TerraformValue<string> BrowserType
        => AsReference("browser_type");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
        => AsReference("creation_date");

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> DataProtectionSettingsArn
        => AsReference("data_protection_settings_arn");

    /// <summary>
    /// The ip_access_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> IpAccessSettingsArn
        => AsReference("ip_access_settings_arn");

    /// <summary>
    /// The network_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> NetworkSettingsArn
        => AsReference("network_settings_arn");

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    public TerraformValue<string> PortalArn
        => AsReference("portal_arn");

    /// <summary>
    /// The portal_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PortalEndpoint
        => AsReference("portal_endpoint");

    /// <summary>
    /// The portal_status attribute.
    /// </summary>
    public TerraformValue<string> PortalStatus
        => AsReference("portal_status");

    /// <summary>
    /// The renderer_type attribute.
    /// </summary>
    public TerraformValue<string> RendererType
        => AsReference("renderer_type");

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    public TerraformValue<string> SessionLoggerArn
        => AsReference("session_logger_arn");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformValue<string> StatusReason
        => AsReference("status_reason");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    public TerraformValue<string> TrustStoreArn
        => AsReference("trust_store_arn");

    /// <summary>
    /// The user_access_logging_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> UserAccessLoggingSettingsArn
        => AsReference("user_access_logging_settings_arn");

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> UserSettingsArn
        => AsReference("user_settings_arn");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsWorkspaceswebPortalTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsWorkspaceswebPortalTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
