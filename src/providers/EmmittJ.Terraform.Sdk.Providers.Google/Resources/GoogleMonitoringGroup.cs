using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringGroupTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("name");
        SetOutput("display_name");
        SetOutput("filter");
        SetOutput("id");
        SetOutput("is_cluster");
        SetOutput("parent_name");
        SetOutput("project");
    }

    /// <summary>
    /// A user-assigned name for this group, used only for display
    /// purposes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The filter used to determine which monitored resources
    /// belong to this group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter");
        set => SetProperty("filter", value);
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
    /// If true, the members of this group are considered to be a
    /// cluster. The system can perform additional analysis on
    /// groups that are clusters.
    /// </summary>
    public TerraformProperty<bool> IsCluster
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_cluster");
        set => SetProperty("is_cluster", value);
    }

    /// <summary>
    /// The name of the group&#39;s parent, if it has one. The format is
    /// &amp;quot;projects/{project_id_or_number}/groups/{group_id}&amp;quot;. For
    /// groups with no parent, parentName is the empty string, &amp;quot;&amp;quot;.
    /// </summary>
    public TerraformProperty<string> ParentName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_name");
        set => SetProperty("parent_name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMonitoringGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// A unique identifier for this group. The format is
    /// &amp;quot;projects/{project_id_or_number}/groups/{group_id}&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
