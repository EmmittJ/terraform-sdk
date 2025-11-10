using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_masking_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatapolicyv2DataPolicyDataMaskingPolicyBlock : TerraformBlock
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
    public TerraformProperty<string>? PredefinedExpression
    {
        get => GetProperty<TerraformProperty<string>>("predefined_expression");
        set => WithProperty("predefined_expression", value);
    }

    /// <summary>
    /// The name of the BigQuery routine that contains the custom masking
    /// routine, in the format of
    /// &#39;projects/{project_number}/datasets/{dataset_id}/routines/{routine_id}&#39;.
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
public class GoogleBigqueryDatapolicyv2DataPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a google_bigquery_datapolicyv2_data_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryDatapolicyv2DataPolicy : TerraformResource
{
    public GoogleBigqueryDatapolicyv2DataPolicy(string name) : base("google_bigquery_datapolicyv2_data_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
        this.WithOutput("policy_tag");
        this.WithOutput("version");
    }

    /// <summary>
    /// User-assigned (human readable) ID of the data policy that needs to be
    /// unique within a project. Used as {data_policy_id} in part of the resource
    /// name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyId is required")]
    public required TerraformProperty<string> DataPolicyId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_policy_id");
        set => this.WithProperty("data_policy_id", value);
    }

    /// <summary>
    /// Type of data policy.
    /// Possible values:
    /// DATA_MASKING_POLICY
    /// RAW_DATA_ACCESS_POLICY
    /// COLUMN_LEVEL_SECURITY_POLICY
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyType is required")]
    public required TerraformProperty<string> DataPolicyType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_policy_type");
        set => this.WithProperty("data_policy_type", value);
    }

    /// <summary>
    /// The etag for this Data Policy.
    /// This field is used for UpdateDataPolicy calls. If Data Policy exists, this
    /// field is required and must match the server&#39;s etag. It will also be
    /// populated in the response of GetDataPolicy, CreateDataPolicy, and
    /// UpdateDataPolicy calls.
    /// </summary>
    public TerraformProperty<string>? Etag
    {
        get => GetProperty<TerraformProperty<string>>("etag");
        set => this.WithProperty("etag", value);
    }

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
    public List<TerraformProperty<string>>? Grantees
    {
        get => GetProperty<List<TerraformProperty<string>>>("grantees");
        set => this.WithProperty("grantees", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    public List<GoogleBigqueryDatapolicyv2DataPolicyDataMaskingPolicyBlock>? DataMaskingPolicy
    {
        get => GetProperty<List<GoogleBigqueryDatapolicyv2DataPolicyDataMaskingPolicyBlock>>("data_masking_policy");
        set => this.WithProperty("data_masking_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryDatapolicyv2DataPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigqueryDatapolicyv2DataPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Identifier. Resource name of this data policy, in the format of
    /// &#39;projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Policy tag resource name, in the format of
    /// &#39;projects/{project_number}/locations/{location_id}/taxonomies/{taxonomy_id}/policyTags/{policyTag_id}&#39;.
    /// policy_tag is supported only for V1 data policies.
    /// </summary>
    public TerraformExpression PolicyTag => this["policy_tag"];

    /// <summary>
    /// The version of the Data Policy resource.
    /// Possible values:
    /// V1
    /// V2
    /// </summary>
    public TerraformExpression Version => this["version"];

}
