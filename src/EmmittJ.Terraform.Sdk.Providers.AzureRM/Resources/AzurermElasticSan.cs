using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_elastic_san resource.
/// </summary>
public class AzurermElasticSan : TerraformResource
{
    public AzurermElasticSan(string name) : base("azurerm_elastic_san", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("total_iops");
        this.DeclareOutput("total_mbps");
        this.DeclareOutput("total_size_in_tib");
        this.DeclareOutput("total_volume_size_in_gib");
        this.DeclareOutput("volume_group_count");
    }

    /// <summary>
    /// The base_size_in_tib attribute.
    /// </summary>
    public TerraformProperty<double>? BaseSizeInTib
    {
        get => GetProperty<TerraformProperty<double>>("base_size_in_tib");
        set => this.WithProperty("base_size_in_tib", value);
    }

    /// <summary>
    /// The extended_size_in_tib attribute.
    /// </summary>
    public TerraformProperty<double>? ExtendedSizeInTib
    {
        get => GetProperty<TerraformProperty<double>>("extended_size_in_tib");
        set => this.WithProperty("extended_size_in_tib", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

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

}
