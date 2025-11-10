using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iap_web_forwarding_rule_service_iam_policy.
/// </summary>
public class GoogleIapWebForwardingRuleServiceIamPolicyDataSource : TerraformDataSource
{
    public GoogleIapWebForwardingRuleServiceIamPolicyDataSource(string name) : base("google_iap_web_forwarding_rule_service_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("etag");
        this.WithOutput("policy_data");
    }

    /// <summary>
    /// The forwarding_rule_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardingRuleServiceName is required")]
    public required TerraformProperty<string> ForwardingRuleServiceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("forwarding_rule_service_name");
        set => this.WithProperty("forwarding_rule_service_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
