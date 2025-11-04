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
    public string? Config
    {
        get => GetProperty<TerraformLiteralProperty<string>>("config")?.Value;
        set => this.WithProperty("config", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The descriptive name for this instance partition as it appears in UIs.
    /// Must be unique per project and between 4 and 30 characters in length.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The instance to create the instance partition in.
    /// </summary>
    public string? Instance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance")?.Value;
        set => this.WithProperty("instance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A unique identifier for the instance partition, which cannot be changed after
    /// the instance partition is created. The name must be between 2 and 64 characters
    /// and match the regular expression [a-z][a-z0-9\\-]{0,61}[a-z0-9].
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The number of nodes allocated to this instance partition. One node equals
    /// 1000 processing units. Exactly one of either node_count or processing_units
    /// must be present.
    /// </summary>
    public double? NodeCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("node_count")?.Value;
        set => this.WithProperty("node_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The number of processing units allocated to this instance partition.
    /// Exactly one of either node_count or processing_units must be present.
    /// </summary>
    public double? ProcessingUnits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("processing_units")?.Value;
        set => this.WithProperty("processing_units", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The current instance partition state. Possible values are:
    /// CREATING: The instance partition is being created. Resources are being
    /// allocated for the instance partition.
    /// READY: The instance partition has been allocated resources and is ready for use.
    /// </summary>
    public TerraformExpression State => this["state"];

}
