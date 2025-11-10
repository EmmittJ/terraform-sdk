using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_healthcare_consent_store_iam_policy.
/// </summary>
public class GoogleHealthcareConsentStoreIamPolicyDataSource : TerraformDataSource
{
    public GoogleHealthcareConsentStoreIamPolicyDataSource(string name) : base("google_healthcare_consent_store_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("policy_data");
        SetOutput("consent_store_id");
        SetOutput("dataset");
        SetOutput("id");
    }

    /// <summary>
    /// The consent_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsentStoreId is required")]
    public required TerraformProperty<string> ConsentStoreId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("consent_store_id");
        set => SetProperty("consent_store_id", value);
    }

    /// <summary>
    /// The dataset attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformProperty<string> Dataset
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataset");
        set => SetProperty("dataset", value);
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
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
