using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_instance_group.
/// </summary>
public class GoogleComputeInstanceGroupDataSource : TerraformDataSource
{
    public GoogleComputeInstanceGroupDataSource(string name) : base("google_compute_instance_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("instances");
        this.DeclareOutput("named_port");
        this.DeclareOutput("network");
        this.DeclareOutput("size");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The self_link attribute.
    /// </summary>
    public string? SelfLink
    {
        get => GetProperty<TerraformLiteralProperty<string>>("self_link")?.Value;
        set => this.WithProperty("self_link", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformExpression Instances => this["instances"];

    /// <summary>
    /// The named_port attribute.
    /// </summary>
    public TerraformExpression NamedPort => this["named_port"];

    /// <summary>
    /// The network attribute.
    /// </summary>
    public TerraformExpression Network => this["network"];

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformExpression Size => this["size"];

}
