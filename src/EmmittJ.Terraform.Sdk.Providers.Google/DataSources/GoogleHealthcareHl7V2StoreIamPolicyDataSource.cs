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
    public string? Hl7V2StoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hl7_v2_store_id")?.Value;
        set => this.WithProperty("hl7_v2_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
