using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iam_testable_permissions.
/// </summary>
public class GoogleIamTestablePermissionsDataSource : TerraformDataSource
{
    public GoogleIamTestablePermissionsDataSource(string name) : base("google_iam_testable_permissions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("permissions");
    }

    /// <summary>
    /// The custom_support_level attribute.
    /// </summary>
    public string? CustomSupportLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_support_level")?.Value;
        set => this.WithProperty("custom_support_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The full_resource_name attribute.
    /// </summary>
    public string? FullResourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("full_resource_name")?.Value;
        set => this.WithProperty("full_resource_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The stages attribute.
    /// </summary>
    public List<string>? Stages
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("stages")?.Value;
        set => this.WithProperty("stages", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformExpression Permissions => this["permissions"];

}
