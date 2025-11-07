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
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The disconnect_timeout_in_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DisconnectTimeoutInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("disconnect_timeout_in_seconds");
        set => this.WithProperty("disconnect_timeout_in_seconds", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableDefaultInternetAccess
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_default_internet_access");
        set => this.WithProperty("enable_default_internet_access", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FleetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fleet_type");
        set => this.WithProperty("fleet_type", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The idle_disconnect_timeout_in_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? IdleDisconnectTimeoutInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("idle_disconnect_timeout_in_seconds");
        set => this.WithProperty("idle_disconnect_timeout_in_seconds", value);
    }

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ImageArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_arn");
        set => this.WithProperty("image_arn", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ImageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_name");
        set => this.WithProperty("image_name", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The max_sessions_per_instance attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxSessionsPerInstance
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_sessions_per_instance");
        set => this.WithProperty("max_sessions_per_instance", value);
    }

    /// <summary>
    /// The max_user_duration_in_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxUserDurationInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_user_duration_in_seconds");
        set => this.WithProperty("max_user_duration_in_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The stream_view attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StreamView
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_view");
        set => this.WithProperty("stream_view", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
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
