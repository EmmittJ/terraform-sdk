using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account.
/// </summary>
public class GoogleServiceAccountDataSource : TerraformDataSource
{
    public GoogleServiceAccountDataSource(string name) : base("google_service_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("disabled");
        this.DeclareOutput("display_name");
        this.DeclareOutput("email");
        this.DeclareOutput("member");
        this.DeclareOutput("name");
        this.DeclareOutput("unique_id");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformExpression Disabled => this["disabled"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The member attribute.
    /// </summary>
    public TerraformExpression Member => this["member"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}
