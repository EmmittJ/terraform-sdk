using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_access_keys.
/// </summary>
public class AwsIamAccessKeysDataSource : TerraformDataSource
{
    public AwsIamAccessKeysDataSource(string name) : base("aws_iam_access_keys", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_keys");
        SetOutput("id");
        SetOutput("user");
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
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformProperty<string> User
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user");
        set => SetProperty("user", value);
    }

    /// <summary>
    /// The access_keys attribute.
    /// </summary>
    public TerraformExpression AccessKeys => this["access_keys"];

}
