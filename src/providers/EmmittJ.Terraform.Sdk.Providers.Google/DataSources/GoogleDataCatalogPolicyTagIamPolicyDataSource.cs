using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_data_catalog_policy_tag_iam_policy.
/// </summary>
public class GoogleDataCatalogPolicyTagIamPolicyDataSource : TerraformDataSource
{
    public GoogleDataCatalogPolicyTagIamPolicyDataSource(string name) : base("google_data_catalog_policy_tag_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("policy_data");
        SetOutput("id");
        SetOutput("policy_tag");
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
    /// The policy_tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyTag is required")]
    public required TerraformProperty<string> PolicyTag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_tag");
        set => SetProperty("policy_tag", value);
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
