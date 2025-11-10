using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for default_cluster_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubFleetDefaultClusterConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubFleetTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_gke_hub_fleet resource.
/// </summary>
public class GoogleGkeHubFleet : TerraformResource
{
    public GoogleGkeHubFleet(string name) : base("google_gke_hub_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("delete_time");
        this.DeclareOutput("state");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// A user-assigned display name of the Fleet. When present, it must be between 4 to 30 characters.
    /// Allowed characters are: lowercase and uppercase letters, numbers, hyphen, single-quote, double-quote, space, and exclamation point.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for default_cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultClusterConfig block(s) allowed")]
    public List<GoogleGkeHubFleetDefaultClusterConfigBlock>? DefaultClusterConfig
    {
        get => GetProperty<List<GoogleGkeHubFleetDefaultClusterConfigBlock>>("default_cluster_config");
        set => this.WithProperty("default_cluster_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeHubFleetTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleGkeHubFleetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The time the fleet was created, in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The time the fleet was deleted, in RFC3339 text format.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// The state of the fleet resource.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Google-generated UUID for this resource. This is unique across all
    /// Fleet resources. If a Fleet resource is deleted and another
    /// resource with the same name is created, it gets a different uid.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time the fleet was last updated, in RFC3339 text format.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
