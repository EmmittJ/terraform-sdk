using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigquery_datapolicy_data_policy resource.
/// </summary>
public class GoogleBigqueryDatapolicyDataPolicy : TerraformResource
{
    public GoogleBigqueryDatapolicyDataPolicy(string name) : base("google_bigquery_datapolicy_data_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// User-assigned (human readable) ID of the data policy that needs to be unique within a project. Used as {dataPolicyId} in part of the resource name.
    /// </summary>
    public string? DataPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_policy_id")?.Value;
        set => this.WithProperty("data_policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enrollment level of the service. Possible values: [&amp;quot;COLUMN_LEVEL_SECURITY_POLICY&amp;quot;, &amp;quot;DATA_MASKING_POLICY&amp;quot;]
    /// </summary>
    public string? DataPolicyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_policy_type")?.Value;
        set => this.WithProperty("data_policy_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name of the location of the data policy.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Policy tag resource name, in the format of projects/{project_number}/locations/{locationId}/taxonomies/{taxonomyId}/policyTags/{policyTag_id}.
    /// </summary>
    public string? PolicyTag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_tag")?.Value;
        set => this.WithProperty("policy_tag", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Resource name of this data policy, in the format of projects/{project_number}/locations/{locationId}/dataPolicies/{dataPolicyId}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
