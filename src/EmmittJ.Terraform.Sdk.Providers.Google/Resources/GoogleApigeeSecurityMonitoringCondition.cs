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
/// Manages a google_apigee_security_monitoring_condition resource.
/// </summary>
public class GoogleApigeeSecurityMonitoringCondition : TerraformResource
{
    public GoogleApigeeSecurityMonitoringCondition(string name) : base("google_apigee_security_monitoring_condition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("total_deployed_resources");
        this.DeclareOutput("total_monitored_resources");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Resource ID of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConditionId is required")]
    public required TerraformProperty<string> ConditionId
    {
        get => GetProperty<TerraformProperty<string>>("condition_id");
        set => this.WithProperty("condition_id", value);
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
    /// The Apigee Organization associated with the Apigee Security Monitoring Condition,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Profile is required")]
    public required TerraformProperty<string> Profile
    {
        get => GetProperty<TerraformProperty<string>>("profile");
        set => this.WithProperty("profile", value);
    }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// Block for include_all_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeAllResources block(s) allowed")]
    public List<GoogleApigeeSecurityMonitoringConditionIncludeAllResourcesBlock>? IncludeAllResources
    {
        get => GetProperty<List<GoogleApigeeSecurityMonitoringConditionIncludeAllResourcesBlock>>("include_all_resources");
        set => this.WithProperty("include_all_resources", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeSecurityMonitoringConditionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeSecurityMonitoringConditionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
