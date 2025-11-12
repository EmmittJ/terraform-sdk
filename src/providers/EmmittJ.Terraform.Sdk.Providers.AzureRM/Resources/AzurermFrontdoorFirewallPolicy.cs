using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFrontdoorFirewallPolicyCustomRuleBlock() : TerraformBlock("custom_rule")
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Priority { get; set; }

    /// <summary>
    /// The rate_limit_duration_in_minutes attribute.
    /// </summary>
    [TerraformProperty("rate_limit_duration_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RateLimitDurationInMinutes { get; set; }

    /// <summary>
    /// The rate_limit_threshold attribute.
    /// </summary>
    [TerraformProperty("rate_limit_threshold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RateLimitThreshold { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for managed_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFrontdoorFirewallPolicyManagedRuleBlock() : TerraformBlock("managed_rule")
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFrontdoorFirewallPolicyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_frontdoor_firewall_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermFrontdoorFirewallPolicy : TerraformResource
{
    public AzurermFrontdoorFirewallPolicy(string name) : base("azurerm_frontdoor_firewall_policy", name)
    {
    }

    /// <summary>
    /// The custom_block_response_body attribute.
    /// </summary>
    [TerraformProperty("custom_block_response_body")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomBlockResponseBody { get; set; }

    /// <summary>
    /// The custom_block_response_status_code attribute.
    /// </summary>
    [TerraformProperty("custom_block_response_status_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CustomBlockResponseStatusCode { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    [TerraformProperty("redirect_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RedirectUrl { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for custom_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 CustomRule block(s) allowed")]
    [TerraformProperty("custom_rule")]
    public TerraformList<AzurermFrontdoorFirewallPolicyCustomRuleBlock> CustomRule { get; set; } = new();

    /// <summary>
    /// Block for managed_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 ManagedRule block(s) allowed")]
    [TerraformProperty("managed_rule")]
    public TerraformList<AzurermFrontdoorFirewallPolicyManagedRuleBlock> ManagedRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermFrontdoorFirewallPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    [TerraformProperty("frontend_endpoint_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> FrontendEndpointIds { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

}
