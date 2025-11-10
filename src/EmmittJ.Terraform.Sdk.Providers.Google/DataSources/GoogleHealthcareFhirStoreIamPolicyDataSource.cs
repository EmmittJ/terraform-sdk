using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_healthcare_fhir_store_iam_policy.
/// </summary>
public class GoogleHealthcareFhirStoreIamPolicyDataSource : TerraformDataSource
{
    public GoogleHealthcareFhirStoreIamPolicyDataSource(string name) : base("google_healthcare_fhir_store_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
        this.DeclareOutput("policy_data");
    }

    /// <summary>
    /// The fhir_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FhirStoreId is required")]
    public required TerraformProperty<string> FhirStoreId
    {
        get => GetProperty<TerraformProperty<string>>("fhir_store_id");
        set => this.WithProperty("fhir_store_id", value);
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
