using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_guardduty_organization_admin_account resource.
/// </summary>
public class AwsGuarddutyOrganizationAdminAccount : TerraformResource
{
    public AwsGuarddutyOrganizationAdminAccount(string name) : base("aws_guardduty_organization_admin_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
