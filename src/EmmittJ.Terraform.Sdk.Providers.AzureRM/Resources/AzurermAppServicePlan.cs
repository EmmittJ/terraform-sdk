using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServicePlanSkuBlock : TerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformProperty<double>? Capacity
    {
        get => GetProperty<TerraformProperty<double>>("capacity");
        set => WithProperty("capacity", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<string> Size
    {
        get => GetProperty<TerraformProperty<string>>("size");
        set => WithProperty("size", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => WithProperty("tier", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServicePlanTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_app_service_plan resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAppServicePlan : TerraformResource
{
    public AzurermAppServicePlan(string name) : base("azurerm_app_service_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("maximum_number_of_workers");
    }

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    public TerraformProperty<string>? AppServiceEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("app_service_environment_id");
        set => this.WithProperty("app_service_environment_id", value);
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
    /// The is_xenon attribute.
    /// </summary>
    public TerraformProperty<bool>? IsXenon
    {
        get => GetProperty<TerraformProperty<bool>>("is_xenon");
        set => this.WithProperty("is_xenon", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumElasticWorkerCount
    {
        get => GetProperty<TerraformProperty<double>>("maximum_elastic_worker_count");
        set => this.WithProperty("maximum_elastic_worker_count", value);
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
    /// The per_site_scaling attribute.
    /// </summary>
    public TerraformProperty<bool>? PerSiteScaling
    {
        get => GetProperty<TerraformProperty<bool>>("per_site_scaling");
        set => this.WithProperty("per_site_scaling", value);
    }

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    public TerraformProperty<bool>? Reserved
    {
        get => GetProperty<TerraformProperty<bool>>("reserved");
        set => this.WithProperty("reserved", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneRedundant
    {
        get => GetProperty<TerraformProperty<bool>>("zone_redundant");
        set => this.WithProperty("zone_redundant", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermAppServicePlanSkuBlock>? Sku
    {
        get => GetProperty<List<AzurermAppServicePlanSkuBlock>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServicePlanTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppServicePlanTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The maximum_number_of_workers attribute.
    /// </summary>
    public TerraformExpression MaximumNumberOfWorkers => this["maximum_number_of_workers"];

}
