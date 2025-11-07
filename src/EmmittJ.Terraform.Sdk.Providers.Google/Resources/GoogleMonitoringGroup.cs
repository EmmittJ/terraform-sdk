using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_monitoring_group resource.
/// </summary>
public class GoogleMonitoringGroup : TerraformResource
{
    public GoogleMonitoringGroup(string name) : base("google_monitoring_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// A user-assigned name for this group, used only for display
    /// purposes.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The filter used to determine which monitored resources
    /// belong to this group.
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
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
    /// If true, the members of this group are considered to be a
    /// cluster. The system can perform additional analysis on
    /// groups that are clusters.
    /// </summary>
    public TerraformProperty<bool>? IsCluster
    {
        get => GetProperty<TerraformProperty<bool>>("is_cluster");
        set => this.WithProperty("is_cluster", value);
    }

    /// <summary>
    /// The name of the group&#39;s parent, if it has one. The format is
    /// &amp;quot;projects/{project_id_or_number}/groups/{group_id}&amp;quot;. For
    /// groups with no parent, parentName is the empty string, &amp;quot;&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? ParentName
    {
        get => GetProperty<TerraformProperty<string>>("parent_name");
        set => this.WithProperty("parent_name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// A unique identifier for this group. The format is
    /// &amp;quot;projects/{project_id_or_number}/groups/{group_id}&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
