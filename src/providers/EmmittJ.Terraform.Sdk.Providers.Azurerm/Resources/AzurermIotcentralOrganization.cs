using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermIotcentralOrganization.
/// Nesting mode: single
/// </summary>
public class AzurermIotcentralOrganizationTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_iotcentral_organization Terraform resource.
/// Manages a azurerm_iotcentral_organization resource.
/// </summary>
public partial class AzurermIotcentralOrganization(string name) : TerraformResource("azurerm_iotcentral_organization", name)
{
    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iotcentral_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IotcentralApplicationId is required")]
    public required TerraformValue<string> IotcentralApplicationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("iotcentral_application_id");
        set => SetArgument("iotcentral_application_id", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationId is required")]
    public required TerraformValue<string> OrganizationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("organization_id");
        set => SetArgument("organization_id", value);
    }

    /// <summary>
    /// The parent_organization_id attribute.
    /// </summary>
    public TerraformValue<string>? ParentOrganizationId
    {
        get => GetArgument<TerraformValue<string>>("parent_organization_id");
        set => SetArgument("parent_organization_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIotcentralOrganizationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIotcentralOrganizationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
