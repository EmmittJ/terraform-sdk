using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpclattice_access_log_subscription resource.
/// </summary>
public class AwsVpclatticeAccessLogSubscription : TerraformResource
{
    public AwsVpclatticeAccessLogSubscription(string name) : base("aws_vpclattice_access_log_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("resource_arn");
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    public string? DestinationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_arn")?.Value;
        set => this.WithProperty("destination_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_identifier attribute.
    /// </summary>
    public string? ResourceIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_identifier")?.Value;
        set => this.WithProperty("resource_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_network_log_type attribute.
    /// </summary>
    public string? ServiceNetworkLogType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_network_log_type")?.Value;
        set => this.WithProperty("service_network_log_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_arn attribute.
    /// </summary>
    public TerraformExpression ResourceArn => this["resource_arn"];

}
