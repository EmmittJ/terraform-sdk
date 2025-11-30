using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStaticSiteCustomDomain.
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

}


/// <summary>
/// Represents a azurerm_static_site_custom_domain Terraform resource.
/// Manages a azurerm_static_site_custom_domain resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermStaticSiteCustomDomain(string name) : TerraformResource("azurerm_static_site_custom_domain", name)
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
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
    /// The static_site_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StaticSiteId is required")]
    public required TerraformValue<string> StaticSiteId
    {
        get => new TerraformReference<string>(this, "static_site_id");
        set => SetArgument("static_site_id", value);
    }

    /// <summary>
    /// The validation_type attribute.
    /// </summary>
    public TerraformValue<string>? ValidationType
    {
        get => new TerraformReference<string>(this, "validation_type");
        set => SetArgument("validation_type", value);
    }

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    public TerraformValue<string> ValidationToken
    {
        get => new TerraformReference<string>(this, "validation_token");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStaticSiteCustomDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStaticSiteCustomDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
