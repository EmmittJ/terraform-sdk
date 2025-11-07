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
    public TerraformProperty<string>? AgentName
    {
        get => GetProperty<TerraformProperty<string>>("agent_name");
        set => this.WithProperty("agent_name", value);
    }

    /// <summary>
    /// The copy_mode attribute.
    /// </summary>
    public TerraformProperty<string>? CopyMode
    {
        get => GetProperty<TerraformProperty<string>>("copy_mode");
        set => this.WithProperty("copy_mode", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The source_name attribute.
    /// </summary>
    public TerraformProperty<string>? SourceName
    {
        get => GetProperty<TerraformProperty<string>>("source_name");
        set => this.WithProperty("source_name", value);
    }

    /// <summary>
    /// The source_sub_path attribute.
    /// </summary>
    public TerraformProperty<string>? SourceSubPath
    {
        get => GetProperty<TerraformProperty<string>>("source_sub_path");
        set => this.WithProperty("source_sub_path", value);
    }

    /// <summary>
    /// The storage_mover_project_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageMoverProjectId
    {
        get => GetProperty<TerraformProperty<string>>("storage_mover_project_id");
        set => this.WithProperty("storage_mover_project_id", value);
    }

    /// <summary>
    /// The target_name attribute.
    /// </summary>
    public TerraformProperty<string>? TargetName
    {
        get => GetProperty<TerraformProperty<string>>("target_name");
        set => this.WithProperty("target_name", value);
    }

    /// <summary>
    /// The target_sub_path attribute.
    /// </summary>
    public TerraformProperty<string>? TargetSubPath
    {
        get => GetProperty<TerraformProperty<string>>("target_sub_path");
        set => this.WithProperty("target_sub_path", value);
    }

}
