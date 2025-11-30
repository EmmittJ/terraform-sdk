using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSpringCloudApiPortalCustomDomain.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudApiPortalCustomDomainTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_spring_cloud_api_portal_custom_domain Terraform resource.
/// Manages a azurerm_spring_cloud_api_portal_custom_domain resource.
/// </summary>
public partial class AzurermSpringCloudApiPortalCustomDomain(string name) : TerraformResource("azurerm_spring_cloud_api_portal_custom_domain", name)
{
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
    /// The spring_cloud_api_portal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudApiPortalId is required")]
    public required TerraformValue<string> SpringCloudApiPortalId
    {
        get => new TerraformReference<string>(this, "spring_cloud_api_portal_id");
        set => SetArgument("spring_cloud_api_portal_id", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string>? Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
        set => SetArgument("thumbprint", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudApiPortalCustomDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudApiPortalCustomDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
