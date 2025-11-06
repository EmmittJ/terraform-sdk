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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location to list the backup plan associations from.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource type of workload on which backup plan is applied. Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;.
    /// </summary>
    public string? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type")?.Value;
        set => this.WithProperty("resource_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A list of the backup plan associations found.
    /// </summary>
    public TerraformExpression Associations => this["associations"];

}
