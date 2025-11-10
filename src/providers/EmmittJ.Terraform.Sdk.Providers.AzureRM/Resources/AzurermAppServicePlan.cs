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
        set => SetProperty("capacity", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<string> Size
    {
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        set => SetProperty("tier", value);
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
        SetOutput("maximum_number_of_workers");
        SetOutput("app_service_environment_id");
        SetOutput("id");
        SetOutput("is_xenon");
        SetOutput("kind");
        SetOutput("location");
        SetOutput("maximum_elastic_worker_count");
        SetOutput("name");
        SetOutput("per_site_scaling");
        SetOutput("reserved");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("zone_redundant");
    }

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    public TerraformProperty<string> AppServiceEnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_service_environment_id");
        set => SetProperty("app_service_environment_id", value);
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
    /// The is_xenon attribute.
    /// </summary>
    public TerraformProperty<bool> IsXenon
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_xenon");
        set => SetProperty("is_xenon", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string> Kind
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kind");
        set => SetProperty("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    public TerraformProperty<double> MaximumElasticWorkerCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_elastic_worker_count");
        set => SetProperty("maximum_elastic_worker_count", value);
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
    /// The per_site_scaling attribute.
    /// </summary>
    public TerraformProperty<bool> PerSiteScaling
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("per_site_scaling");
        set => SetProperty("per_site_scaling", value);
    }

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    public TerraformProperty<bool> Reserved
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("reserved");
        set => SetProperty("reserved", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformProperty<bool> ZoneRedundant
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("zone_redundant");
        set => SetProperty("zone_redundant", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermAppServicePlanSkuBlock>? Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServicePlanTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The maximum_number_of_workers attribute.
    /// </summary>
    public TerraformExpression MaximumNumberOfWorkers => this["maximum_number_of_workers"];

}
