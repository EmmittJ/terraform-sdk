using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for create_source in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticSanVolumeCreateSourceBlock : TerraformBlock
{
    /// <summary>
    /// The source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceId is required")]
    public required TerraformProperty<string> SourceId
    {
        set => SetProperty("source_id", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    public required TerraformProperty<string> SourceType
    {
        set => SetProperty("source_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanVolumeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("target_iqn");
        SetOutput("target_portal_hostname");
        SetOutput("target_portal_port");
        SetOutput("volume_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("size_in_gib");
        SetOutput("volume_group_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The size_in_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGib is required")]
    public required TerraformProperty<double> SizeInGib
    {
        get => GetRequiredOutput<TerraformProperty<double>>("size_in_gib");
        set => SetProperty("size_in_gib", value);
    }

    /// <summary>
    /// The volume_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeGroupId is required")]
    public required TerraformProperty<string> VolumeGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("volume_group_id");
        set => SetProperty("volume_group_id", value);
    }

    /// <summary>
    /// Block for create_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreateSource block(s) allowed")]
    public List<AzurermElasticSanVolumeCreateSourceBlock>? CreateSource
    {
        set => SetProperty("create_source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermElasticSanVolumeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The target_iqn attribute.
    /// </summary>
    public TerraformExpression TargetIqn => this["target_iqn"];

    /// <summary>
    /// The target_portal_hostname attribute.
    /// </summary>
    public TerraformExpression TargetPortalHostname => this["target_portal_hostname"];

    /// <summary>
    /// The target_portal_port attribute.
    /// </summary>
    public TerraformExpression TargetPortalPort => this["target_portal_port"];

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformExpression VolumeId => this["volume_id"];

}
