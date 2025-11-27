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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "condition_id");
        set => SetArgument("condition_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee Security Monitoring Condition,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Profile is required")]
    public required TerraformValue<string> Profile
    {
        get => new TerraformReference<string>(this, "profile");
        set => SetArgument("profile", value);
    }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The timestamp at which this profile was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Name of the security monitoring condition resource,
    /// in the format &#39;organizations/{{org_name}}/securityMonitoringConditions/{{condition_id}}&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Total number of deployed resources within scope.
    /// </summary>
    public TerraformValue<double> TotalDeployedResources
    {
        get => new TerraformReference<double>(this, "total_deployed_resources");
    }

    /// <summary>
    /// Total number of monitored resources within this condition.
    /// </summary>
    public TerraformValue<double> TotalMonitoredResources
    {
        get => new TerraformReference<double>(this, "total_monitored_resources");
    }

    /// <summary>
    /// The timestamp at which this profile was most recently updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

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
