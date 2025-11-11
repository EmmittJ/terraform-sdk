using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_masking_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDatapolicyv2DataPolicyDataMaskingPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// A predefined masking expression.
    /// Possible values:
    /// SHA256
    /// ALWAYS_NULL
    /// DEFAULT_MASKING_VALUE
    /// LAST_FOUR_CHARACTERS
    /// FIRST_FOUR_CHARACTERS
    /// EMAIL_MASK
    /// DATE_YEAR_MASK
    /// RANDOM_HASH
    /// </summary>
    [TerraformProperty("predefined_expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PredefinedExpression { get; set; }

    /// <summary>
    /// The name of the BigQuery routine that contains the custom masking
    /// routine, in the format of
    /// &#39;projects/{project_number}/datasets/{dataset_id}/routines/{routine_id}&#39;.
    /// </summary>
    [TerraformProperty("routine")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Routine { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryDatapolicyv2DataPolicyTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_bigquery_datapolicyv2_data_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigqueryDatapolicyv2DataPolicy : TerraformResource
{
    public GoogleBigqueryDatapolicyv2DataPolicy(string name) : base("google_bigquery_datapolicyv2_data_policy", name)
    {
    }

    /// <summary>
    /// User-assigned (human readable) ID of the data policy that needs to be
    /// unique within a project. Used as {data_policy_id} in part of the resource
    /// name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyId is required")]
    [TerraformProperty("data_policy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataPolicyId { get; set; }

    /// <summary>
    /// Type of data policy.
    /// Possible values:
    /// DATA_MASKING_POLICY
    /// RAW_DATA_ACCESS_POLICY
    /// COLUMN_LEVEL_SECURITY_POLICY
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyType is required")]
    [TerraformProperty("data_policy_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataPolicyType { get; set; }

    /// <summary>
    /// The etag for this Data Policy.
    /// This field is used for UpdateDataPolicy calls. If Data Policy exists, this
    /// field is required and must match the server&#39;s etag. It will also be
    /// populated in the response of GetDataPolicy, CreateDataPolicy, and
    /// UpdateDataPolicy calls.
    /// </summary>
    [TerraformProperty("etag")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Etag { get; set; }

    /// <summary>
    /// The list of IAM principals that have Fine Grained Access to the underlying
    /// data goverened by this data policy.
    /// 
    /// Uses the [IAM V2 principal
    /// syntax](https://cloud.google.com/iam/docs/principal-identifiers#v2) Only
    /// supports principal types users, groups, serviceaccounts, cloudidentity.
    /// This field is supported in V2 Data Policy only. In case of V1 data policies
    /// (i.e. verion = 1 and policy_tag is set), this field is not populated.
    /// </summary>
    [TerraformProperty("grantees")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Grantees { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

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
    public partial TerraformList<TerraformBlock<GoogleBigqueryDatapolicyv2DataPolicyDataMaskingPolicyBlock>>? DataMaskingPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleBigqueryDatapolicyv2DataPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Identifier. Resource name of this data policy, in the format of
    /// &#39;projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Policy tag resource name, in the format of
    /// &#39;projects/{project_number}/locations/{location_id}/taxonomies/{taxonomy_id}/policyTags/{policyTag_id}&#39;.
    /// policy_tag is supported only for V1 data policies.
    /// </summary>
    [TerraformProperty("policy_tag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PolicyTag { get; }

    /// <summary>
    /// The version of the Data Policy resource.
    /// Possible values:
    /// V1
    /// V2
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

}
