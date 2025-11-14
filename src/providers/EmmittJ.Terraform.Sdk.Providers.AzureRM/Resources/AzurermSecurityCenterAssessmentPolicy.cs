using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterAssessmentPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_security_center_assessment_policy resource.
/// </summary>
public class AzurermSecurityCenterAssessmentPolicy : TerraformResource
{
    public AzurermSecurityCenterAssessmentPolicy(string name) : base("azurerm_security_center_assessment_policy", name)
    {
    }

    /// <summary>
    /// The categories attribute.
    /// </summary>
    [TerraformArgument("categories")]
    public TerraformSet<string> Categories
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "categories").ResolveNodes(ctx));
        set => SetArgument("categories", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformArgument("description")]
    public required TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformArgument("display_name")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The implementation_effort attribute.
    /// </summary>
    [TerraformArgument("implementation_effort")]
    public TerraformValue<string>? ImplementationEffort
    {
        get => new TerraformReference<string>(this, "implementation_effort");
        set => SetArgument("implementation_effort", value);
    }

    /// <summary>
    /// The remediation_description attribute.
    /// </summary>
    [TerraformArgument("remediation_description")]
    public TerraformValue<string>? RemediationDescription
    {
        get => new TerraformReference<string>(this, "remediation_description");
        set => SetArgument("remediation_description", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformArgument("severity")]
    public TerraformValue<string>? Severity
    {
        get => new TerraformReference<string>(this, "severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The threats attribute.
    /// </summary>
    [TerraformArgument("threats")]
    public TerraformSet<string>? Threats
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "threats").ResolveNodes(ctx));
        set => SetArgument("threats", value);
    }

    /// <summary>
    /// The user_impact attribute.
    /// </summary>
    [TerraformArgument("user_impact")]
    public TerraformValue<string>? UserImpact
    {
        get => new TerraformReference<string>(this, "user_impact");
        set => SetArgument("user_impact", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSecurityCenterAssessmentPolicyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

}
