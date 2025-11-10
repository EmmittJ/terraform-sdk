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
        set => SetProperty("read", value);
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
        SetOutput("base_size_in_tib");
        SetOutput("extended_size_in_tib");
        SetOutput("location");
        SetOutput("sku");
        SetOutput("tags");
        SetOutput("total_iops");
        SetOutput("total_mbps");
        SetOutput("total_size_in_tib");
        SetOutput("total_volume_size_in_gib");
        SetOutput("volume_group_count");
        SetOutput("zones");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermElasticSanDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
