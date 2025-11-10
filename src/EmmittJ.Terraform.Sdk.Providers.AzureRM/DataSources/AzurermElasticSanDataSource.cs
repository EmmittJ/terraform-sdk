using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticSanDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_elastic_san.
/// </summary>
public class AzurermElasticSanDataSource : TerraformDataSource
{
    public AzurermElasticSanDataSource(string name) : base("azurerm_elastic_san", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("base_size_in_tib");
        this.DeclareOutput("extended_size_in_tib");
        this.DeclareOutput("location");
        this.DeclareOutput("sku");
        this.DeclareOutput("tags");
        this.DeclareOutput("total_iops");
        this.DeclareOutput("total_mbps");
        this.DeclareOutput("total_size_in_tib");
        this.DeclareOutput("total_volume_size_in_gib");
        this.DeclareOutput("volume_group_count");
        this.DeclareOutput("zones");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermElasticSanDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermElasticSanDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    public TerraformExpression BaseSizeInTib => this["base_size_in_tib"];

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    public TerraformExpression ExtendedSizeInTib => this["extended_size_in_tib"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The total_iops attribute.
    /// </summary>
    public TerraformExpression TotalIops => this["total_iops"];

    /// <summary>
    /// The total_mbps attribute.
    /// </summary>
    public TerraformExpression TotalMbps => this["total_mbps"];

    /// <summary>
    /// The total_size_in_tib attribute.
    /// </summary>
    public TerraformExpression TotalSizeInTib => this["total_size_in_tib"];

    /// <summary>
    /// The total_volume_size_in_gib attribute.
    /// </summary>
    public TerraformExpression TotalVolumeSizeInGib => this["total_volume_size_in_gib"];

    /// <summary>
    /// The volume_group_count attribute.
    /// </summary>
    public TerraformExpression VolumeGroupCount => this["volume_group_count"];

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformExpression Zones => this["zones"];

}
