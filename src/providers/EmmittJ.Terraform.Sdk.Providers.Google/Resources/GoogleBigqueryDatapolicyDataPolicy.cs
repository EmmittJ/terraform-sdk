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
        set => SetProperty("predefined_expression", value);
    }

    /// <summary>
    /// The name of the BigQuery routine that contains the custom masking routine, in the format of projects/{projectNumber}/datasets/{dataset_id}/routines/{routine_id}.
    /// </summary>
    public TerraformProperty<string>? Routine
    {
        set => SetProperty("routine", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("name");
        SetOutput("data_policy_id");
        SetOutput("data_policy_type");
        SetOutput("id");
        SetOutput("location");
        SetOutput("policy_tag");
        SetOutput("project");
    }

    /// <summary>
    /// User-assigned (human readable) ID of the data policy that needs to be unique within a project. Used as {dataPolicyId} in part of the resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyId is required")]
    public required TerraformProperty<string> DataPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_policy_id");
        set => SetProperty("data_policy_id", value);
    }

    /// <summary>
    /// The enrollment level of the service. Possible values: [&amp;quot;COLUMN_LEVEL_SECURITY_POLICY&amp;quot;, &amp;quot;DATA_MASKING_POLICY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyType is required")]
    public required TerraformProperty<string> DataPolicyType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_policy_type");
        set => SetProperty("data_policy_type", value);
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
    /// The name of the location of the data policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Policy tag resource name, in the format of projects/{project_number}/locations/{locationId}/taxonomies/{taxonomyId}/policyTags/{policyTag_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyTag is required")]
    public required TerraformProperty<string> PolicyTag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_tag");
        set => SetProperty("policy_tag", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for data_masking_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataMaskingPolicy block(s) allowed")]
    public List<GoogleBigqueryDatapolicyDataPolicyDataMaskingPolicyBlock>? DataMaskingPolicy
    {
        set => SetProperty("data_masking_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryDatapolicyDataPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Resource name of this data policy, in the format of projects/{project_number}/locations/{locationId}/dataPolicies/{dataPolicyId}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
