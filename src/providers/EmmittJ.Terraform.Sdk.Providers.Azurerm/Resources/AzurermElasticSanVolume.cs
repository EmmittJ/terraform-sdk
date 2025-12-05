using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for create_source in AzurermElasticSanVolume.
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanVolumeCreateSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "create_source";

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceId is required")]
    public required TerraformValue<string> SourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_id");
        set => SetArgument("source_id", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    public required TerraformValue<string> SourceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_type");
        set => SetArgument("source_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermElasticSanVolume.
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanVolumeTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_elastic_san_volume Terraform resource.
/// Manages a azurerm_elastic_san_volume resource.
/// </summary>
public partial class AzurermElasticSanVolume(string name) : TerraformResource("azurerm_elastic_san_volume", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The size_in_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGib is required")]
    public required TerraformValue<double> SizeInGib
    {
        get => GetRequiredArgument<TerraformValue<double>>("size_in_gib");
        set => SetArgument("size_in_gib", value);
    }

    /// <summary>
    /// The volume_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeGroupId is required")]
    public required TerraformValue<string> VolumeGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("volume_group_id");
        set => SetArgument("volume_group_id", value);
    }

    /// <summary>
    /// The target_iqn attribute.
    /// </summary>
    public TerraformValue<string> TargetIqn
        => CreateReference("target_iqn");

    /// <summary>
    /// The target_portal_hostname attribute.
    /// </summary>
    public TerraformValue<string> TargetPortalHostname
        => CreateReference("target_portal_hostname");

    /// <summary>
    /// The target_portal_port attribute.
    /// </summary>
    public TerraformValue<double> TargetPortalPort
        => CreateReference("target_portal_port");

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformValue<string> VolumeId
        => CreateReference("volume_id");

    /// <summary>
    /// CreateSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreateSource block(s) allowed")]
    public TerraformList<AzurermElasticSanVolumeCreateSourceBlock>? CreateSource
    {
        get => GetArgument<TerraformList<AzurermElasticSanVolumeCreateSourceBlock>>("create_source");
        set => SetArgument("create_source", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermElasticSanVolumeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermElasticSanVolumeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
