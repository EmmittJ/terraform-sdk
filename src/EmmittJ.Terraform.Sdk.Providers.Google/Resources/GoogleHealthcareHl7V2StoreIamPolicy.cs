using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_healthcare_hl7_v2_store_iam_policy resource.
/// </summary>
public class GoogleHealthcareHl7V2StoreIamPolicy : TerraformResource
{
    public GoogleHealthcareHl7V2StoreIamPolicy(string name) : base("google_healthcare_hl7_v2_store_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The hl7_v2_store_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Hl7V2StoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hl7_v2_store_id");
        set => this.WithProperty("hl7_v2_store_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_data");
        set => this.WithProperty("policy_data", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
