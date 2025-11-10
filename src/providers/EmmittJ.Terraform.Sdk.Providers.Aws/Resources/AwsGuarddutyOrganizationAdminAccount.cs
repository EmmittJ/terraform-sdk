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
        SetOutput("admin_account_id");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The admin_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminAccountId is required")]
    public required TerraformProperty<string> AdminAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_account_id");
        set => SetProperty("admin_account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
