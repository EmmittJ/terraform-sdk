using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dispatch_rules in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineApplicationUrlDispatchRulesDispatchRulesBlock : TerraformBlock
{
    /// <summary>
    /// Domain name to match against. The wildcard &amp;quot;*&amp;quot; is supported if specified before a period: &amp;quot;*.&amp;quot;.
    /// Defaults to matching all domains: &amp;quot;*&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// Pathname within the host. Must start with a &amp;quot;/&amp;quot;. A single &amp;quot;*&amp;quot; can be included at the end of the path.
    /// The sum of the lengths of the domain and path may not exceed 100 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// Pathname within the host. Must start with a &amp;quot;/&amp;quot;. A single &amp;quot;*&amp;quot; can be included at the end of the path.
    /// The sum of the lengths of the domain and path may not exceed 100 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        set => SetProperty("service", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineApplicationUrlDispatchRulesTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_app_engine_application_url_dispatch_rules resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAppEngineApplicationUrlDispatchRules : TerraformResource
{
    public GoogleAppEngineApplicationUrlDispatchRules(string name) : base("google_app_engine_application_url_dispatch_rules", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("project");
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
    /// Block for dispatch_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DispatchRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DispatchRules block(s) required")]
    public List<GoogleAppEngineApplicationUrlDispatchRulesDispatchRulesBlock>? DispatchRules
    {
        set => SetProperty("dispatch_rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAppEngineApplicationUrlDispatchRulesTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
