using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_masking_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatapolicyDataPolicyDataMaskingPolicyBlock
{
    /// <summary>
    /// The available masking rules. Learn more here: https://cloud.google.com/bigquery/docs/column-data-masking-intro#masking_options. Possible values: [&amp;quot;SHA256&amp;quot;, &amp;quot;ALWAYS_NULL&amp;quot;, &amp;quot;DEFAULT_MASKING_VALUE&amp;quot;, &amp;quot;LAST_FOUR_CHARACTERS&amp;quot;, &amp;quot;FIRST_FOUR_CHARACTERS&amp;quot;, &amp;quot;EMAIL_MASK&amp;quot;, &amp;quot;DATE_YEAR_MASK&amp;quot;]
    /// </summary>
    [TerraformPropertyName("predefined_expression")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PredefinedExpression { get; set; }

    /// <summary>
    /// The name of the BigQuery routine that contains the custom masking routine, in the format of projects/{projectNumber}/datasets/{dataset_id}/routines/{routine_id}.
    /// </summary>
    [TerraformPropertyName("routine")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Routine { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDatapolicyDataPolicyTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_datapolicy_data_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryDatapolicyDataPolicy : TerraformResource
{
    public GoogleBigqueryDatapolicyDataPolicy(string name) : base("google_bigquery_datapolicy_data_policy", name)
    {
    }

    /// <summary>
    /// User-assigned (human readable) ID of the data policy that needs to be unique within a project. Used as {dataPolicyId} in part of the resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyId is required")]
    [TerraformPropertyName("data_policy_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataPolicyId { get; set; }

    /// <summary>
    /// The enrollment level of the service. Possible values: [&amp;quot;COLUMN_LEVEL_SECURITY_POLICY&amp;quot;, &amp;quot;DATA_MASKING_POLICY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyType is required")]
    [TerraformPropertyName("data_policy_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataPolicyType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name of the location of the data policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Policy tag resource name, in the format of projects/{project_number}/locations/{locationId}/taxonomies/{taxonomyId}/policyTags/{policyTag_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyTag is required")]
    [TerraformPropertyName("policy_tag")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PolicyTag { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for data_masking_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataMaskingPolicy block(s) allowed")]
    [TerraformPropertyName("data_masking_policy")]
    public TerraformList<TerraformBlock<GoogleBigqueryDatapolicyDataPolicyDataMaskingPolicyBlock>>? DataMaskingPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryDatapolicyDataPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Resource name of this data policy, in the format of projects/{project_number}/locations/{locationId}/dataPolicies/{dataPolicyId}.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
