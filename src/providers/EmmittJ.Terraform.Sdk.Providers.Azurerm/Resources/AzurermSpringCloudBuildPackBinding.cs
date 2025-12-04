using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for launch in AzurermSpringCloudBuildPackBinding.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudBuildPackBindingLaunchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch";

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The secrets attribute.
    /// </summary>
    public TerraformMap<string>? Secrets
    {
        get => GetArgument<TerraformMap<string>>("secrets");
        set => SetArgument("secrets", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSpringCloudBuildPackBinding.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudBuildPackBindingTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_spring_cloud_build_pack_binding Terraform resource.
/// Manages a azurerm_spring_cloud_build_pack_binding resource.
/// </summary>
public partial class AzurermSpringCloudBuildPackBinding(string name) : TerraformResource("azurerm_spring_cloud_build_pack_binding", name)
{
    /// <summary>
    /// The binding_type attribute.
    /// </summary>
    public TerraformValue<string>? BindingType
    {
        get => GetArgument<TerraformValue<string>>("binding_type");
        set => SetArgument("binding_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The spring_cloud_builder_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudBuilderId is required")]
    public required TerraformValue<string> SpringCloudBuilderId
    {
        get => GetArgument<TerraformValue<string>>("spring_cloud_builder_id");
        set => SetArgument("spring_cloud_builder_id", value);
    }

    /// <summary>
    /// Launch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Launch block(s) allowed")]
    public TerraformList<AzurermSpringCloudBuildPackBindingLaunchBlock>? Launch
    {
        get => GetArgument<TerraformList<AzurermSpringCloudBuildPackBindingLaunchBlock>>("launch");
        set => SetArgument("launch", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudBuildPackBindingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudBuildPackBindingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
