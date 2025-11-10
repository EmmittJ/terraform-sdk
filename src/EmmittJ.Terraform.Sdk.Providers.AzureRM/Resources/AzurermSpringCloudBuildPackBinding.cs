using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for launch in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudBuildPackBindingLaunchBlock : TerraformBlock
{
    /// <summary>
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
    }

    /// <summary>
    /// The secrets attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Secrets
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("secrets");
        set => WithProperty("secrets", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudBuildPackBindingTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_spring_cloud_build_pack_binding resource.
/// </summary>
public class AzurermSpringCloudBuildPackBinding : TerraformResource
{
    public AzurermSpringCloudBuildPackBinding(string name) : base("azurerm_spring_cloud_build_pack_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The binding_type attribute.
    /// </summary>
    public TerraformProperty<string>? BindingType
    {
        get => GetProperty<TerraformProperty<string>>("binding_type");
        set => this.WithProperty("binding_type", value);
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
    /// The spring_cloud_builder_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudBuilderId is required")]
    public required TerraformProperty<string> SpringCloudBuilderId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_builder_id");
        set => this.WithProperty("spring_cloud_builder_id", value);
    }

    /// <summary>
    /// Block for launch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Launch block(s) allowed")]
    public List<AzurermSpringCloudBuildPackBindingLaunchBlock>? Launch
    {
        get => GetProperty<List<AzurermSpringCloudBuildPackBindingLaunchBlock>>("launch");
        set => this.WithProperty("launch", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudBuildPackBindingTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudBuildPackBindingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
