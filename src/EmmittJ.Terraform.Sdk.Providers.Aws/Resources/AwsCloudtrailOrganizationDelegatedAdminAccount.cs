using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudtrail_organization_delegated_admin_account resource.
/// </summary>
public class AwsCloudtrailOrganizationDelegatedAdminAccount : TerraformResource
{
    public AwsCloudtrailOrganizationDelegatedAdminAccount(string name) : base("aws_cloudtrail_organization_delegated_admin_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("email");
        this.DeclareOutput("id");
        this.DeclareOutput("name");
        this.DeclareOutput("service_principal");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformProperty<string> AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    public TerraformExpression ServicePrincipal => this["service_principal"];

}
