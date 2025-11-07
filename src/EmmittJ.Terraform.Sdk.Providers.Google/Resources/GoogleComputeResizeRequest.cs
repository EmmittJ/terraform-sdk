using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_resize_request resource.
/// </summary>
public class GoogleComputeResizeRequest : TerraformResource
{
    public GoogleComputeResizeRequest(string name) : base("google_compute_resize_request", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("state");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// An optional description of this resize-request.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The reference of the instance group manager this ResizeRequest is a part of.
    /// </summary>
    public TerraformProperty<string>? InstanceGroupManager
    {
        get => GetProperty<TerraformProperty<string>>("instance_group_manager");
        set => this.WithProperty("instance_group_manager", value);
    }

    /// <summary>
    /// The name of this resize request. The name must be 1-63 characters long, and comply with RFC1035.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The number of instances to be created by this resize request. The group&#39;s target size will be increased by this number.
    /// </summary>
    public TerraformProperty<double>? ResizeBy
    {
        get => GetProperty<TerraformProperty<double>>("resize_by");
        set => this.WithProperty("resize_by", value);
    }

    /// <summary>
    /// The reference of the compute zone scoping this request. If it is not provided, the provider zone is used.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// The creation timestamp for this resize request in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Current state of the request.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Status of the request.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
