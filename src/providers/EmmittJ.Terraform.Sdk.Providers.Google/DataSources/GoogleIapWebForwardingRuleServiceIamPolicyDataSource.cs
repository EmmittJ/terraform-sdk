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
        SetOutput("etag");
        SetOutput("policy_data");
        SetOutput("forwarding_rule_service_name");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// The forwarding_rule_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardingRuleServiceName is required")]
    public required TerraformProperty<string> ForwardingRuleServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("forwarding_rule_service_name");
        set => SetProperty("forwarding_rule_service_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
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
