using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_iap_web_region_forwarding_rule_service_iam_policy Terraform resource.
/// Manages a google_iap_web_region_forwarding_rule_service_iam_policy resource.
/// </summary>
public partial class GoogleIapWebRegionForwardingRuleServiceIamPolicy(string name) : TerraformResource("google_iap_web_region_forwarding_rule_service_iam_policy", name)
{
    /// <summary>
    /// The forwarding_rule_region_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardingRuleRegionServiceName is required")]
    public required TerraformValue<string> ForwardingRuleRegionServiceName
    {
        get => GetArgument<TerraformValue<string>>("forwarding_rule_region_service_name");
        set => SetArgument("forwarding_rule_region_service_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformValue<string> PolicyData
    {
        get => GetArgument<TerraformValue<string>>("policy_data");
        set => SetArgument("policy_data", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

}
