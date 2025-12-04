using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_healthcare_fhir_store_iam_policy Terraform data source.
/// Retrieves information about a google_healthcare_fhir_store_iam_policy.
/// </summary>
public partial class GoogleHealthcareFhirStoreIamPolicyDataSource(string name) : TerraformDataSource("google_healthcare_fhir_store_iam_policy", name)
{
    /// <summary>
    /// The fhir_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FhirStoreId is required")]
    public required TerraformValue<string> FhirStoreId
    {
        get => GetArgument<TerraformValue<string>>("fhir_store_id");
        set => SetArgument("fhir_store_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
        => AsReference("policy_data");

}
