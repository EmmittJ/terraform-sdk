using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloudfunctions_function_iam_policy.
/// </summary>
public class GoogleCloudfunctionsFunctionIamPolicyDataSource : TerraformDataSource
{
    public GoogleCloudfunctionsFunctionIamPolicyDataSource(string name) : base("google_cloudfunctions_function_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
        this.DeclareOutput("policy_data");
    }

    /// <summary>
    /// The cloud_function attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudFunction is required")]
    public required TerraformProperty<string> CloudFunction
    {
        get => GetProperty<TerraformProperty<string>>("cloud_function");
        set => this.WithProperty("cloud_function", value);
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
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
