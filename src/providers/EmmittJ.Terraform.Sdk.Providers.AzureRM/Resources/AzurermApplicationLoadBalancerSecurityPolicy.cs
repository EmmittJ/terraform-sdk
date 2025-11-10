using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationLoadBalancerSecurityPolicyTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
/// Manages a azurerm_application_load_balancer_security_policy resource.
/// </summary>
public class AzurermApplicationLoadBalancerSecurityPolicy : TerraformResource
{
    public AzurermApplicationLoadBalancerSecurityPolicy(string name) : base("azurerm_application_load_balancer_security_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_load_balancer_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("tags");
        SetOutput("web_application_firewall_policy_id");
    }

    /// <summary>
    /// The application_load_balancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationLoadBalancerId is required")]
    public required TerraformProperty<string> ApplicationLoadBalancerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_load_balancer_id");
        set => SetProperty("application_load_balancer_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The web_application_firewall_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebApplicationFirewallPolicyId is required")]
    public required TerraformProperty<string> WebApplicationFirewallPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("web_application_firewall_policy_id");
        set => SetProperty("web_application_firewall_policy_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApplicationLoadBalancerSecurityPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
