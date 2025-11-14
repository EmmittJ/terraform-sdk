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
public class AzurermStaticSiteCustomDomainTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_static_site_custom_domain resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermStaticSiteCustomDomain : TerraformResource
{
    public AzurermStaticSiteCustomDomain(string name) : base("azurerm_static_site_custom_domain", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformArgument("domain_name")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
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
    /// The static_site_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StaticSiteId is required")]
    [TerraformArgument("static_site_id")]
    public required TerraformValue<string> StaticSiteId
    {
        get => new TerraformReference<string>(this, "static_site_id");
        set => SetArgument("static_site_id", value);
    }

    /// <summary>
    /// The validation_type attribute.
    /// </summary>
    [TerraformArgument("validation_type")]
    public TerraformValue<string>? ValidationType
    {
        get => new TerraformReference<string>(this, "validation_type");
        set => SetArgument("validation_type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStaticSiteCustomDomainTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    [TerraformArgument("validation_token")]
    public TerraformValue<string> ValidationToken
    {
        get => new TerraformReference<string>(this, "validation_token");
    }

}
