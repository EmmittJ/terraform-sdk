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
        this.WithOutput("id");
        this.WithOutput("organization_id");
    }

    /// <summary>
    /// The admin_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminAccountId is required")]
    public required TerraformProperty<string> AdminAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("admin_account_id");
        set => this.WithProperty("admin_account_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformExpression OrganizationId => this["organization_id"];

}
