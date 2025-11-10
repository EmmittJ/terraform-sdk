using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermResourceGroupTemplateDeploymentTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_resource_group_template_deployment resource.
/// </summary>
public class AzurermResourceGroupTemplateDeployment : TerraformResource
{
    public AzurermResourceGroupTemplateDeployment(string name) : base("azurerm_resource_group_template_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutpututput_content");
    }

    /// <summary>
    /// The debug_level attribute.
    /// </summary>
    public TerraformProperty<string>? DebugLevel
    {
        get => GetProperty<TerraformProperty<string>>("debug_level");
        set => this.WithProperty("debug_level", value);
    }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentMode is required")]
    public required TerraformProperty<string> DeploymentMode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("deployment_mode");
        set => this.WithProperty("deployment_mode", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters_content attribute.
    /// </summary>
    public TerraformProperty<string>? ParametersContent
    {
        get => GetProperty<TerraformProperty<string>>("parameters_content");
        set => this.WithProperty("parameters_content", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
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
    /// The template_content attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateContent
    {
        get => GetProperty<TerraformProperty<string>>("template_content");
        set => this.WithProperty("template_content", value);
    }

    /// <summary>
    /// The template_spec_version_id attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateSpecVersionId
    {
        get => GetProperty<TerraformProperty<string>>("template_spec_version_id");
        set => this.WithProperty("template_spec_version_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermResourceGroupTemplateDeploymentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermResourceGroupTemplateDeploymentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The output_content attribute.
    /// </summary>
    public TerraformExpression OutputContent => this["output_content"];

}
