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
    public TerraformProperty<string>? CustomSupportLevel
    {
        get => GetProperty<TerraformProperty<string>>("custom_support_level");
        set => this.WithProperty("custom_support_level", value);
    }

    /// <summary>
    /// The full_resource_name attribute.
    /// </summary>
    public TerraformProperty<string>? FullResourceName
    {
        get => GetProperty<TerraformProperty<string>>("full_resource_name");
        set => this.WithProperty("full_resource_name", value);
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
    /// The stages attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Stages
    {
        get => GetProperty<TerraformProperty<List<string>>>("stages");
        set => this.WithProperty("stages", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformExpression Permissions => this["permissions"];

}
