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
/// Block type for create_source in .
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
    [TerraformArgument("source_id")]
    public required TerraformValue<string> SourceId
    {
        get => new TerraformReference<string>(this, "source_id");
        set => SetArgument("source_id", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    [TerraformArgument("source_type")]
    public required TerraformValue<string> SourceType
    {
        get => new TerraformReference<string>(this, "source_type");
        set => SetArgument("source_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_elastic_san_volume resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermElasticSanVolume : TerraformResource
{
    public AzurermElasticSanVolume(string name) : base("azurerm_elastic_san_volume", name)
    {
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The size_in_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGib is required")]
    [TerraformArgument("size_in_gib")]
    public required TerraformValue<double> SizeInGib
    {
        get => new TerraformReference<double>(this, "size_in_gib");
        set => SetArgument("size_in_gib", value);
    }

    /// <summary>
    /// The volume_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeGroupId is required")]
    [TerraformArgument("volume_group_id")]
    public required TerraformValue<string> VolumeGroupId
    {
        get => new TerraformReference<string>(this, "volume_group_id");
        set => SetArgument("volume_group_id", value);
    }

    /// <summary>
    /// Block for create_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreateSource block(s) allowed")]
    [TerraformArgument("create_source")]
    public TerraformList<AzurermElasticSanVolumeCreateSourceBlock> CreateSource { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermElasticSanVolumeTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The target_iqn attribute.
    /// </summary>
    [TerraformArgument("target_iqn")]
    public TerraformValue<string> TargetIqn
    {
        get => new TerraformReference<string>(this, "target_iqn");
    }

    /// <summary>
    /// The target_portal_hostname attribute.
    /// </summary>
    [TerraformArgument("target_portal_hostname")]
    public TerraformValue<string> TargetPortalHostname
    {
        get => new TerraformReference<string>(this, "target_portal_hostname");
    }

    /// <summary>
    /// The target_portal_port attribute.
    /// </summary>
    [TerraformArgument("target_portal_port")]
    public TerraformValue<double> TargetPortalPort
    {
        get => new TerraformReference<double>(this, "target_portal_port");
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformArgument("volume_id")]
    public TerraformValue<string> VolumeId
    {
        get => new TerraformReference<string>(this, "volume_id");
    }

}
