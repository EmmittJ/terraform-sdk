using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_masking_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatapolicyDataPolicyDataMaskingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The available masking rules. Learn more here: https://cloud.google.com/bigquery/docs/column-data-masking-intro#masking_options. Possible values: [&amp;quot;SHA256&amp;quot;, &amp;quot;ALWAYS_NULL&amp;quot;, &amp;quot;DEFAULT_MASKING_VALUE&amp;quot;, &amp;quot;LAST_FOUR_CHARACTERS&amp;quot;, &amp;quot;FIRST_FOUR_CHARACTERS&amp;quot;, &amp;quot;EMAIL_MASK&amp;quot;, &amp;quot;DATE_YEAR_MASK&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? PredefinedExpression
    {
        get => GetProperty<TerraformProperty<string>>("predefined_expression");
        set => WithProperty("predefined_expression", value);
    }

    /// <summary>
    /// The name of the BigQuery routine that contains the custom masking routine, in the format of projects/{projectNumber}/datasets/{dataset_id}/routines/{routine_id}.
    /// </summary>
    public TerraformProperty<string>? Routine
    {
        get => GetProperty<TerraformProperty<string>>("routine");
        set => WithProperty("routine", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDatapolicyDataPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_bigquery_datapolicy_data_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyId is required")]
    public required TerraformProperty<string> DataPolicyId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_policy_id");
        set => this.WithProperty("data_policy_id", value);
    }

    /// <summary>
    /// The enrollment level of the service. Possible values: [&amp;quot;COLUMN_LEVEL_SECURITY_POLICY&amp;quot;, &amp;quot;DATA_MASKING_POLICY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyType is required")]
    public required TerraformProperty<string> DataPolicyType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_policy_type");
        set => this.WithProperty("data_policy_type", value);
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
    /// The name of the location of the data policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Policy tag resource name, in the format of projects/{project_number}/locations/{locationId}/taxonomies/{taxonomyId}/policyTags/{policyTag_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyTag is required")]
    public required TerraformProperty<string> PolicyTag
    {
        get => GetRequiredProperty<TerraformProperty<string>>("policy_tag");
        set => this.WithProperty("policy_tag", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for data_masking_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataMaskingPolicy block(s) allowed")]
    public List<GoogleBigqueryDatapolicyDataPolicyDataMaskingPolicyBlock>? DataMaskingPolicy
    {
        get => GetProperty<List<GoogleBigqueryDatapolicyDataPolicyDataMaskingPolicyBlock>>("data_masking_policy");
        set => this.WithProperty("data_masking_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryDatapolicyDataPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigqueryDatapolicyDataPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Resource name of this data policy, in the format of projects/{project_number}/locations/{locationId}/dataPolicies/{dataPolicyId}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
