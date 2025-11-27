using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_iap_web_forwarding_rule_service_iam_policy Terraform data source.
/// Retrieves information about a google_iap_web_forwarding_rule_service_iam_policy.
/// </summary>
public partial class GoogleIapWebForwardingRuleServiceIamPolicyDataSource(string name) : TerraformDataSource("google_iap_web_forwarding_rule_service_iam_policy", name)
{
    /// <summary>
    /// The forwarding_rule_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardingRuleServiceName is required")]
    public required TerraformValue<string> ForwardingRuleServiceName
    {
        get => new TerraformReference<string>(this, "forwarding_rule_service_name");
        set => SetArgument("forwarding_rule_service_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
    {
        get => new TerraformReference<string>(this, "policy_data");
    }

}
