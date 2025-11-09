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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disconnect_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? DisconnectTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("disconnect_timeout_in_seconds");
        set => this.WithProperty("disconnect_timeout_in_seconds", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableDefaultInternetAccess
    {
        get => GetProperty<TerraformProperty<bool>>("enable_default_internet_access");
        set => this.WithProperty("enable_default_internet_access", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformProperty<string>? FleetType
    {
        get => GetProperty<TerraformProperty<string>>("fleet_type");
        set => this.WithProperty("fleet_type", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
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
    /// The idle_disconnect_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IdleDisconnectTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("idle_disconnect_timeout_in_seconds");
        set => this.WithProperty("idle_disconnect_timeout_in_seconds", value);
    }

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ImageArn
    {
        get => GetProperty<TerraformProperty<string>>("image_arn");
        set => this.WithProperty("image_arn", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformProperty<string>? ImageName
    {
        get => GetProperty<TerraformProperty<string>>("image_name");
        set => this.WithProperty("image_name", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The max_sessions_per_instance attribute.
    /// </summary>
    public TerraformProperty<double>? MaxSessionsPerInstance
    {
        get => GetProperty<TerraformProperty<double>>("max_sessions_per_instance");
        set => this.WithProperty("max_sessions_per_instance", value);
    }

    /// <summary>
    /// The max_user_duration_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxUserDurationInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("max_user_duration_in_seconds");
        set => this.WithProperty("max_user_duration_in_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The stream_view attribute.
    /// </summary>
    public TerraformProperty<string>? StreamView
    {
        get => GetProperty<TerraformProperty<string>>("stream_view");
        set => this.WithProperty("stream_view", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
