using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_auditmanager_organization_admin_account_registration resource.
/// </summary>
public class AwsAuditmanagerOrganizationAdminAccountRegistration : TerraformResource
{
    public AwsAuditmanagerOrganizationAdminAccountRegistration(string name) : base("aws_auditmanager_organization_admin_account_registration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("organization_id");
    }

    /// <summary>
    /// The admin_account_id attribute.
    /// </summary>
    public string? AdminAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_account_id")?.Value;
        set => this.WithProperty("admin_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformExpression OrganizationId => this["organization_id"];

}
