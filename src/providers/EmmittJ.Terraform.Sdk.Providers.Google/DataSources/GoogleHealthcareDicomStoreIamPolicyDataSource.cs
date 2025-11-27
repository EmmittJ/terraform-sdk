using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_healthcare_dicom_store_iam_policy Terraform data source.
/// Retrieves information about a google_healthcare_dicom_store_iam_policy.
/// </summary>
public partial class GoogleHealthcareDicomStoreIamPolicyDataSource(string name) : TerraformDataSource("google_healthcare_dicom_store_iam_policy", name)
{
    /// <summary>
    /// The dicom_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DicomStoreId is required")]
    public required TerraformValue<string> DicomStoreId
    {
        get => new TerraformReference<string>(this, "dicom_store_id");
        set => SetArgument("dicom_store_id", value);
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
