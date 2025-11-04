using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_container_service resource.
/// </summary>
public class AwsLightsailContainerService : TerraformResource
{
    public AwsLightsailContainerService(string name) : base("aws_lightsail_container_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("created_at");
        this.DeclareOutput("power_id");
        this.DeclareOutput("principal_arn");
        this.DeclareOutput("private_domain_name");
        this.DeclareOutput("resource_type");
        this.DeclareOutput("state");
        this.DeclareOutput("url");
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
    /// The is_disabled attribute.
    /// </summary>
    public bool? IsDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_disabled")?.Value;
        set => this.WithProperty("is_disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The power attribute.
    /// </summary>
    public string? Power
    {
        get => GetProperty<TerraformLiteralProperty<string>>("power")?.Value;
        set => this.WithProperty("power", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scale attribute.
    /// </summary>
    public double? Scale
    {
        get => GetProperty<TerraformLiteralProperty<double>>("scale")?.Value;
        set => this.WithProperty("scale", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The power_id attribute.
    /// </summary>
    public TerraformExpression PowerId => this["power_id"];

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    public TerraformExpression PrincipalArn => this["principal_arn"];

    /// <summary>
    /// The private_domain_name attribute.
    /// </summary>
    public TerraformExpression PrivateDomainName => this["private_domain_name"];

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
