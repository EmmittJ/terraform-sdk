using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for custom_provider in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyCustomProviderBlock : TerraformBlock
{
}

/// <summary>
/// Block type for http_rules in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlock : TerraformBlock
{
    /// <summary>
    /// CEL expression that describes the conditions to be satisfied for the action. The result of the CEL expression is ANDed with the from and to. Refer to the CEL language reference for a list of available attributes.
    /// </summary>
    public TerraformProperty<string>? When
    {
        get => GetProperty<TerraformProperty<string>>("when");
        set => WithProperty("when", value);
    }

}

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyTargetBlock : TerraformBlock
{
    /// <summary>
    /// All gateways and forwarding rules referenced by this policy and extensions must share the same load balancing scheme.
    /// For more information, refer to [Backend services overview](https://cloud.google.com/load-balancing/docs/backend-service). Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;, &amp;quot;INTERNAL_SELF_MANAGED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingScheme is required")]
    public required TerraformProperty<string> LoadBalancingScheme
    {
        get => GetProperty<TerraformProperty<string>>("load_balancing_scheme");
        set => WithProperty("load_balancing_scheme", value);
    }

    /// <summary>
    /// A list of references to the Forwarding Rules on which this policy will be applied.
    /// </summary>
    public List<TerraformProperty<string>>? Resources
    {
        get => GetProperty<List<TerraformProperty<string>>>("resources");
        set => WithProperty("resources", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_security_authz_policy resource.
/// </summary>
public class GoogleNetworkSecurityAuthzPolicy : TerraformResource
{
    public GoogleNetworkSecurityAuthzPolicy(string name) : base("google_network_security_authz_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// When the action is CUSTOM, customProvider must be specified.
    /// When the action is ALLOW, only requests matching the policy will be allowed.
    /// When the action is DENY, only requests matching the policy will be denied.
    /// 
    /// When a request arrives, the policies are evaluated in the following order:
    /// 1. If there is a CUSTOM policy that matches the request, the CUSTOM policy is evaluated using the custom authorization providers and the request is denied if the provider rejects the request.
    /// 2. If there are any DENY policies that match the request, the request is denied.
    /// 3. If there are no ALLOW policies for the resource or if any of the ALLOW policies match the request, the request is allowed.
    /// 4. Else the request is denied by default if none of the configured AuthzPolicies with ALLOW action match the request. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;, &amp;quot;CUSTOM&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Set of labels associated with the AuthzExtension resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Identifier. Name of the AuthzPolicy resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for custom_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomProvider block(s) allowed")]
    public List<GoogleNetworkSecurityAuthzPolicyCustomProviderBlock>? CustomProvider
    {
        get => GetProperty<List<GoogleNetworkSecurityAuthzPolicyCustomProviderBlock>>("custom_provider");
        set => this.WithProperty("custom_provider", value);
    }

    /// <summary>
    /// Block for http_rules.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleNetworkSecurityAuthzPolicyHttpRulesBlock>? HttpRules
    {
        get => GetProperty<List<GoogleNetworkSecurityAuthzPolicyHttpRulesBlock>>("http_rules");
        set => this.WithProperty("http_rules", value);
    }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public List<GoogleNetworkSecurityAuthzPolicyTargetBlock>? Target
    {
        get => GetProperty<List<GoogleNetworkSecurityAuthzPolicyTargetBlock>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkSecurityAuthzPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkSecurityAuthzPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
