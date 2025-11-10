using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_healthcare_hl7_v2_store_iam_policy.
/// </summary>
public class GoogleHealthcareHl7V2StoreIamPolicyDataSource : TerraformDataSource
{
    public GoogleHealthcareHl7V2StoreIamPolicyDataSource(string name) : base("google_healthcare_hl7_v2_store_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("policy_data");
        SetOutput("hl7_v2_store_id");
        SetOutput("id");
    }

    /// <summary>
    /// The hl7_v2_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hl7V2StoreId is required")]
    public required TerraformProperty<string> Hl7V2StoreId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hl7_v2_store_id");
        set => SetProperty("hl7_v2_store_id", value);
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
