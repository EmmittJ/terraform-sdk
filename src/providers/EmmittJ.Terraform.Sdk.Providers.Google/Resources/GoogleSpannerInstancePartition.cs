using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSpannerInstancePartitionTimeoutsBlock : TerraformBlock
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
/// Manages a google_spanner_instance_partition resource.
/// </summary>
public class GoogleSpannerInstancePartition : TerraformResource
{
    public GoogleSpannerInstancePartition(string name) : base("google_spanner_instance_partition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("state");
        SetOutput("config");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("instance");
        SetOutput("name");
        SetOutput("node_count");
        SetOutput("processing_units");
        SetOutput("project");
    }

    /// <summary>
    /// The name of the instance partition&#39;s configuration (similar to a region) which
    /// defines the geographic placement and replication of data in this instance partition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    public required TerraformProperty<string> Config
    {
        get => GetRequiredOutput<TerraformProperty<string>>("config");
        set => SetProperty("config", value);
    }

    /// <summary>
    /// The descriptive name for this instance partition as it appears in UIs.
    /// Must be unique per project and between 4 and 30 characters in length.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The instance to create the instance partition in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// A unique identifier for the instance partition, which cannot be changed after
    /// the instance partition is created. The name must be between 2 and 64 characters
    /// and match the regular expression [a-z][a-z0-9\\-]{0,61}[a-z0-9].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The number of nodes allocated to this instance partition. One node equals
    /// 1000 processing units. Exactly one of either node_count or processing_units
    /// must be present.
    /// </summary>
    public TerraformProperty<double> NodeCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("node_count");
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// The number of processing units allocated to this instance partition.
    /// Exactly one of either node_count or processing_units must be present.
    /// </summary>
    public TerraformProperty<double> ProcessingUnits
    {
        get => GetRequiredOutput<TerraformProperty<double>>("processing_units");
        set => SetProperty("processing_units", value);
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
    public GoogleSpannerInstancePartitionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The current instance partition state. Possible values are:
    /// CREATING: The instance partition is being created. Resources are being
    /// allocated for the instance partition.
    /// READY: The instance partition has been allocated resources and is ready for use.
    /// </summary>
    public TerraformExpression State => this["state"];

}
