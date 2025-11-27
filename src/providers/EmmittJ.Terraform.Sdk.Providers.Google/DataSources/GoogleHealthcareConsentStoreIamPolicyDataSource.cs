using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_healthcare_consent_store_iam_policy Terraform data source.
/// Retrieves information about a google_healthcare_consent_store_iam_policy.
/// </summary>
public partial class GoogleHealthcareConsentStoreIamPolicyDataSource(string name) : TerraformDataSource("google_healthcare_consent_store_iam_policy", name)
{
    /// <summary>
    /// The consent_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsentStoreId is required")]
    public required TerraformValue<string> ConsentStoreId
    {
        get => new TerraformReference<string>(this, "consent_store_id");
        set => SetArgument("consent_store_id", value);
    }

    /// <summary>
    /// The dataset attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformValue<string> Dataset
    {
        get => new TerraformReference<string>(this, "dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
    {
        get => new TerraformReference<string>(this, "policy_data");
    }

}
