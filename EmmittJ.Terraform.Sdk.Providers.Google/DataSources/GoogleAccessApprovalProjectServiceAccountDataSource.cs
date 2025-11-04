using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_access_approval_project_service_account.
/// </summary>
public class GoogleAccessApprovalProjectServiceAccountDataSource : TerraformDataSource
{
    public GoogleAccessApprovalProjectServiceAccountDataSource(string name) : base("google_access_approval_project_service_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("account_email");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project_id attribute.
    /// </summary>
    public string? ProjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_id")?.Value;
        set => this.WithProperty("project_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The account_email attribute.
    /// </summary>
    public TerraformExpression AccountEmail => this["account_email"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
