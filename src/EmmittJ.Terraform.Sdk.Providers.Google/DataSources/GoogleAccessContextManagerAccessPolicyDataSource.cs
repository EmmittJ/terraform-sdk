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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    public List<string>? Scopes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("scopes")?.Value;
        set => this.WithProperty("scopes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
