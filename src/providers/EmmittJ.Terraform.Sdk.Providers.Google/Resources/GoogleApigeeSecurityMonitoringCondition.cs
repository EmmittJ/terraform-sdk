using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for include_all_resources in GoogleApigeeSecurityMonitoringCondition.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityMonitoringConditionIncludeAllResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_all_resources";

}


/// <summary>
/// Block type for timeouts in GoogleApigeeSecurityMonitoringCondition.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeSecurityMonitoringConditionTimeoutsBlock : TerraformBlock
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
/// Represents a google_apigee_security_monitoring_condition Terraform resource.
/// Manages a google_apigee_security_monitoring_condition resource.
/// </summary>
public partial class GoogleApigeeSecurityMonitoringCondition(string name) : TerraformResource("google_apigee_security_monitoring_condition", name)
{
    /// <summary>
    /// Resource ID of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConditionId is required")]
    public required TerraformValue<string> ConditionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("condition_id");
        set => SetArgument("condition_id", value);
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
    /// The Apigee Organization associated with the Apigee Security Monitoring Condition,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => GetRequiredArgument<TerraformValue<string>>("org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Profile is required")]
    public required TerraformValue<string> Profile
    {
        get => GetRequiredArgument<TerraformValue<string>>("profile");
        set => SetArgument("profile", value);
    }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The timestamp at which this profile was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Name of the security monitoring condition resource,
    /// in the format &#39;organizations/{{org_name}}/securityMonitoringConditions/{{condition_id}}&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Total number of deployed resources within scope.
    /// </summary>
    public TerraformValue<double> TotalDeployedResources
        => AsReference("total_deployed_resources");

    /// <summary>
    /// Total number of monitored resources within this condition.
    /// </summary>
    public TerraformValue<double> TotalMonitoredResources
        => AsReference("total_monitored_resources");

    /// <summary>
    /// The timestamp at which this profile was most recently updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// IncludeAllResources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeAllResources block(s) allowed")]
    public TerraformList<GoogleApigeeSecurityMonitoringConditionIncludeAllResourcesBlock>? IncludeAllResources
    {
        get => GetArgument<TerraformList<GoogleApigeeSecurityMonitoringConditionIncludeAllResourcesBlock>>("include_all_resources");
        set => SetArgument("include_all_resources", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeSecurityMonitoringConditionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeSecurityMonitoringConditionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
