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
        SetOutput("description");
        SetOutput("instances");
        SetOutput("named_port");
        SetOutput("network");
        SetOutput("size");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("self_link");
        SetOutput("zone");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The self_link attribute.
    /// </summary>
    public TerraformProperty<string> SelfLink
    {
        get => GetRequiredOutput<TerraformProperty<string>>("self_link");
        set => SetProperty("self_link", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
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
