using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appstream_fleet resource.
/// </summary>
public class AwsAppstreamFleet : TerraformResource
{
    public AwsAppstreamFleet(string name) : base("aws_appstream_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_time");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disconnect_timeout_in_seconds attribute.
    /// </summary>
    public double? DisconnectTimeoutInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disconnect_timeout_in_seconds")?.Value;
        set => this.WithProperty("disconnect_timeout_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    public bool? EnableDefaultInternetAccess
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_default_internet_access")?.Value;
        set => this.WithProperty("enable_default_internet_access", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public string? FleetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fleet_type")?.Value;
        set => this.WithProperty("fleet_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public string? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn")?.Value;
        set => this.WithProperty("iam_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The idle_disconnect_timeout_in_seconds attribute.
    /// </summary>
    public double? IdleDisconnectTimeoutInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("idle_disconnect_timeout_in_seconds")?.Value;
        set => this.WithProperty("idle_disconnect_timeout_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    public string? ImageArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_arn")?.Value;
        set => this.WithProperty("image_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public string? ImageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_name")?.Value;
        set => this.WithProperty("image_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => this.WithProperty("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_sessions_per_instance attribute.
    /// </summary>
    public double? MaxSessionsPerInstance
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_sessions_per_instance")?.Value;
        set => this.WithProperty("max_sessions_per_instance", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_user_duration_in_seconds attribute.
    /// </summary>
    public double? MaxUserDurationInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_user_duration_in_seconds")?.Value;
        set => this.WithProperty("max_user_duration_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The stream_view attribute.
    /// </summary>
    public string? StreamView
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_view")?.Value;
        set => this.WithProperty("stream_view", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
