using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dispatch_rules in GoogleAppEngineApplicationUrlDispatchRules.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineApplicationUrlDispatchRulesDispatchRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dispatch_rules";

    /// <summary>
    /// Domain name to match against. The wildcard &amp;quot;*&amp;quot; is supported if specified before a period: &amp;quot;*.&amp;quot;.
    /// Defaults to matching all domains: &amp;quot;*&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => GetArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// Pathname within the host. Must start with a &amp;quot;/&amp;quot;. A single &amp;quot;*&amp;quot; can be included at the end of the path.
    /// The sum of the lengths of the domain and path may not exceed 100 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Pathname within the host. Must start with a &amp;quot;/&amp;quot;. A single &amp;quot;*&amp;quot; can be included at the end of the path.
    /// The sum of the lengths of the domain and path may not exceed 100 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAppEngineApplicationUrlDispatchRules.
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineApplicationUrlDispatchRulesTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_app_engine_application_url_dispatch_rules Terraform resource.
/// Manages a google_app_engine_application_url_dispatch_rules resource.
/// </summary>
public partial class GoogleAppEngineApplicationUrlDispatchRules(string name) : TerraformResource("google_app_engine_application_url_dispatch_rules", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// DispatchRules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DispatchRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DispatchRules block(s) required")]
    public required TerraformList<GoogleAppEngineApplicationUrlDispatchRulesDispatchRulesBlock> DispatchRules
    {
        get => GetRequiredArgument<TerraformList<GoogleAppEngineApplicationUrlDispatchRulesDispatchRulesBlock>>("dispatch_rules");
        set => SetArgument("dispatch_rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAppEngineApplicationUrlDispatchRulesTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAppEngineApplicationUrlDispatchRulesTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
