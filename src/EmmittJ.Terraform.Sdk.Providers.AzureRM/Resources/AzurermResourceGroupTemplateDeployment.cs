using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    /// The deployment_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentMode
    {
        get => GetProperty<TerraformProperty<string>>("deployment_mode");
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
    public TerraformProperty<string>? Name
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
    /// The output_content attribute.
    /// </summary>
    public TerraformExpression OutputContent => this["output_content"];

}
