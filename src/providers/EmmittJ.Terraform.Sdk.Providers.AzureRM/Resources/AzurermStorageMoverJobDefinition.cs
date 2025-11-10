using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageMoverJobDefinitionTimeoutsBlock : TerraformBlock
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
        SetOutput("agent_name");
        SetOutput("copy_mode");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("source_name");
        SetOutput("source_sub_path");
        SetOutput("storage_mover_project_id");
        SetOutput("target_name");
        SetOutput("target_sub_path");
    }

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    public TerraformProperty<string> AgentName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_name");
        set => SetProperty("agent_name", value);
    }

    /// <summary>
    /// The copy_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyMode is required")]
    public required TerraformProperty<string> CopyMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("copy_mode");
        set => SetProperty("copy_mode", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformProperty<string> SourceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_name");
        set => SetProperty("source_name", value);
    }

    /// <summary>
    /// The source_sub_path attribute.
    /// </summary>
    public TerraformProperty<string> SourceSubPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_sub_path");
        set => SetProperty("source_sub_path", value);
    }

    /// <summary>
    /// The storage_mover_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageMoverProjectId is required")]
    public required TerraformProperty<string> StorageMoverProjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_mover_project_id");
        set => SetProperty("storage_mover_project_id", value);
    }

    /// <summary>
    /// The target_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetName is required")]
    public required TerraformProperty<string> TargetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_name");
        set => SetProperty("target_name", value);
    }

    /// <summary>
    /// The target_sub_path attribute.
    /// </summary>
    public TerraformProperty<string> TargetSubPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_sub_path");
        set => SetProperty("target_sub_path", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageMoverJobDefinitionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
