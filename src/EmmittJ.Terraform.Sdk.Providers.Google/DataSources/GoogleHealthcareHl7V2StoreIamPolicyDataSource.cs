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
        this.DeclareOutput("etag");
        this.DeclareOutput("policy_data");
    }

    /// <summary>
    /// The hl7_v2_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hl7V2StoreId is required")]
    public required TerraformProperty<string> Hl7V2StoreId
    {
        get => GetProperty<TerraformProperty<string>>("hl7_v2_store_id");
        set => this.WithProperty("hl7_v2_store_id", value);
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
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
