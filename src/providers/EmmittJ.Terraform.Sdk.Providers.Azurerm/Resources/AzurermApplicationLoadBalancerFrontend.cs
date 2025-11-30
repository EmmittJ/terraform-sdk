using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApplicationLoadBalancerFrontend.
/// Nesting mode: single
/// </summary>
public class AzurermApplicationLoadBalancerFrontendTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_application_load_balancer_frontend Terraform resource.
/// Manages a azurerm_application_load_balancer_frontend resource.
/// </summary>
public partial class AzurermApplicationLoadBalancerFrontend(string name) : TerraformResource("azurerm_application_load_balancer_frontend", name)
{
    /// <summary>
    /// The application_load_balancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationLoadBalancerId is required")]
    public required TerraformValue<string> ApplicationLoadBalancerId
    {
        get => new TerraformReference<string>(this, "application_load_balancer_id");
        set => SetArgument("application_load_balancer_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The fully_qualified_domain_name attribute.
    /// </summary>
    public TerraformValue<string> FullyQualifiedDomainName
    {
        get => new TerraformReference<string>(this, "fully_qualified_domain_name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationLoadBalancerFrontendTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationLoadBalancerFrontendTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
