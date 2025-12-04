using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_healthcare_hl7_v2_store_iam_policy Terraform resource.
/// Manages a google_healthcare_hl7_v2_store_iam_policy resource.
/// </summary>
public partial class GoogleHealthcareHl7V2StoreIamPolicy(string name) : TerraformResource("google_healthcare_hl7_v2_store_iam_policy", name)
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
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformValue<string> PolicyData
    {
        get => GetArgument<TerraformValue<string>>("policy_data");
        set => SetArgument("policy_data", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

}
