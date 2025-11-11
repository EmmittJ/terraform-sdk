using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dispatch_rules in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineApplicationUrlDispatchRulesDispatchRulesBlock : TerraformBlockBase
{
    /// <summary>
    /// Domain name to match against. The wildcard &amp;quot;*&amp;quot; is supported if specified before a period: &amp;quot;*.&amp;quot;.
    /// Defaults to matching all domains: &amp;quot;*&amp;quot;.
    /// </summary>
    [TerraformProperty("domain")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Domain { get; set; }

    /// <summary>
    /// Pathname within the host. Must start with a &amp;quot;/&amp;quot;. A single &amp;quot;*&amp;quot; can be included at the end of the path.
    /// The sum of the lengths of the domain and path may not exceed 100 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// Pathname within the host. Must start with a &amp;quot;/&amp;quot;. A single &amp;quot;*&amp;quot; can be included at the end of the path.
    /// The sum of the lengths of the domain and path may not exceed 100 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Service { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAppEngineApplicationUrlDispatchRulesTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_app_engine_application_url_dispatch_rules resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAppEngineApplicationUrlDispatchRules : TerraformResource
{
    public GoogleAppEngineApplicationUrlDispatchRules(string name) : base("google_app_engine_application_url_dispatch_rules", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for dispatch_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DispatchRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DispatchRules block(s) required")]
    [TerraformProperty("dispatch_rules")]
    public TerraformList<TerraformBlock<GoogleAppEngineApplicationUrlDispatchRulesDispatchRulesBlock>>? DispatchRules { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleAppEngineApplicationUrlDispatchRulesTimeoutsBlock>? Timeouts { get; set; }

}
