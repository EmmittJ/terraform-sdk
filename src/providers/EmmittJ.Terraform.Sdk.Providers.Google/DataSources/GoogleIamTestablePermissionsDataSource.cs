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
        SetOutput("permissions");
        SetOutput("custom_support_level");
        SetOutput("full_resource_name");
        SetOutput("id");
        SetOutput("stages");
    }

    /// <summary>
    /// The custom_support_level attribute.
    /// </summary>
    public TerraformProperty<string> CustomSupportLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_support_level");
        set => SetProperty("custom_support_level", value);
    }

    /// <summary>
    /// The full_resource_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullResourceName is required")]
    public required TerraformProperty<string> FullResourceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("full_resource_name");
        set => SetProperty("full_resource_name", value);
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
    /// The stages attribute.
    /// </summary>
    public List<TerraformProperty<string>> Stages
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("stages");
        set => SetProperty("stages", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformExpression Permissions => this["permissions"];

}
