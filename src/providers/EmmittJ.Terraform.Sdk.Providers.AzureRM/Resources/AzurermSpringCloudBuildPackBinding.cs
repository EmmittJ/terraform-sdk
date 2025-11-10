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
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// The secrets attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Secrets
    {
        set => SetProperty("secrets", value);
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
/// Manages a azurerm_spring_cloud_build_pack_binding resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudBuildPackBinding : TerraformResource
{
    public AzurermSpringCloudBuildPackBinding(string name) : base("azurerm_spring_cloud_build_pack_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("binding_type");
        SetOutput("id");
        SetOutput("name");
        SetOutput("spring_cloud_builder_id");
    }

    /// <summary>
    /// The binding_type attribute.
    /// </summary>
    public TerraformProperty<string> BindingType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("binding_type");
        set => SetProperty("binding_type", value);
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
    /// The spring_cloud_builder_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudBuilderId is required")]
    public required TerraformProperty<string> SpringCloudBuilderId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spring_cloud_builder_id");
        set => SetProperty("spring_cloud_builder_id", value);
    }

    /// <summary>
    /// Block for launch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Launch block(s) allowed")]
    public List<AzurermSpringCloudBuildPackBindingLaunchBlock>? Launch
    {
        set => SetProperty("launch", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudBuildPackBindingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
