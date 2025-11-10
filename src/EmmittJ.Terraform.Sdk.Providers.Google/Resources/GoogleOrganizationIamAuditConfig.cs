using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for audit_log_config in .
/// Nesting mode: set
/// </summary>
public class GoogleOrganizationIamAuditConfigAuditLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Identities that do not cause logging for this type of permission. Each entry can have one of the following values:user:{emailid}: An email address that represents a specific Google account. For example, alice@gmail.com or joe@example.com. serviceAccount:{emailid}: An email address that represents a service account. For example, my-other-app@appspot.gserviceaccount.com. group:{emailid}: An email address that represents a Google group. For example, admins@example.com. domain:{domain}: A G Suite domain (primary, instead of alias) name that represents all the users of that domain. For example, google.com or example.com.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExemptedMembers
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("exempted_members");
        set => WithProperty("exempted_members", value);
    }

    /// <summary>
    /// Permission type for which logging is to be configured. Must be one of DATA_READ, DATA_WRITE, or ADMIN_READ.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    public required TerraformProperty<string> LogType
    {
        get => GetProperty<TerraformProperty<string>>("log_type");
        set => WithProperty("log_type", value);
    }

}

/// <summary>
/// Manages a google_organization_iam_audit_config resource.
/// </summary>
public class GoogleOrganizationIamAuditConfig : TerraformResource
{
    public GoogleOrganizationIamAuditConfig(string name) : base("google_organization_iam_audit_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
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
    /// The numeric ID of the organization in which you want to manage the audit logging config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Service which will be enabled for audit logging. The special value allServices covers all services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// Block for audit_log_config.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuditLogConfig block(s) required")]
    public HashSet<GoogleOrganizationIamAuditConfigAuditLogConfigBlock>? AuditLogConfig
    {
        get => GetProperty<HashSet<GoogleOrganizationIamAuditConfigAuditLogConfigBlock>>("audit_log_config");
        set => this.WithProperty("audit_log_config", value);
    }

    /// <summary>
    /// The etag of iam policy
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
