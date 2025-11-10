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
        get => GetProperty<TerraformProperty<string>>("domain");
        set => WithProperty("domain", value);
    }

    /// <summary>
    /// Pathname within the host. Must start with a &amp;quot;/&amp;quot;. A single &amp;quot;*&amp;quot; can be included at the end of the path.
    /// The sum of the lengths of the domain and path may not exceed 100 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// Pathname within the host. Must start with a &amp;quot;/&amp;quot;. A single &amp;quot;*&amp;quot; can be included at the end of the path.
    /// The sum of the lengths of the domain and path may not exceed 100 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => WithProperty("service", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_app_engine_application_url_dispatch_rules resource.
/// </summary>
public class GoogleAppEngineApplicationUrlDispatchRules : TerraformResource
{
    public GoogleAppEngineApplicationUrlDispatchRules(string name) : base("google_app_engine_application_url_dispatch_rules", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// Block for dispatch_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DispatchRules block(s) required")]
    public List<GoogleAppEngineApplicationUrlDispatchRulesDispatchRulesBlock>? DispatchRules
    {
        get => GetProperty<List<GoogleAppEngineApplicationUrlDispatchRulesDispatchRulesBlock>>("dispatch_rules");
        set => this.WithProperty("dispatch_rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAppEngineApplicationUrlDispatchRulesTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleAppEngineApplicationUrlDispatchRulesTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
