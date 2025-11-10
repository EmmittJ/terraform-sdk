using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_healthcare_dicom_store_iam_policy resource.
/// </summary>
public class GoogleHealthcareDicomStoreIamPolicy : TerraformResource
{
    public GoogleHealthcareDicomStoreIamPolicy(string name) : base("google_healthcare_dicom_store_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The dicom_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DicomStoreId is required")]
    public required TerraformProperty<string> DicomStoreId
    {
        get => GetProperty<TerraformProperty<string>>("dicom_store_id");
        set => this.WithProperty("dicom_store_id", value);
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
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformProperty<string> PolicyData
    {
        get => GetProperty<TerraformProperty<string>>("policy_data");
        set => this.WithProperty("policy_data", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
