using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_logging_folder_exclusion resource.
/// </summary>
public class GoogleLoggingFolderExclusion : TerraformResource
{
    public GoogleLoggingFolderExclusion(string name) : base("google_logging_folder_exclusion", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// A human-readable description.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Whether this exclusion rule should be disabled or not. This defaults to false.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The filter to apply when excluding logs. Only log entries that match the filter are excluded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    public required TerraformProperty<string> Folder
    {
        get => GetProperty<TerraformProperty<string>>("folder");
        set => this.WithProperty("folder", value);
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
    /// The name of the logging exclusion.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

}
