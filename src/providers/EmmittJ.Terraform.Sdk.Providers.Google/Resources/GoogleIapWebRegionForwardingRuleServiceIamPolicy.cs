using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iap_web_region_forwarding_rule_service_iam_policy resource.
/// </summary>
public class GoogleIapWebRegionForwardingRuleServiceIamPolicy : TerraformResource
{
    public GoogleIapWebRegionForwardingRuleServiceIamPolicy(string name) : base("google_iap_web_region_forwarding_rule_service_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("forwarding_rule_region_service_name");
        SetOutput("id");
        SetOutput("policy_data");
        SetOutput("project");
        SetOutput("region");
    }

    /// <summary>
    /// The forwarding_rule_region_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardingRuleRegionServiceName is required")]
    public required TerraformProperty<string> ForwardingRuleRegionServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("forwarding_rule_region_service_name");
        set => SetProperty("forwarding_rule_region_service_name", value);
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
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformProperty<string> PolicyData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_data");
        set => SetProperty("policy_data", value);
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
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
