using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_masking_policy in GoogleBigqueryDatapolicyDataPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatapolicyDataPolicyDataMaskingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_masking_policy";

    /// <summary>
    /// The available masking rules. Learn more here: https://cloud.google.com/bigquery/docs/column-data-masking-intro#masking_options. Possible values: [&amp;quot;SHA256&amp;quot;, &amp;quot;ALWAYS_NULL&amp;quot;, &amp;quot;DEFAULT_MASKING_VALUE&amp;quot;, &amp;quot;LAST_FOUR_CHARACTERS&amp;quot;, &amp;quot;FIRST_FOUR_CHARACTERS&amp;quot;, &amp;quot;EMAIL_MASK&amp;quot;, &amp;quot;DATE_YEAR_MASK&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PredefinedExpression
    {
        get => GetArgument<TerraformValue<string>>("predefined_expression");
        set => SetArgument("predefined_expression", value);
    }

    /// <summary>
    /// The name of the BigQuery routine that contains the custom masking routine, in the format of projects/{projectNumber}/datasets/{dataset_id}/routines/{routine_id}.
    /// </summary>
    public TerraformValue<string>? Routine
    {
        get => GetArgument<TerraformValue<string>>("routine");
        set => SetArgument("routine", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryDatapolicyDataPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDatapolicyDataPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_bigquery_datapolicy_data_policy Terraform resource.
/// Manages a google_bigquery_datapolicy_data_policy resource.
/// </summary>
public partial class GoogleBigqueryDatapolicyDataPolicy(string name) : TerraformResource("google_bigquery_datapolicy_data_policy", name)
{
    /// <summary>
    /// User-assigned (human readable) ID of the data policy that needs to be unique within a project. Used as {dataPolicyId} in part of the resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyId is required")]
    public required TerraformValue<string> DataPolicyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_policy_id");
        set => SetArgument("data_policy_id", value);
    }

    /// <summary>
    /// The enrollment level of the service. Possible values: [&amp;quot;COLUMN_LEVEL_SECURITY_POLICY&amp;quot;, &amp;quot;DATA_MASKING_POLICY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyType is required")]
    public required TerraformValue<string> DataPolicyType
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_policy_type");
        set => SetArgument("data_policy_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the location of the data policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Policy tag resource name, in the format of projects/{project_number}/locations/{locationId}/taxonomies/{taxonomyId}/policyTags/{policyTag_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyTag is required")]
    public required TerraformValue<string> PolicyTag
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy_tag");
        set => SetArgument("policy_tag", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Resource name of this data policy, in the format of projects/{project_number}/locations/{locationId}/dataPolicies/{dataPolicyId}.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// DataMaskingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataMaskingPolicy block(s) allowed")]
    public TerraformList<GoogleBigqueryDatapolicyDataPolicyDataMaskingPolicyBlock>? DataMaskingPolicy
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatapolicyDataPolicyDataMaskingPolicyBlock>>("data_masking_policy");
        set => SetArgument("data_masking_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryDatapolicyDataPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryDatapolicyDataPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
