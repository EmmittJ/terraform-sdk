using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for audit_log_config in GoogleProjectIamAuditConfig.
/// Nesting mode: set
/// </summary>
public class GoogleProjectIamAuditConfigAuditLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audit_log_config";

    /// <summary>
    /// Identities that do not cause logging for this type of permission. Each entry can have one of the following values:user:{emailid}: An email address that represents a specific Google account. For example, alice@gmail.com or joe@example.com. serviceAccount:{emailid}: An email address that represents a service account. For example, my-other-app@appspot.gserviceaccount.com. group:{emailid}: An email address that represents a Google group. For example, admins@example.com. domain:{domain}: A G Suite domain (primary, instead of alias) name that represents all the users of that domain. For example, google.com or example.com.
    /// </summary>
    public TerraformSet<string>? ExemptedMembers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "exempted_members").ResolveNodes(ctx));
        set => SetArgument("exempted_members", value);
    }

    /// <summary>
    /// Permission type for which logging is to be configured. Must be one of DATA_READ, DATA_WRITE, or ADMIN_READ.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    public required TerraformValue<string> LogType
    {
        get => new TerraformReference<string>(this, "log_type");
        set => SetArgument("log_type", value);
    }

}


/// <summary>
/// Represents a google_project_iam_audit_config Terraform resource.
/// Manages a google_project_iam_audit_config resource.
/// </summary>
public partial class GoogleProjectIamAuditConfig(string name) : TerraformResource("google_project_iam_audit_config", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Service which will be enabled for audit logging. The special value allServices covers all services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// The etag of iam policy
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// AuditLogConfig block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuditLogConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuditLogConfig block(s) required")]
    public required TerraformSet<GoogleProjectIamAuditConfigAuditLogConfigBlock> AuditLogConfig
    {
        get => GetRequiredArgument<TerraformSet<GoogleProjectIamAuditConfigAuditLogConfigBlock>>("audit_log_config");
        set => SetArgument("audit_log_config", value);
    }

}
