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
    public TerraformLiteralProperty<string>? CustomSupportLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_support_level");
        set => this.WithProperty("custom_support_level", value);
    }

    /// <summary>
    /// The full_resource_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FullResourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("full_resource_name");
        set => this.WithProperty("full_resource_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The stages attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Stages
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("stages");
        set => this.WithProperty("stages", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformExpression Permissions => this["permissions"];

}
