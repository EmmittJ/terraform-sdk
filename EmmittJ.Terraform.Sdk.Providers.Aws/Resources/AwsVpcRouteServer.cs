using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_route_server resource.
/// </summary>
public class AwsVpcRouteServer : TerraformResource
{
    public AwsVpcRouteServer(string name) : base("aws_vpc_route_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("route_server_id");
        this.DeclareOutput("sns_topic_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    public double? AmazonSideAsn
    {
        get => GetProperty<TerraformLiteralProperty<double>>("amazon_side_asn")?.Value;
        set => this.WithProperty("amazon_side_asn", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The persist_routes attribute.
    /// </summary>
    public string? PersistRoutes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("persist_routes")?.Value;
        set => this.WithProperty("persist_routes", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The persist_routes_duration attribute.
    /// </summary>
    public double? PersistRoutesDuration
    {
        get => GetProperty<TerraformLiteralProperty<double>>("persist_routes_duration")?.Value;
        set => this.WithProperty("persist_routes_duration", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sns_notifications_enabled attribute.
    /// </summary>
    public bool? SnsNotificationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sns_notifications_enabled")?.Value;
        set => this.WithProperty("sns_notifications_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    public TerraformExpression RouteServerId => this["route_server_id"];

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformExpression SnsTopicArn => this["sns_topic_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
