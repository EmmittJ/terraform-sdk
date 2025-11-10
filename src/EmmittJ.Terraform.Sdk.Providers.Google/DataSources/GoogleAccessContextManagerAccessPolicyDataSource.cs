using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_access_context_manager_access_policy.
/// </summary>
public class GoogleAccessContextManagerAccessPolicyDataSource : TerraformDataSource
{
    public GoogleAccessContextManagerAccessPolicyDataSource(string name) : base("google_access_context_manager_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("title");
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
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Scopes
    {
        get => GetProperty<List<TerraformProperty<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformExpression Title => this["title"];

}
