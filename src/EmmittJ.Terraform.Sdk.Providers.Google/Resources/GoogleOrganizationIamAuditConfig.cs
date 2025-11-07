using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformProperty<string>? OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Service which will be enabled for audit logging. The special value allServices covers all services.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// The etag of iam policy
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
