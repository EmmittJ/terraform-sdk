using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_masking_policy in GoogleBigqueryDatapolicyv2DataPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatapolicyv2DataPolicyDataMaskingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_masking_policy";

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
    public TerraformValue<string>? PredefinedExpression
    {
        get => GetArgument<TerraformValue<string>>("predefined_expression");
        set => SetArgument("predefined_expression", value);
    }

    /// <summary>
    /// The name of the BigQuery routine that contains the custom masking
    /// routine, in the format of
    /// &#39;projects/{project_number}/datasets/{dataset_id}/routines/{routine_id}&#39;.
    /// </summary>
    public TerraformValue<string>? Routine
    {
        get => GetArgument<TerraformValue<string>>("routine");
        set => SetArgument("routine", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryDatapolicyv2DataPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDatapolicyv2DataPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_bigquery_datapolicyv2_data_policy Terraform resource.
/// Manages a google_bigquery_datapolicyv2_data_policy resource.
/// </summary>
public partial class GoogleBigqueryDatapolicyv2DataPolicy(string name) : TerraformResource("google_bigquery_datapolicyv2_data_policy", name)
{
    /// <summary>
    /// User-assigned (human readable) ID of the data policy that needs to be
    /// unique within a project. Used as {data_policy_id} in part of the resource
    /// name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyId is required")]
    public required TerraformValue<string> DataPolicyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_policy_id");
        set => SetArgument("data_policy_id", value);
    }

    /// <summary>
    /// Type of data policy.
    /// Possible values:
    /// DATA_MASKING_POLICY
    /// RAW_DATA_ACCESS_POLICY
    /// COLUMN_LEVEL_SECURITY_POLICY
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyType is required")]
    public required TerraformValue<string> DataPolicyType
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_policy_type");
        set => SetArgument("data_policy_type", value);
    }

    /// <summary>
    /// The etag for this Data Policy.
    /// This field is used for UpdateDataPolicy calls. If Data Policy exists, this
    /// field is required and must match the server&#39;s etag. It will also be
    /// populated in the response of GetDataPolicy, CreateDataPolicy, and
    /// UpdateDataPolicy calls.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => GetArgument<TerraformValue<string>>("etag") ?? CreateReference("etag");
        set => SetArgument("etag", value);
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
    public TerraformList<string> Grantees
    {
        get => GetArgument<TerraformList<string>>("grantees") ?? CreateReference("grantees");
        set => SetArgument("grantees", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Identifier. Resource name of this data policy, in the format of
    /// &#39;projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Policy tag resource name, in the format of
    /// &#39;projects/{project_number}/locations/{location_id}/taxonomies/{taxonomy_id}/policyTags/{policyTag_id}&#39;.
    /// policy_tag is supported only for V1 data policies.
    /// </summary>
    public TerraformValue<string> PolicyTag
        => CreateReference("policy_tag");

    /// <summary>
    /// The version of the Data Policy resource.
    /// Possible values:
    /// V1
    /// V2
    /// </summary>
    public TerraformValue<string> Version
        => CreateReference("version");

    /// <summary>
    /// DataMaskingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataMaskingPolicy block(s) allowed")]
    public TerraformList<GoogleBigqueryDatapolicyv2DataPolicyDataMaskingPolicyBlock>? DataMaskingPolicy
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatapolicyv2DataPolicyDataMaskingPolicyBlock>>("data_masking_policy");
        set => SetArgument("data_masking_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryDatapolicyv2DataPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryDatapolicyv2DataPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
