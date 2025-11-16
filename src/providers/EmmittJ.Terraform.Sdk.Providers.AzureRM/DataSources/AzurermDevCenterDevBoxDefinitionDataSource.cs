using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterDevBoxDefinitionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Represents a azurerm_dev_center_dev_box_definition Terraform data source.
/// Retrieves information about a azurerm_dev_center_dev_box_definition.
/// </summary>
public partial class AzurermDevCenterDevBoxDefinitionDataSource(string name) : TerraformDataSource("azurerm_dev_center_dev_box_definition", name)
{
    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterId is required")]
    public required TerraformValue<string> DevCenterId
    {
        get => new TerraformReference<string>(this, "dev_center_id");
        set => SetArgument("dev_center_id", value);
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
    /// The hibernate_support_enabled attribute.
    /// </summary>
    public TerraformValue<bool> HibernateSupportEnabled
    {
        get => new TerraformReference<bool>(this, "hibernate_support_enabled");
    }

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    public TerraformValue<string> ImageReferenceId
    {
        get => new TerraformReference<string>(this, "image_reference_id");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevCenterDevBoxDefinitionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevCenterDevBoxDefinitionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
