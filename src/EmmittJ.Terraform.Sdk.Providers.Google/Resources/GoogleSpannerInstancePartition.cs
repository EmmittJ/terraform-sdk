using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The name of the instance partition&#39;s configuration (similar to a region) which
    /// defines the geographic placement and replication of data in this instance partition.
    /// </summary>
    public TerraformProperty<string>? Config
    {
        get => GetProperty<TerraformProperty<string>>("config");
        set => this.WithProperty("config", value);
    }

    /// <summary>
    /// The descriptive name for this instance partition as it appears in UIs.
    /// Must be unique per project and between 4 and 30 characters in length.
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
    /// The instance to create the instance partition in.
    /// </summary>
    public TerraformProperty<string>? Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// A unique identifier for the instance partition, which cannot be changed after
    /// the instance partition is created. The name must be between 2 and 64 characters
    /// and match the regular expression [a-z][a-z0-9\\-]{0,61}[a-z0-9].
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The number of nodes allocated to this instance partition. One node equals
    /// 1000 processing units. Exactly one of either node_count or processing_units
    /// must be present.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => this.WithProperty("node_count", value);
    }

    /// <summary>
    /// The number of processing units allocated to this instance partition.
    /// Exactly one of either node_count or processing_units must be present.
    /// </summary>
    public TerraformProperty<double>? ProcessingUnits
    {
        get => GetProperty<TerraformProperty<double>>("processing_units");
        set => this.WithProperty("processing_units", value);
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
    /// The current instance partition state. Possible values are:
    /// CREATING: The instance partition is being created. Resources are being
    /// allocated for the instance partition.
    /// READY: The instance partition has been allocated resources and is ready for use.
    /// </summary>
    public TerraformExpression State => this["state"];

}
