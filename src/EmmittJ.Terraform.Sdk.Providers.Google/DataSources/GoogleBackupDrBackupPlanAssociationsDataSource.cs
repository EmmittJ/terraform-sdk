using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_backup_plan_associations.
/// </summary>
public class GoogleBackupDrBackupPlanAssociationsDataSource : TerraformDataSource
{
    public GoogleBackupDrBackupPlanAssociationsDataSource(string name) : base("google_backup_dr_backup_plan_associations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("associations");
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
    /// The location to list the backup plan associations from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The resource type of workload on which backup plan is applied. Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// A list of the backup plan associations found.
    /// </summary>
    public TerraformExpression Associations => this["associations"];

}
