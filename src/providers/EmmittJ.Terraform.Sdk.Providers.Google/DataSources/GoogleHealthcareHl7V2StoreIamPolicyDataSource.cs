using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_healthcare_hl7_v2_store_iam_policy Terraform data source.
/// Retrieves information about a google_healthcare_hl7_v2_store_iam_policy.
/// </summary>
public partial class GoogleHealthcareHl7V2StoreIamPolicyDataSource(string name) : TerraformDataSource("google_healthcare_hl7_v2_store_iam_policy", name)
{
    /// <summary>
    /// The hl7_v2_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hl7V2StoreId is required")]
    public required TerraformValue<string> Hl7V2StoreId
    {
        get => GetArgument<TerraformValue<string>>("hl7_v2_store_id");
        set => SetArgument("hl7_v2_store_id", value);
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
