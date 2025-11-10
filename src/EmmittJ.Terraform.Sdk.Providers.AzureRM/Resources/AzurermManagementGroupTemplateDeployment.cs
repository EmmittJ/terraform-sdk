using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupTemplateDeploymentTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_management_group_template_deployment resource.
/// </summary>
public class AzurermManagementGroupTemplateDeployment : TerraformResource
{
    public AzurermManagementGroupTemplateDeployment(string name) : base("azurerm_management_group_template_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("output_content");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    public required TerraformProperty<string> ManagementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("management_group_id");
        set => this.WithProperty("management_group_id", value);
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
    /// The parameters_content attribute.
    /// </summary>
    public TerraformProperty<string>? ParametersContent
    {
        get => GetProperty<TerraformProperty<string>>("parameters_content");
        set => this.WithProperty("parameters_content", value);
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
    public AzurermManagementGroupTemplateDeploymentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermManagementGroupTemplateDeploymentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The output_content attribute.
    /// </summary>
    public TerraformExpression OutputContent => this["output_content"];

}
