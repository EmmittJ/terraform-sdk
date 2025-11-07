using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformProperty<string>? ConditionId
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
    public TerraformProperty<string>? OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    public TerraformProperty<string>? Profile
    {
        get => GetProperty<TerraformProperty<string>>("profile");
        set => this.WithProperty("profile", value);
    }

    /// <summary>
    /// ID of security profile of the security monitoring condition.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
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
