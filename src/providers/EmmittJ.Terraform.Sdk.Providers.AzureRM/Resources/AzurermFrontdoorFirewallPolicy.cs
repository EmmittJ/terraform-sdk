using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFirewallPolicyCustomRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Action { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Priority { get; set; }

    /// <summary>
    /// The rate_limit_duration_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("rate_limit_duration_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RateLimitDurationInMinutes { get; set; }

    /// <summary>
    /// The rate_limit_threshold attribute.
    /// </summary>
    [TerraformPropertyName("rate_limit_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RateLimitThreshold { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for managed_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFirewallPolicyManagedRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorFirewallPolicyTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_frontdoor_firewall_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermFrontdoorFirewallPolicy : TerraformResource
{
    public AzurermFrontdoorFirewallPolicy(string name) : base("azurerm_frontdoor_firewall_policy", name)
    {
    }

    /// <summary>
    /// The custom_block_response_body attribute.
    /// </summary>
    [TerraformPropertyName("custom_block_response_body")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomBlockResponseBody { get; set; }

    /// <summary>
    /// The custom_block_response_status_code attribute.
    /// </summary>
    [TerraformPropertyName("custom_block_response_status_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? CustomBlockResponseStatusCode { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    [TerraformPropertyName("redirect_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RedirectUrl { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for custom_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 CustomRule block(s) allowed")]
    [TerraformPropertyName("custom_rule")]
    public TerraformList<TerraformBlock<AzurermFrontdoorFirewallPolicyCustomRuleBlock>>? CustomRule { get; set; } = new();

    /// <summary>
    /// Block for managed_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 ManagedRule block(s) allowed")]
    [TerraformPropertyName("managed_rule")]
    public TerraformList<TerraformBlock<AzurermFrontdoorFirewallPolicyManagedRuleBlock>>? ManagedRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFrontdoorFirewallPolicyTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The frontend_endpoint_ids attribute.
    /// </summary>
    [TerraformPropertyName("frontend_endpoint_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> FrontendEndpointIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "frontend_endpoint_ids");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

}
