using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_healthcare_fhir_store_iam_policy resource.
/// </summary>
public class GoogleHealthcareFhirStoreIamPolicy : TerraformResource
{
    public GoogleHealthcareFhirStoreIamPolicy(string name) : base("google_healthcare_fhir_store_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The fhir_store_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FhirStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fhir_store_id");
        set => this.WithProperty("fhir_store_id", value);
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
