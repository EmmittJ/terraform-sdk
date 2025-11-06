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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The reference of the instance group manager this ResizeRequest is a part of.
    /// </summary>
    public string? InstanceGroupManager
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_group_manager")?.Value;
        set => this.WithProperty("instance_group_manager", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of this resize request. The name must be 1-63 characters long, and comply with RFC1035.
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
    /// The number of instances to be created by this resize request. The group&#39;s target size will be increased by this number.
    /// </summary>
    public double? ResizeBy
    {
        get => GetProperty<TerraformLiteralProperty<double>>("resize_by")?.Value;
        set => this.WithProperty("resize_by", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The reference of the compute zone scoping this request. If it is not provided, the provider zone is used.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
