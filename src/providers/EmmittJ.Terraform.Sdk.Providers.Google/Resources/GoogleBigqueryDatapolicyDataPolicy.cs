using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_masking_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDatapolicyDataPolicyDataMaskingPolicyBlock() : TerraformBlock("data_masking_policy")
{
    /// <summary>
    /// The available masking rules. Learn more here: https://cloud.google.com/bigquery/docs/column-data-masking-intro#masking_options. Possible values: [&amp;quot;SHA256&amp;quot;, &amp;quot;ALWAYS_NULL&amp;quot;, &amp;quot;DEFAULT_MASKING_VALUE&amp;quot;, &amp;quot;LAST_FOUR_CHARACTERS&amp;quot;, &amp;quot;FIRST_FOUR_CHARACTERS&amp;quot;, &amp;quot;EMAIL_MASK&amp;quot;, &amp;quot;DATE_YEAR_MASK&amp;quot;]
    /// </summary>
    [TerraformProperty("predefined_expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PredefinedExpression { get; set; }

    /// <summary>
    /// The name of the BigQuery routine that contains the custom masking routine, in the format of projects/{projectNumber}/datasets/{dataset_id}/routines/{routine_id}.
    /// </summary>
    [TerraformProperty("routine")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Routine { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryDatapolicyDataPolicyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_datapolicy_data_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigqueryDatapolicyDataPolicy : TerraformResource
{
    public GoogleBigqueryDatapolicyDataPolicy(string name) : base("google_bigquery_datapolicy_data_policy", name)
    {
    }

    /// <summary>
    /// User-assigned (human readable) ID of the data policy that needs to be unique within a project. Used as {dataPolicyId} in part of the resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyId is required")]
    [TerraformProperty("data_policy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataPolicyId { get; set; }

    /// <summary>
    /// The enrollment level of the service. Possible values: [&amp;quot;COLUMN_LEVEL_SECURITY_POLICY&amp;quot;, &amp;quot;DATA_MASKING_POLICY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyType is required")]
    [TerraformProperty("data_policy_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataPolicyType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the location of the data policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Policy tag resource name, in the format of projects/{project_number}/locations/{locationId}/taxonomies/{taxonomyId}/policyTags/{policyTag_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyTag is required")]
    [TerraformProperty("policy_tag")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyTag { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for data_masking_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataMaskingPolicy block(s) allowed")]
    [TerraformProperty("data_masking_policy")]
    public TerraformList<GoogleBigqueryDatapolicyDataPolicyDataMaskingPolicyBlock> DataMaskingPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBigqueryDatapolicyDataPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Resource name of this data policy, in the format of projects/{project_number}/locations/{locationId}/dataPolicies/{dataPolicyId}.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
