using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for include_all_resources in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeSecurityMonitoringConditionIncludeAllResourcesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeSecurityMonitoringConditionTimeoutsBlock : TerraformBlock
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
/// Manages a google_apigee_security_monitoring_condition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeSecurityMonitoringCondition : TerraformResource
{
    public GoogleApigeeSecurityMonitoringCondition(string name) : base("google_apigee_security_monitoring_condition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("total_deployed_resources");
        SetOutput("total_monitored_resources");
        SetOutput("update_time");
        SetOutput("condition_id");
        SetOutput("id");
        SetOutput("org_id");
        SetOutput("profile");
        SetOutput("scope");
    }

    /// <summary>
    /// Resource ID of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConditionId is required")]
    public required TerraformProperty<string> ConditionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("condition_id");
        set => SetProperty("condition_id", value);
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
    /// The Apigee Organization associated with the Apigee Security Monitoring Condition,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Profile is required")]
    public required TerraformProperty<string> Profile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("profile");
        set => SetProperty("profile", value);
    }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// Block for include_all_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeAllResources block(s) allowed")]
    public List<GoogleApigeeSecurityMonitoringConditionIncludeAllResourcesBlock>? IncludeAllResources
    {
        set => SetProperty("include_all_resources", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeSecurityMonitoringConditionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp at which this profile was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Name of the security monitoring condition resource,
    /// in the format &#39;organizations/{{org_name}}/securityMonitoringConditions/{{condition_id}}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Total number of deployed resources within scope.
    /// </summary>
    public TerraformExpression TotalDeployedResources => this["total_deployed_resources"];

    /// <summary>
    /// Total number of monitored resources within this condition.
    /// </summary>
    public TerraformExpression TotalMonitoredResources => this["total_monitored_resources"];

    /// <summary>
    /// The timestamp at which this profile was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
