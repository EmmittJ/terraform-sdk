using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_masking_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatapolicyv2DataPolicyDataMaskingPolicyBlock : ITerraformBlock
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
    [TerraformPropertyName("predefined_expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PredefinedExpression { get; set; }

    /// <summary>
    /// The name of the BigQuery routine that contains the custom masking
    /// routine, in the format of
    /// &#39;projects/{project_number}/datasets/{dataset_id}/routines/{routine_id}&#39;.
    /// </summary>
    [TerraformPropertyName("routine")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Routine { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDatapolicyv2DataPolicyTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_datapolicyv2_data_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryDatapolicyv2DataPolicy : TerraformResource
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
    [TerraformPropertyName("data_policy_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataPolicyId { get; set; }

    /// <summary>
    /// Type of data policy.
    /// Possible values:
    /// DATA_MASKING_POLICY
    /// RAW_DATA_ACCESS_POLICY
    /// COLUMN_LEVEL_SECURITY_POLICY
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyType is required")]
    [TerraformPropertyName("data_policy_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataPolicyType { get; set; }

    /// <summary>
    /// The etag for this Data Policy.
    /// This field is used for UpdateDataPolicy calls. If Data Policy exists, this
    /// field is required and must match the server&#39;s etag. It will also be
    /// populated in the response of GetDataPolicy, CreateDataPolicy, and
    /// UpdateDataPolicy calls.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Etag { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

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
    [TerraformPropertyName("grantees")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> Grantees { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "grantees");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for data_masking_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataMaskingPolicy block(s) allowed")]
    [TerraformPropertyName("data_masking_policy")]
    public TerraformList<TerraformBlock<GoogleBigqueryDatapolicyv2DataPolicyDataMaskingPolicyBlock>>? DataMaskingPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryDatapolicyv2DataPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Identifier. Resource name of this data policy, in the format of
    /// &#39;projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Policy tag resource name, in the format of
    /// &#39;projects/{project_number}/locations/{location_id}/taxonomies/{taxonomy_id}/policyTags/{policyTag_id}&#39;.
    /// policy_tag is supported only for V1 data policies.
    /// </summary>
    [TerraformPropertyName("policy_tag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PolicyTag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy_tag");

    /// <summary>
    /// The version of the Data Policy resource.
    /// Possible values:
    /// V1
    /// V2
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
