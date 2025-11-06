using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_mover_job_definition resource.
/// </summary>
public class AzurermStorageMoverJobDefinition : TerraformResource
{
    public AzurermStorageMoverJobDefinition(string name) : base("azurerm_storage_mover_job_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    public string? AgentName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_name")?.Value;
        set => this.WithProperty("agent_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The copy_mode attribute.
    /// </summary>
    public string? CopyMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("copy_mode")?.Value;
        set => this.WithProperty("copy_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    public string? SourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_name")?.Value;
        set => this.WithProperty("source_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_sub_path attribute.
    /// </summary>
    public string? SourceSubPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_sub_path")?.Value;
        set => this.WithProperty("source_sub_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_mover_project_id attribute.
    /// </summary>
    public string? StorageMoverProjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_mover_project_id")?.Value;
        set => this.WithProperty("storage_mover_project_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_name attribute.
    /// </summary>
    public string? TargetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_name")?.Value;
        set => this.WithProperty("target_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_sub_path attribute.
    /// </summary>
    public string? TargetSubPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_sub_path")?.Value;
        set => this.WithProperty("target_sub_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
